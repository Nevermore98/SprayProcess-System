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
        private CancellationTokenSource _readPlcCts = new ();
        private List<PLCVarConfig> _plcVarConfigList = new();
        private Timer _readPlcTimer = new();


        public ViewProductionBoard()
        {
            InitializeComponent();
            Load += ViewProductionBoard_Load;
        
            _logger = LogManager.GetCurrentClassLogger();
            _readPlcTimer.Interval = 50;
            _readPlcTimer.Elapsed += ReadPlcTimer_Elapsed;
            _readPlcTimer.Start();

            lbl_title.Font = new Font(Global.FontCollection.Families[0], 18, FontStyle.Bold);
            InitValue();
        }

        private void ReadPlcTimer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            if (Global.SiemensClient.Connected)
            {
                //遍历所有控件
                foreach (Control control in _controlList)
                {
                    PlcData plcData;

                    if (control is DeviceValue deviceValue)
                    {
                        if (Global.PlcNameDataDict.ContainsKey(deviceValue.DeviceName) && Global.PlcNameDataDict[deviceValue.DeviceName].Value != null)
                        {
                            deviceValue.Value = (float)Global.PlcNameDataDict[deviceValue.DeviceName].Value;
                        }
                    }
                    if (control is DeviceStatus deviceStatus)
                    {
                        var statusName = deviceStatus.DeviceName + "运行状态";
                        if (Global.PlcNameDataDict.ContainsKey(statusName) && Global.PlcNameDataDict[statusName].Value != null)
                        {
                            deviceStatus.Status = (int)Global.PlcNameDataDict[statusName].Value == 1;
                        }
                    }
                    //if (control is DeviceAlarm deviceAlarm)
                    //{
                    //    deviceAlarm.State = Globals.DataDic[userAlarmState.VariableName].ToString() != "1";
                    //}
                }
            }
        }

        private void InitControl()
        {

        }

        private void InitValue()
        {
            _controlList = Global.GetAllControls(this);
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
                                lbl_plcStatus.ForeColor = Color.Green;
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
                                    lbl_plcStatus.ForeColor = Color.Red;
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
                                    lbl_plcStatus.ForeColor = Color.Green;
                                });
                            }
                            else
                            {
                                Invoke(() =>
                                {
                                    lbl_plcStatus.Text = "PLC 状态：未连接";
                                    lbl_plcStatus.ForeColor = Color.Red;
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
