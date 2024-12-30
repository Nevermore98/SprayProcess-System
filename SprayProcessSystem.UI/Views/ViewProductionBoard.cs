using IoTClient.Enums;
using MiniExcelLibs;
using NLog;
using SprayProcessSystem.BLL;
using SprayProcessSystem.Model;
using SprayProcessSystem.UI.UserControls;
using Timer = System.Timers.Timer;

namespace SprayProcessSystem.UI.Views
{
    public partial class ViewProductionBoard : UserControl
    {
        private readonly IAppConfigService _appConfig;
        private readonly ILogger _logger;

        private List<Control> _controlList;

        private bool _isPlcConnected = false;
        private CancellationTokenSource _readPlcCts = new();
        private List<PLCVarConfig> _plcVarConfigList = new();
        private Timer _readPlcTimer = new();
        private Dictionary<string, List<string>> _stationNameAlarmDict = new();


        public ViewProductionBoard()
        {
            InitializeComponent();
            Load += ViewProductionBoard_Load;

            _logger = LogManager.GetCurrentClassLogger();
            _readPlcTimer.Interval = 50;
            _readPlcTimer.Elapsed += ReadPlcTimer_Elapsed;
            _readPlcTimer.Start();

            lbl_title.Font = new Font(Global.FontCollection.Families[0], 18, FontStyle.Bold);
            gridPanel_TitleInfo.Font = new Font(Global.FontCollection.Families[0], 9);
            InitValue();
        }

        private void ReadPlcTimer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            if (Global.SiemensClient.Connected)
            {
                lbl_temperature.Text = $"厂内温度：{Global.PlcNameDataDict["厂内温度"].Value}℃";
                lbl_humidity.Text = $"厂内湿度：{Global.PlcNameDataDict["厂内湿度"].Value}%";

                //遍历所有控件
                foreach (Control control in _controlList)
                {
                    PlcData plcData;

                    if (control is StationValue deviceValue)
                    {
                        if (Global.PlcNameDataDict.ContainsKey(deviceValue.DeviceName) && Global.PlcNameDataDict[deviceValue.DeviceName].Value != null)
                        {
                            deviceValue.Value = (float)Global.PlcNameDataDict[deviceValue.DeviceName].Value;
                        }
                    }
                    if (control is StationStatus deviceStatus)
                    {
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

                                if (IsAlarm && !_stationNameAlarmDict[stationName].Contains(alarmName))
                                {
                                    _stationNameAlarmDict[stationName].Add(alarmName);
                                }
                                if (!IsAlarm && _stationNameAlarmDict[stationName].Contains(alarmName))
                                {
                                    _stationNameAlarmDict[stationName].Remove(alarmName);
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
                                    var controlList = Global.GetChildControls(panel.Parent);
                                    // 找到 AntdUI.Panel
                                    foreach (var item in controlList)
                                    {
                                        if (item is AntdUI.Panel p && panel.Tag.ToString() == $"{stationName}监控")
                                        {
                                            p.Visible = true;
                                            p.BringToFront();
                                        }
                                    }
                                });
                            }
                        }
                    }
                }
            }
        }

        private void InitControl()
        {

        }

        private void InitValue()
        {
            _stationNameAlarmDict = new Dictionary<string, List<string>>()
            {
                { "脱脂", new List<string>() },
                { "粗洗", new List<string>() },
                { "陶化", new List<string>() },
                { "精洗", new List<string>() },
            };

            _controlList = Global.GetDescendantControls(this);
            _plcVarConfigList = MiniExcel.Query<PLCVarConfig>(AppConfig.Current.Plc.ConfigPath).ToList();

            foreach (var item in _plcVarConfigList)
            {
                Global.PlcBatchReadDict.Add(item.Address, Enum.Parse<DataTypeEnum>(item.VarType, true));
                Global.PlcNameDataDict.Add(item.Name, new PlcData() { Address = item.Address, Value = null, IsSaved = item.IsSaved });
            }
        }

        private void ViewProductionBoard_Load(object? sender, EventArgs e)
        {
            ConnectPlc();
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
                            _logger.Info($"PLC 重连结果：{(_isPlcConnected ? "成功" : "失败")}");
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
