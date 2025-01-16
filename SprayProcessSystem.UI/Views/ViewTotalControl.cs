using AntdUI;
using Microsoft.Extensions.DependencyInjection;
using NLog;
using SprayProcessSystem.Helper;
using SprayProcessSystem.UI.UserControls;
using System.Windows.Forms;
using static SprayProcessSystem.Model.Constants;

namespace SprayProcessSystem.UI.Views
{
    public partial class ViewTotalControl : UserControl
    {
        private readonly Logger _logger;
        private readonly MainForm _mainForm;

        public ViewTotalControl()
        {
            InitializeComponent();
            _logger = LogManager.GetCurrentClassLogger();
            _mainForm = Program.ServiceProvider.GetRequiredService<MainForm>();
            Generic.AppendLog = AppendLog;

            Load += ViewTotalControl_Load;
        }

        private void AppendLog(string message, LogLevelEnum logLevelEnum, bool isWriteToFile)
        {
            txt_log.AppendText($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} --- [{EnumHelper.GetEnumDescription(logLevelEnum)}] --- {message}\r\n");
            if (!isWriteToFile) return;
            switch (logLevelEnum)
            {
                case LogLevelEnum.Info:
                    _logger.Info(message);
                    Generic.ShowMessage(_mainForm, message, TType.Success, false);
                    break;
                case LogLevelEnum.Warn:
                    _logger.Warn(message);
                    Generic.ShowMessage(_mainForm, message, TType.Warn, false);
                    break;
                case LogLevelEnum.Error:
                    _logger.Error(message);
                    Generic.ShowMessage(_mainForm, message, TType.Error, false);
                    break;
                case LogLevelEnum.Debug:
                    _logger.Debug(message);
                    Generic.ShowMessage(_mainForm, message, TType.None, false);
                    break;
                default:
                    _logger.Info(message);
                    break;
            }
        }

        private void ViewTotalControl_Load(object? sender, EventArgs e)
        {
        }

        private void buttonControl_Click(object sender, EventArgs e)
        {
            var btn = sender as AntdUI.Button;
            var text = btn.Text;

            if (!Global.SiemensClient.Connected)
            {
                AntdUI.Message.open(new AntdUI.Message.Config(this.ParentForm, "未连接到 PLC！", TType.Error)
                {
                    AutoClose = 3,
                    Align = TAlignFrom.Top,
                    Font = new Font(Global.FontCollection.Families[0], 13),
                    ShowInWindow = true
                });
                Generic.AppendLog($"设置 {text} 失败，未连接到 PLC！", LogLevelEnum.Error, true);
                return;
            }

            bool result;
            if (text == "空运行")
            {
                btn.Toggle = !btn.Toggle;
                result = Generic.PlcWrite(text, btn.Toggle);
            }
            else
            {
                result = Generic.PlcWrite(text, true);
            }

            if (result)
            {
                AntdUI.Message.open(new AntdUI.Message.Config(this.ParentForm, $"设置 {text} 成功！", TType.Success)
                {
                    AutoClose = 3,
                    Align = TAlignFrom.Top,
                    Font = new Font(Global.FontCollection.Families[0], 13),
                    ShowInWindow = true
                });
                Generic.AppendLog($"设置 {text} 成功", LogLevelEnum.Info, true);
            }
            else
            {
                AntdUI.Message.open(new AntdUI.Message.Config(this.ParentForm, $"设置 {text} 失败！", TType.Error)
                {
                    AutoClose = 3,
                    Align = TAlignFrom.Top,
                    Font = new Font(Global.FontCollection.Families[0], 13),
                    ShowInWindow = true
                });
                Generic.AppendLog($"设置 {text} 失败", LogLevelEnum.Error, true);
            }
        }

        private void stationTotalControl_SwitchStatusEvent(object sender, EventArgs e)
        {
            var stationTotalControl = sender as StationTotalControl;
            var stationName = stationTotalControl.StationName;
            var isTurnOn = stationTotalControl.IsTurnOn;
            var text = $"{stationName}{(isTurnOn ? "开" : "关")}";

            if (!Global.SiemensClient.Connected)
            {
                AntdUI.Message.open(new AntdUI.Message.Config(this.ParentForm, "未连接到 PLC！", TType.Error)
                {
                    AutoClose = 3,
                    Align = TAlignFrom.Top,
                    Font = new Font(Global.FontCollection.Families[0], 13),
                    ShowInWindow = true
                });
                stationTotalControl.IsTurnOn = false;
                Generic.AppendLog($"设置 {text} 失败，未连接到 PLC！", LogLevelEnum.Error, true);
                return;
            }


            bool result = Generic.PlcWrite(text, true);
            if (result)
            {
                AntdUI.Message.open(new AntdUI.Message.Config(this.ParentForm, $"设置 {text} 成功！", TType.Success)
                {
                    AutoClose = 3,
                    Align = TAlignFrom.Top,
                    Font = new Font(Global.FontCollection.Families[0], 13),
                    ShowInWindow = true
                });
                Generic.AppendLog($"设置 {text} 成功", LogLevelEnum.Info, true);
            }
            else
            {
                AntdUI.Message.open(new AntdUI.Message.Config(this.ParentForm, $"设置 {text} 失败！", TType.Error)
                {
                    AutoClose = 3,
                    Align = TAlignFrom.Top,
                    Font = new Font(Global.FontCollection.Families[0], 13),
                    ShowInWindow = true
                });
                Generic.AppendLog($"设置 {text} 失败", LogLevelEnum.Error, true);
            }
        }
    }
}
