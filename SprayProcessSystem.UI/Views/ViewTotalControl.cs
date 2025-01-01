using AntdUI;
using SprayProcessSystem.UI.UserControls;
using static SprayProcessSystem.Model.Constants;

namespace SprayProcessSystem.UI.Views
{
    public partial class ViewTotalControl : UserControl
    {
        public ViewTotalControl()
        {
            InitializeComponent();
            Load += ViewTotalControl_Load;

            
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
                Generic.AppendLog($"设置 {text} 失败，未连接到 PLC！", LogLevelEnum.Error, txt_log);
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
                Generic.AppendLog($"设置 {text} 成功", LogLevelEnum.Info, txt_log);
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
                Generic.AppendLog($"设置 {text} 失败", LogLevelEnum.Error, txt_log);
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
                Generic.AppendLog($"设置 {text} 失败，未连接到 PLC！", LogLevelEnum.Error, txt_log);
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
                Generic.AppendLog($"设置 {text} 成功", LogLevelEnum.Info, txt_log);
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
                Generic.AppendLog($"设置 {text} 失败", LogLevelEnum.Error, txt_log);
            }
        }
    }
}
