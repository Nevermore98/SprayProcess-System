using System.ComponentModel;

namespace SprayProcessSystem.UI.UserControls
{
    public partial class StationTotalControl : UserControl
    {
        public StationTotalControl()
        {
            InitializeComponent();
        }

        private string _stationName;
        [Description("工站名称")]
        [Category("自定义属性")]
        [Browsable(true)]
        public string StationName
        {
            get { return _stationName; }
            set
            {
                _stationName = value;
                lbl_station.Text = value;
            }
        }

        [Description("是否开启")]
        [Category("自定义属性")]
        [Browsable(true)]
        private bool _isTurnOn;

        public bool IsTurnOn
        {
            get { return _isTurnOn; }
            set
            {
                _isTurnOn = value;
                sw_status.Checked = value;
            }
        }


        [Browsable(true)]
        [Category("自定义事件")]
        [Description("切换状态")]
        public event EventHandler SwitchStatusEvent;

        private void sw_status_CheckedChanged(object sender, AntdUI.BoolEventArgs e)
        {
            _isTurnOn = e.Value;
            SwitchStatusEvent?.Invoke(this, e);
        }
    }
}
