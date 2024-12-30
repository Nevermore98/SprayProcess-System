using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SprayProcessSystem.UI.UserControls
{
    public partial class DeviceValue : UserControl
    {
        public DeviceValue()
        {
            InitializeComponent(); 
        }

        private float _value = 0;

        [Description("设备值")]
        [Category("自定义属性")]
        [Browsable(true)]
        public float Value
        {
            get { return _value; }
            set
            {
                _value = value;
                lbl_Value.Text = value.ToString();
            }
        }

        private string _deviceName = "设备名称";

        [Description("设备名称")]
        [Category("自定义属性")]
        [Browsable(true)]
        public string DeviceName
        {
            get { return _deviceName; }
            set
            {
                _deviceName = value;
                lbl_deviceName.Text = value;
            }
        }
    }
}
