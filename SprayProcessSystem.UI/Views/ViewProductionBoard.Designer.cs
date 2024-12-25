namespace SprayProcessSystem.UI.Views
{
    partial class ViewProductionBoard
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
            label2 = new AntdUI.Label();
            label1 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            label9 = new AntdUI.Label();
            label10 = new AntdUI.Label();
            gridPanel1 = new AntdUI.GridPanel();
            gridPanel3 = new AntdUI.GridPanel();
            panel1 = new Panel();
            labelTime1 = new AntdUI.LabelTime();
            gridPanel2 = new AntdUI.GridPanel();
            label8 = new AntdUI.Label();
            label7 = new AntdUI.Label();
            label6 = new AntdUI.Label();
            label5 = new AntdUI.Label();
            label4 = new AntdUI.Label();
            gridPanel5 = new AntdUI.GridPanel();
            gridPanel4 = new AntdUI.GridPanel();
            panel5 = new AntdUI.Panel();
            panel4 = new AntdUI.Panel();
            panel3 = new AntdUI.Panel();
            panel2 = new AntdUI.Panel();
            panel6 = new AntdUI.Panel();
            gridPanel1.SuspendLayout();
            gridPanel3.SuspendLayout();
            panel1.SuspendLayout();
            gridPanel2.SuspendLayout();
            gridPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Location = new Point(90, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 2;
            label2.Text = "系统状态：";
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(180, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(500, 46);
            label1.TabIndex = 3;
            label1.Text = "喷涂工艺数字看板";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(90, 23);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 4;
            label3.Text = "PLC 状态：";
            // 
            // label9
            // 
            label9.Location = new Point(0, 0);
            label9.Margin = new Padding(0);
            label9.Name = "label9";
            label9.Size = new Size(90, 23);
            label9.TabIndex = 5;
            label9.Text = "厂房温度：";
            // 
            // label10
            // 
            label10.Location = new Point(0, 23);
            label10.Margin = new Padding(0);
            label10.Name = "label10";
            label10.Size = new Size(90, 23);
            label10.TabIndex = 6;
            label10.Text = "厂房湿度：";
            // 
            // gridPanel1
            // 
            gridPanel1.Controls.Add(gridPanel3);
            gridPanel1.Controls.Add(label1);
            gridPanel1.Controls.Add(panel1);
            gridPanel1.Dock = DockStyle.Top;
            gridPanel1.Location = new Point(0, 0);
            gridPanel1.Margin = new Padding(2, 3, 2, 3);
            gridPanel1.Name = "gridPanel1";
            gridPanel1.Size = new Size(860, 46);
            gridPanel1.Span = "180 100% 180;\r\n";
            gridPanel1.TabIndex = 5;
            gridPanel1.Text = "gridPanel1";
            // 
            // gridPanel3
            // 
            gridPanel3.Controls.Add(label3);
            gridPanel3.Controls.Add(label10);
            gridPanel3.Controls.Add(label2);
            gridPanel3.Controls.Add(label9);
            gridPanel3.Location = new Point(680, 0);
            gridPanel3.Margin = new Padding(0);
            gridPanel3.Name = "gridPanel3";
            gridPanel3.Size = new Size(180, 46);
            gridPanel3.TabIndex = 7;
            gridPanel3.Text = "gridPanel3";
            // 
            // panel1
            // 
            panel1.Controls.Add(labelTime1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 46);
            panel1.TabIndex = 2;
            // 
            // labelTime1
            // 
            labelTime1.BackColor = Color.Transparent;
            labelTime1.Location = new Point(0, 3);
            labelTime1.Margin = new Padding(0);
            labelTime1.Name = "labelTime1";
            labelTime1.Size = new Size(170, 38);
            labelTime1.TabIndex = 1;
            labelTime1.Text = "labelTime1";
            // 
            // gridPanel2
            // 
            gridPanel2.Controls.Add(label8);
            gridPanel2.Controls.Add(label7);
            gridPanel2.Controls.Add(label6);
            gridPanel2.Controls.Add(label5);
            gridPanel2.Controls.Add(label4);
            gridPanel2.Dock = DockStyle.Top;
            gridPanel2.Location = new Point(0, 46);
            gridPanel2.Name = "gridPanel2";
            gridPanel2.Size = new Size(860, 23);
            gridPanel2.Span = "20% 20% 20% 20% 20%;\r\n";
            gridPanel2.TabIndex = 6;
            gridPanel2.Text = "gridPanel2";
            // 
            // label8
            // 
            label8.Location = new Point(691, 3);
            label8.Name = "label8";
            label8.Size = new Size(166, 17);
            label8.TabIndex = 4;
            label8.Text = "label8";
            // 
            // label7
            // 
            label7.Location = new Point(519, 3);
            label7.Name = "label7";
            label7.Size = new Size(166, 17);
            label7.TabIndex = 3;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.Location = new Point(347, 3);
            label6.Name = "label6";
            label6.Size = new Size(166, 17);
            label6.TabIndex = 2;
            label6.Text = "label6";
            // 
            // label5
            // 
            label5.Location = new Point(175, 3);
            label5.Name = "label5";
            label5.Size = new Size(166, 17);
            label5.TabIndex = 1;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(166, 17);
            label4.TabIndex = 0;
            label4.Text = "label4";
            // 
            // gridPanel5
            // 
            gridPanel5.Dock = DockStyle.Fill;
            gridPanel5.Location = new Point(0, 348);
            gridPanel5.Name = "gridPanel5";
            gridPanel5.Size = new Size(860, 318);
            gridPanel5.TabIndex = 8;
            gridPanel5.Text = "gridPanel5";
            // 
            // gridPanel4
            // 
            gridPanel4.Controls.Add(panel5);
            gridPanel4.Controls.Add(panel4);
            gridPanel4.Controls.Add(panel3);
            gridPanel4.Controls.Add(panel2);
            gridPanel4.Dock = DockStyle.Top;
            gridPanel4.Location = new Point(0, 69);
            gridPanel4.Name = "gridPanel4";
            gridPanel4.Size = new Size(860, 279);
            gridPanel4.Span = "25% 25% 25% 25%;\r\n";
            gridPanel4.TabIndex = 1;
            gridPanel4.Text = "gridPanel4";
            // 
            // panel5
            // 
            panel5.BorderColor = Color.FromArgb(217, 217, 217);
            panel5.Location = new Point(648, 3);
            panel5.Name = "panel5";
            panel5.Shadow = 4;
            panel5.ShadowOpacityAnimation = true;
            panel5.Size = new Size(209, 273);
            panel5.TabIndex = 10;
            panel5.Text = "panel5";
            // 
            // panel4
            // 
            panel4.BorderColor = Color.FromArgb(217, 217, 217);
            panel4.Location = new Point(433, 3);
            panel4.Name = "panel4";
            panel4.Shadow = 4;
            panel4.ShadowOpacityAnimation = true;
            panel4.Size = new Size(209, 273);
            panel4.TabIndex = 9;
            panel4.Text = "panel4";
            // 
            // panel3
            // 
            panel3.BorderColor = Color.FromArgb(217, 217, 217);
            panel3.Location = new Point(218, 3);
            panel3.Name = "panel3";
            panel3.Shadow = 4;
            panel3.ShadowOpacityAnimation = true;
            panel3.Size = new Size(209, 273);
            panel3.TabIndex = 8;
            panel3.Text = "panel3";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.BorderColor = Color.FromArgb(217, 217, 217);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Shadow = 4;
            panel2.ShadowOpacityAnimation = true;
            panel2.Size = new Size(209, 273);
            panel2.TabIndex = 7;
            panel2.Text = "panel2";
            // 
            // panel6
            // 
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(75, 23);
            panel6.TabIndex = 8;
            panel6.Text = "panel6";
            // 
            // ViewProductionBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            Controls.Add(panel6);
            Controls.Add(gridPanel5);
            Controls.Add(gridPanel4);
            Controls.Add(gridPanel2);
            Controls.Add(gridPanel1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "ViewProductionBoard";
            Size = new Size(860, 666);
            gridPanel1.ResumeLayout(false);
            gridPanel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            gridPanel2.ResumeLayout(false);
            gridPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.Label label3;
        private AntdUI.GridPanel gridPanel1;
        private AntdUI.LabelTime labelTime1;
        private AntdUI.Label label9;
        private AntdUI.Label label10;
        private AntdUI.GridPanel gridPanel3;
        private Panel panel1;
        private AntdUI.GridPanel gridPanel2;
        private AntdUI.Label label4;
        private AntdUI.Label label8;
        private AntdUI.Label label7;
        private AntdUI.Label label6;
        private AntdUI.Label label5;
        private AntdUI.GridPanel gridPanel5;
        private AntdUI.GridPanel gridPanel4;
        private AntdUI.Panel panel5;
        private AntdUI.Panel panel4;
        private AntdUI.Panel panel3;
        private AntdUI.Panel panel2;
        private AntdUI.Panel panel6;
    }
}
