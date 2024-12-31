using System.ComponentModel;

namespace SprayProcessSystem.UI.UserControls
{
    public partial class StationAlarm : UserControl
    {
        public StationAlarm()
        {
            InitializeComponent();
        }


        private string _alarmName;

        [Description("报警名称")]
        [Category("自定义属性")]
        [Browsable(true)]
        public string AlarmName
        {
            get { return _alarmName; }
            set
            {
                _alarmName = value;
                lbl_alarmName.Text = value;
                lbl_alarmName.ForeColor = (Color)new ColorConverter().ConvertFromString("#ff4d4f");
            }
        }

        private bool _isAlarm;
        [Description("是否报警")]
        [Category("自定义属性")]
        [Browsable(true)]
        public bool IsAlarm
        {
            get { return _isAlarm; }
            set 
            {
                _isAlarm = value;
            }
        }

    }
}
