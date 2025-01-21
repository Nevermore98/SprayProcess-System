using IoTClient.Enums;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.VisualElements;
using Microsoft.Extensions.DependencyInjection;
using MiniExcelLibs;
using NLog;
using SprayProcessSystem.BLL.Dto.DataDto;
using SprayProcessSystem.BLL.Managers;
using SprayProcessSystem.Helper;
using SprayProcessSystem.Model;
using SprayProcessSystem.Model.Entities;
using SprayProcessSystem.UI.UserControls;
using SqlSugar;
using System.Collections.ObjectModel;
using static SprayProcessSystem.Model.Constants;
using Timer = System.Timers.Timer;

namespace SprayProcessSystem.UI.Views
{
    public partial class ViewProductionBoard : UserControl
    {
        private readonly ILogger _logger;
        private readonly DataManager _dataManager;
        private List<Control> _controlList;

        private bool _isPlcConnected = false;
        private CancellationTokenSource _readPlcCts = new();
        private List<PlcVarConfig> _plcVarConfigList = new();
        private Timer _updateControlValueTimer = new();
        private Timer _saveDataTimer = new();
        private Dictionary<string, List<string>> _stationNameAlarmDict = new();


        private float _waterStoveTemperature;
        private float _solidifyStoveTemperature;
        private ObservableCollection<string> _currentTimeLabels;
        private ObservableCollection<double> _waterStoveValues;
        private ObservableCollection<double> _solidifyStoveValues;
        private Timer _chartInsertDataTimer = new();
        private System.Threading.Timer _resetTimer; 

        public ViewProductionBoard()
        {
            InitializeComponent();
            _dataManager = Program.ServiceProvider.GetRequiredService<DataManager>();
            Load += ViewProductionBoard_Load;

            _logger = LogManager.GetCurrentClassLogger();

            _updateControlValueTimer.Interval = 500;
            _updateControlValueTimer.Elapsed += UpdateControlValueTimer_Elapsed;
            _updateControlValueTimer.Start();

            _saveDataTimer.Interval = 10000;
            _saveDataTimer.Elapsed += SaveDataTimer_Elapsed;
            _saveDataTimer.Start();

            lbl_title.Font = new Font(Global.FontCollection.Families[0], 18, FontStyle.Bold);
            lbl_time.Font = new Font(Global.FontCollection.Families[0], 10);
            gridPanel_TitleInfo.Font = new Font(Global.FontCollection.Families[0], 9);
            lbl_sysStatus.Text = "系统状态：正常";
            lbl_sysStatus.ForeColor = new ColorConverter().ConvertFromString("#52c41a") as Color?;

            InitValue();
        }

        private async void SaveDataTimer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            // 添加数据
            var dataAddDto = new DataAddDto();

            foreach (var item in Global.DataNeedSaveList)
            {
                if (!Global.DataNameChToEnDict.ContainsKey(item)) continue;
                // 只要有任何一个值为 null，就表示还没完全读取到数据，直接返回
                if (Global.PlcNameDataDict[item].Value == null) return;

                var chineseName = Global.DataNameChToEnDict[item];
                var value = Global.PlcNameDataDict[item].Value.ToString();
                dataAddDto.GetType().GetProperty(chineseName).SetValue(dataAddDto, value);
            }

            var res = await _dataManager.AddDataAsync(dataAddDto);
            if (res.Result == Constants.Result.Fail)
            {
                Generic.AppendLog($"保存数据失败：{res.Message}", LogLevelEnum.Error, true);
            }
        }

        private void UpdateControlValueTimer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            // 根据读取到的 PLC 值更新控件值
            if (Global.SiemensClient.Connected)
            {
                lbl_temperature.Text = $"厂内温度：{Global.PlcNameDataDict["厂内温度"].Value}℃";
                lbl_humidity.Text = $"厂内湿度：{Global.PlcNameDataDict["厂内湿度"].Value}%";

                if (Global.PlcNameDataDict["水分炉测量温度"].Value != null) _waterStoveTemperature = (float)Global.PlcNameDataDict["水分炉测量温度"].Value;
                if (Global.PlcNameDataDict["固化炉测量温度"].Value != null) _solidifyStoveTemperature = (float)Global.PlcNameDataDict["固化炉测量温度"].Value;

                //遍历所有控件
                foreach (Control control in _controlList)
                {
                    if (control is StationValue deviceValue)
                    {
                        if (Global.PlcNameDataDict.ContainsKey(deviceValue.DeviceName) && Global.PlcNameDataDict[deviceValue.DeviceName].Value != null)
                        {
                            deviceValue.Value = (float)Global.PlcNameDataDict[deviceValue.DeviceName].Value;
                        }
                    }
                    if (control is StationStatus deviceStatus)
                    {
                        if (deviceStatus.DeviceName == "输送机变频器电源")
                        {
                            var powerStatus = deviceStatus.DeviceName + "状态";
                            if (Global.PlcNameDataDict.ContainsKey(powerStatus) && Global.PlcNameDataDict[powerStatus].Value != null)
                            {
                                deviceStatus.Status = (int)Global.PlcNameDataDict[powerStatus].Value == 1;
                            }
                            continue;
                        }

                        var statusName = deviceStatus.DeviceName + "运行状态";
                        if (Global.PlcNameDataDict.ContainsKey(statusName) && Global.PlcNameDataDict[statusName].Value != null)
                        {
                            deviceStatus.Status = (int)Global.PlcNameDataDict[statusName].Value == 1;
                        }
                    }
                    if (control is StationAlarm deviceAlarm)
                    {
                        var alarmName = deviceAlarm.AlarmName + "报警";
                        if (Global.PlcNameDataDict.ContainsKey(alarmName) && Global.PlcNameDataDict[alarmName].Value != null)
                        {
                            Invoke(() =>
                            {
                                var stationName = alarmName.Substring(0, 2);
                                bool IsAlarm = (int)Global.PlcNameDataDict[alarmName].Value == 1;

                                if (_stationNameAlarmDict.ContainsKey(stationName))
                                {
                                    if (IsAlarm && !_stationNameAlarmDict[stationName].Contains(alarmName))
                                    {
                                        _stationNameAlarmDict[stationName].Add(alarmName);
                                    }
                                    if (!IsAlarm && _stationNameAlarmDict[stationName].Contains(alarmName))
                                    {
                                        _stationNameAlarmDict[stationName].Remove(alarmName);
                                    }
                                }
    
                                deviceAlarm.Visible = IsAlarm;
                            });
                        }
                    }
                    if (control is AntdUI.Panel panel)
                    {
                        if (panel.Tag != null && panel.Tag.ToString()!.Contains("报警"))
                        {
                            var stationName = panel.Tag.ToString()!.Substring(0, 2);

                            if (_stationNameAlarmDict[stationName].Count > 0)
                            {
                                Invoke(() =>
                                {
                                    panel.Visible = true;
                                    panel.BringToFront();
                                });
                            }
                            else
                            {
                                Invoke(() =>
                                {
                                    panel.Visible = false;
                                    panel.SendToBack();
                                });
                            }
                        }
                    }
                }
            }
        }


        private void InitValue()
        {
            _stationNameAlarmDict = new Dictionary<string, List<string>>()
            {
                { "脱脂", new List<string>() },
                { "粗洗", new List<string>() },
                { "陶化", new List<string>() },
                { "精洗", new List<string>() },
                { "水分", new List<string>() },
                { "固化", new List<string>() },
                { "冷却", new List<string>() },
                { "输送", new List<string>() },
            };

            _controlList = Generic.GetDescendantControls(this);
            _plcVarConfigList = MiniExcel.Query<PlcVarConfig>(AppConfig.Current.Plc.ConfigPath).ToList();

            foreach (var item in _plcVarConfigList)
            {
                Global.PlcBatchReadDict.Add(item.Address, Enum.Parse<DataTypeEnum>(item.VarType, true));
                Global.PlcNameDataDict.Add(item.Name, new PlcData() { Address = item.Address, Value = null, IsSaved = item.IsSaved });
            }
        }

        private void ViewProductionBoard_Load(object? sender, EventArgs e)
        {
            ConnectPlc();
            InitLineChart();

        }

        private void InitLineChart()
        {
            // 之前还可以设置折线图 dock = fill，但是现在不行了，会被不知道什么东西遮挡
            _waterStoveValues = new ObservableCollection<double>();
            _currentTimeLabels = new ObservableCollection<string>();
            _solidifyStoveValues = new ObservableCollection<double>();

            lineChart_WaterStove.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.Both;
            lineChart_WaterStove.Series = new ObservableCollection<ISeries>
            {
                new LineSeries<double>
                {
                    Values = _waterStoveValues,
                    GeometryStroke = null,
                    GeometryFill = null,
                    Fill = null,
                    LineSmoothness = 0,
                }
            };
            lineChart_WaterStove.Title = new LabelVisual
            {
                Text = "水分炉温度",
                TextSize = 18,
            };
            lineChart_WaterStove.YAxes = new List<Axis>
            {
                new Axis
                {
                    Name = "温度（℃）",
                    NameTextSize = 14
                }
            };
            lineChart_WaterStove.XAxes = new List<Axis>
            {
                new Axis
                {
                    Labels = _currentTimeLabels,
                    LabelsRotation = 30,
                }
            };

            lineChart_WaterStove.MouseWheel += ChartInteractionStarted;
            lineChart_WaterStove.MouseDown += ChartInteractionStarted;
            lineChart_WaterStove.MouseUp += ChartInteractionEnded;

            // 以下事件不触发
            //cartesianChart1.MouseEnter += ChartInteractionStarted;
            //cartesianChart1.MouseLeave += ChartInteractionEnded;
            //cartesianChart1.MouseHover += ChartInteractionStarted;

            lineChart_SolidifyStove.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.Both;
            lineChart_SolidifyStove.Series = new ObservableCollection<ISeries>
            {
                new LineSeries<double>
                {
                    Values = _solidifyStoveValues,
                    GeometryStroke = null,
                    GeometryFill = null,
                    Fill = null,
                    LineSmoothness = 0,
                }
            };
            lineChart_SolidifyStove.Title = new LabelVisual
            {
                Text = "固化炉温度",
                TextSize = 18,
            };
            lineChart_SolidifyStove.YAxes = new List<Axis>
            {
                new Axis
                {
                    Name = "温度（℃）",
                    NameTextSize = 14
                }
            };
            lineChart_SolidifyStove.XAxes = new List<Axis>
            {
                new Axis
                {
                    Labels = _currentTimeLabels,
                    LabelsRotation = 30,
                }
            };
            lineChart_SolidifyStove.MouseWheel += ChartInteractionStarted;
            lineChart_SolidifyStove.MouseDown += ChartInteractionStarted;
            lineChart_SolidifyStove.MouseUp += ChartInteractionEnded;


            _chartInsertDataTimer.Interval = 1000;
            _chartInsertDataTimer.Elapsed += _WaterStoveTempChartTimer_Elapsed;
            _chartInsertDataTimer.Start();

            void ChartInteractionStarted(object sender, EventArgs e)
            {
                _resetTimer?.Dispose();
            }

            void ChartInteractionEnded(object sender, EventArgs e)
            {
                _resetTimer?.Dispose();
                _resetTimer = new System.Threading.Timer(_ =>
                {
                    if (_isPlcConnected)
                    {
                        Invoke(() =>
                        {
                            lineChart_WaterStove.XAxes.FirstOrDefault()!.MinLimit = null;
                            lineChart_WaterStove.XAxes.FirstOrDefault()!.MaxLimit = null;
                            lineChart_WaterStove.YAxes.FirstOrDefault()!.MinLimit = null;
                            lineChart_WaterStove.YAxes.FirstOrDefault()!.MaxLimit = null;

                            lineChart_SolidifyStove.XAxes.FirstOrDefault()!.MinLimit = null;
                            lineChart_SolidifyStove.XAxes.FirstOrDefault()!.MaxLimit = null;
                            lineChart_SolidifyStove.YAxes.FirstOrDefault()!.MinLimit = null;
                            lineChart_SolidifyStove.YAxes.FirstOrDefault()!.MaxLimit = null;
                        });
                    }
                }, null, 4000, Timeout.Infinite);
            }

            void _WaterStoveTempChartTimer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
            {
                if (!_isPlcConnected) return;
                _currentTimeLabels.Add(DateTime.Now.ToString("HH:mm:ss"));
                _waterStoveValues.Add(_waterStoveTemperature);
                _solidifyStoveValues.Add(_solidifyStoveTemperature);

                // 保持最近1200个数据点
                if (_waterStoveValues.Count > 1200)
                {
                    _waterStoveValues.RemoveAt(0);
                    _solidifyStoveValues.RemoveAt(0);
                    _currentTimeLabels.RemoveAt(0);
                }
            }
        }


        private void ConnectPlc()
        {
            try
            {
                Task.Run(async () =>
                {
                    while (!_readPlcCts.IsCancellationRequested)
                    {
                        if (_isPlcConnected)
                        {
                            Invoke(() =>
                            {
                                lbl_plcStatus.Text = "PLC 状态：已连接";
                                lbl_plcStatus.ForeColor = new ColorConverter().ConvertFromString("#52c41a") as Color?;
                            });

                            // 读取 PLC
                            var readResult = Global.SiemensClient.BatchRead(Global.PlcBatchReadDict);
                            if (readResult.IsSucceed)
                            {
                                foreach (var item in _plcVarConfigList)
                                {
                                    Global.PlcNameDataDict[item.Name].Value = readResult.Value[item.Address];
                                }
                            }
                            else
                            {
                                Global.SiemensClient.Close();
                                _isPlcConnected = false;
                                Invoke(() =>
                                {
                                    lbl_plcStatus.Text = "PLC 状态：未连接";
                                    lbl_plcStatus.ForeColor = new ColorConverter().ConvertFromString("#ff4d4f") as Color?;
                                    _waterStoveTemperature = 0;
                                });
                            }

                            await Task.Delay(AppConfig.Current.Plc.ReadInterval);
                        }
                        else
                        {
                            // 重连
                            _logger.Info($"尝试重连 PLC");

                            var reConnectResult = Global.SiemensClient.Open();
                            _isPlcConnected = reConnectResult.IsSucceed;
                            
                            if (_isPlcConnected)
                            {
                                _logger.Info($"PLC 重连成功");
                            }
                            else
                            {
                                _logger.Error($"PLC 重连失败");
                            }

                            if (_isPlcConnected)
                            {
                                Invoke(() =>
                                {
                                    lbl_plcStatus.Text = "PLC 状态：已连接";
                                    lbl_plcStatus.ForeColor = new ColorConverter().ConvertFromString("#52c41a") as Color?;
                                });
                            }
                            else
                            {
                                if (Global.IsAppClosing) return;
                                Invoke(() =>
                                {
                                    lbl_plcStatus.Text = "PLC 状态：未连接";
                                    lbl_plcStatus.ForeColor = new ColorConverter().ConvertFromString("#ff4d4f") as Color?;

                                });
                                await Task.Delay(AppConfig.Current.Plc.ReConnectInterval);
                            }
                        }

                    }
                });
            }
            catch (Exception ex)
            {

            }
        }
    }
}
