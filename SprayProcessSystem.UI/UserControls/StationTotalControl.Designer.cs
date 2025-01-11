namespace SprayProcessSystem.UI.UserControls
{
    partial class StationTotalControl
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
            lbl_station = new AntdUI.Label();
            gridPanel1 = new AntdUI.GridPanel();
            sw_status = new AntdUI.Switch();
            gridPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_station
            // 
            lbl_station.Location = new Point(3, 3);
            lbl_station.Margin = new Padding(3, 3, 0, 3);
            lbl_station.Name = "lbl_station";
            lbl_station.Size = new Size(68, 43);
            lbl_station.TabIndex = 0;
            lbl_station.Text = "工站名称";
            // 
            // gridPanel1
            // 
            gridPanel1.Controls.Add(sw_status);
            gridPanel1.Controls.Add(lbl_station);
            gridPanel1.Dock = DockStyle.Fill;
            gridPanel1.Location = new Point(0, 0);
            gridPanel1.Name = "gridPanel1";
            gridPanel1.Size = new Size(161, 49);
            gridPanel1.Span = "100% 70;";
            gridPanel1.TabIndex = 1;
            gridPanel1.Text = "gridPanel1";
            // 
            // sw_status
            // 
            sw_status.CheckedText = "开";
            sw_status.Location = new Point(71, 4);
            sw_status.Margin = new Padding(0, 4, 8, 4);
            sw_status.Name = "sw_status";
            sw_status.Size = new Size(82, 41);
            sw_status.TabIndex = 1;
            sw_status.UnCheckedText = "关";
            sw_status.CheckedChanged += sw_status_CheckedChanged;
            // 
            // StationTotalControl
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridPanel1);
            Name = "StationTotalControl";
            Size = new Size(161, 49);
            gridPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label lbl_station;
        private AntdUI.GridPanel gridPanel1;
        private AntdUI.Switch sw_status;
    }
}
