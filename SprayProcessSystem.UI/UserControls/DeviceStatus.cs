﻿using System.ComponentModel;

namespace SprayProcessSystem.UI.UserControls
{
    public partial class DeviceStatus : UserControl
    {
        public DeviceStatus()
        {
            InitializeComponent();
        }

        private string _deviceName = "设备名称";

        [Description("设置或获取设备运行状态名称")]
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

        // 设备状态属性
        private bool _status = false;

        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或获取设备运行状态")]
        public bool Status
        {
            get { return _status; }
            set
            {
                _status = value;
                if (_status)
                {
                    badge_state.State = AntdUI.TState.Success;
                    badge_state.Text = "运行中";
                }
                else
                {
                    badge_state.State = AntdUI.TState.Error;
                    badge_state.Text = "已停止";
                }
            }
        }
    }
}
