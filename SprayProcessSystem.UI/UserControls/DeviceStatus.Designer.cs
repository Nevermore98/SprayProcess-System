namespace SprayProcessSystem.UI.UserControls
{
    partial class DeviceStatus
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            badge_state = new AntdUI.Badge();
            lbl_deviceName = new AntdUI.Label();
            gridPanel1 = new AntdUI.GridPanel();
            gridPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // badge_state
            // 
            badge_state.Location = new Point(100, 0);
            badge_state.Margin = new Padding(0);
            badge_state.Name = "badge_state";
            badge_state.Size = new Size(90, 30);
            badge_state.State = AntdUI.TState.Success;
            badge_state.TabIndex = 0;
            badge_state.Text = "运行中";
            // 
            // lbl_deviceName
            // 
            lbl_deviceName.Location = new Point(0, 0);
            lbl_deviceName.Margin = new Padding(0);
            lbl_deviceName.Name = "lbl_deviceName";
            lbl_deviceName.Size = new Size(100, 30);
            lbl_deviceName.TabIndex = 1;
            lbl_deviceName.Text = "脱脂喷淋泵";
            // 
            // gridPanel1
            // 
            gridPanel1.BackColor = Color.Transparent;
            gridPanel1.Controls.Add(badge_state);
            gridPanel1.Controls.Add(lbl_deviceName);
            gridPanel1.Dock = DockStyle.Fill;
            gridPanel1.Location = new Point(0, 0);
            gridPanel1.Margin = new Padding(0);
            gridPanel1.Name = "gridPanel1";
            gridPanel1.Size = new Size(190, 30);
            gridPanel1.Span = "100% 70;\r\n\r\n\r\n";
            gridPanel1.TabIndex = 3;
            gridPanel1.Text = "gridPanel1";
            // 
            // DeviceStatus
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(gridPanel1);
            Margin = new Padding(0);
            Name = "DeviceStatus";
            Size = new Size(190, 30);
            gridPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Badge badge_state;
        private AntdUI.Label lbl_deviceName;
        private AntdUI.GridPanel gridPanel1;
    }
}
