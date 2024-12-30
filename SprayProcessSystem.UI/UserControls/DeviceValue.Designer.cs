namespace SprayProcessSystem.UI.UserControls
{
    partial class DeviceValue
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
            gridPanel1 = new AntdUI.GridPanel();
            lbl_Value = new AntdUI.Label();
            lbl_deviceName = new AntdUI.Label();
            gridPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // gridPanel1
            // 
            gridPanel1.Controls.Add(lbl_Value);
            gridPanel1.Controls.Add(lbl_deviceName);
            gridPanel1.Dock = DockStyle.Fill;
            gridPanel1.Location = new Point(0, 0);
            gridPanel1.Margin = new Padding(0);
            gridPanel1.Name = "gridPanel1";
            gridPanel1.Size = new Size(190, 35);
            gridPanel1.Span = "100% 65;\r\n";
            gridPanel1.TabIndex = 0;
            gridPanel1.Text = "gridPanel1";
            // 
            // lbl_Value
            // 
            lbl_Value.Location = new Point(107, 0);
            lbl_Value.Margin = new Padding(0);
            lbl_Value.Name = "lbl_Value";
            lbl_Value.Size = new Size(83, 35);
            lbl_Value.TabIndex = 1;
            lbl_Value.Text = "123";
            // 
            // lbl_deviceName
            // 
            lbl_deviceName.Location = new Point(0, 0);
            lbl_deviceName.Margin = new Padding(0);
            lbl_deviceName.Name = "lbl_deviceName";
            lbl_deviceName.Size = new Size(107, 35);
            lbl_deviceName.TabIndex = 0;
            lbl_deviceName.Text = "设备名称";
            // 
            // DeviceValue
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(gridPanel1);
            Margin = new Padding(0);
            Name = "DeviceValue";
            Size = new Size(190, 35);
            gridPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.GridPanel gridPanel1;
        private AntdUI.Label lbl_deviceName;
        private AntdUI.Label lbl_Value;
    }
}
