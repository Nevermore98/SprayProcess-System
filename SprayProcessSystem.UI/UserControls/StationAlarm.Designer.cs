namespace SprayProcessSystem.UI.UserControls
{
    partial class StationAlarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StationAlarm));
            gridPanel1 = new AntdUI.GridPanel();
            lbl_alarmName = new AntdUI.Label();
            avatar1 = new AntdUI.Avatar();
            gridPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // gridPanel1
            // 
            gridPanel1.BackColor = Color.Transparent;
            gridPanel1.Controls.Add(lbl_alarmName);
            gridPanel1.Controls.Add(avatar1);
            gridPanel1.Dock = DockStyle.Fill;
            gridPanel1.Location = new Point(0, 0);
            gridPanel1.Margin = new Padding(0);
            gridPanel1.Name = "gridPanel1";
            gridPanel1.Size = new Size(190, 35);
            gridPanel1.Span = "40 100%;\r\n\r\n\r\n";
            gridPanel1.TabIndex = 4;
            gridPanel1.Text = "gridPanel1";
            // 
            // lbl_alarmName
            // 
            lbl_alarmName.Location = new Point(51, 0);
            lbl_alarmName.Margin = new Padding(0);
            lbl_alarmName.Name = "lbl_alarmName";
            lbl_alarmName.Padding = new Padding(0, 3, 0, 0);
            lbl_alarmName.Size = new Size(139, 35);
            lbl_alarmName.TabIndex = 1;
            lbl_alarmName.Text = "报警名称";
            // 
            // avatar1
            // 
            avatar1.ImageSvg = resources.GetString("avatar1.ImageSvg");
            avatar1.Location = new Point(3, 3);
            avatar1.Name = "avatar1";
            avatar1.Size = new Size(45, 29);
            avatar1.TabIndex = 2;
            avatar1.Text = "";
            // 
            // StationAlarm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(gridPanel1);
            Name = "StationAlarm";
            Size = new Size(190, 35);
            gridPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.GridPanel gridPanel1;
        private AntdUI.Label lbl_alarmName;
        private AntdUI.Avatar avatar1;
    }
}
