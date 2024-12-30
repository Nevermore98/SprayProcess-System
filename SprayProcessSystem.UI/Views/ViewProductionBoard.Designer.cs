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
            lbl_title = new AntdUI.Label();
            lbl_plcStatus = new AntdUI.Label();
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
            panel7 = new AntdUI.Panel();
            deviceValue16 = new UserControls.DeviceValue();
            deviceStatus11 = new UserControls.DeviceStatus();
            panel8 = new AntdUI.Panel();
            label12 = new AntdUI.Label();
            panel5 = new AntdUI.Panel();
            deviceValue2 = new UserControls.DeviceValue();
            deviceValue15 = new UserControls.DeviceValue();
            deviceStatus2 = new UserControls.DeviceStatus();
            deviceStatus10 = new UserControls.DeviceStatus();
            panel9 = new AntdUI.Panel();
            label11 = new AntdUI.Label();
            panel2 = new AntdUI.Panel();
            deviceValue14 = new UserControls.DeviceValue();
            deviceStatus9 = new UserControls.DeviceStatus();
            panel4 = new AntdUI.Panel();
            label3 = new AntdUI.Label();
            panel3 = new AntdUI.Panel();
            deviceValue11 = new UserControls.DeviceValue();
            deviceValue1 = new UserControls.DeviceValue();
            deviceStatus5 = new UserControls.DeviceStatus();
            deviceStatus1 = new UserControls.DeviceStatus();
            panel6 = new AntdUI.Panel();
            label1 = new AntdUI.Label();
            gridPanel1.SuspendLayout();
            gridPanel3.SuspendLayout();
            panel1.SuspendLayout();
            gridPanel2.SuspendLayout();
            gridPanel4.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            panel9.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Location = new Point(116, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(116, 27);
            label2.TabIndex = 2;
            label2.Text = "系统状态：";
            // 
            // lbl_title
            // 
            lbl_title.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_title.Location = new Point(231, 0);
            lbl_title.Margin = new Padding(0);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(412, 54);
            lbl_title.TabIndex = 3;
            lbl_title.Text = "喷涂工艺数字看板";
            lbl_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_plcStatus
            // 
            lbl_plcStatus.Location = new Point(116, 27);
            lbl_plcStatus.Margin = new Padding(0);
            lbl_plcStatus.Name = "lbl_plcStatus";
            lbl_plcStatus.Size = new Size(116, 27);
            lbl_plcStatus.TabIndex = 4;
            lbl_plcStatus.Text = "PLC 状态：";
            // 
            // label9
            // 
            label9.Location = new Point(0, 0);
            label9.Margin = new Padding(0);
            label9.Name = "label9";
            label9.Size = new Size(116, 27);
            label9.TabIndex = 5;
            label9.Text = "厂房温度：";
            // 
            // label10
            // 
            label10.Location = new Point(0, 27);
            label10.Margin = new Padding(0);
            label10.Name = "label10";
            label10.Size = new Size(116, 27);
            label10.TabIndex = 6;
            label10.Text = "厂房湿度：";
            // 
            // gridPanel1
            // 
            gridPanel1.Controls.Add(gridPanel3);
            gridPanel1.Controls.Add(lbl_title);
            gridPanel1.Controls.Add(panel1);
            gridPanel1.Dock = DockStyle.Top;
            gridPanel1.Location = new Point(13, 12);
            gridPanel1.Margin = new Padding(3, 4, 3, 4);
            gridPanel1.Name = "gridPanel1";
            gridPanel1.Size = new Size(874, 54);
            gridPanel1.Span = "180 100% 180;\r\n";
            gridPanel1.TabIndex = 5;
            gridPanel1.Text = "gridPanel1";
            // 
            // gridPanel3
            // 
            gridPanel3.Controls.Add(lbl_plcStatus);
            gridPanel3.Controls.Add(label10);
            gridPanel3.Controls.Add(label2);
            gridPanel3.Controls.Add(label9);
            gridPanel3.Location = new Point(643, 0);
            gridPanel3.Margin = new Padding(0);
            gridPanel3.Name = "gridPanel3";
            gridPanel3.Size = new Size(231, 54);
            gridPanel3.TabIndex = 7;
            gridPanel3.Text = "gridPanel3";
            // 
            // panel1
            // 
            panel1.Controls.Add(labelTime1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 54);
            panel1.TabIndex = 2;
            // 
            // labelTime1
            // 
            labelTime1.BackColor = Color.Transparent;
            labelTime1.Location = new Point(31, 11);
            labelTime1.Margin = new Padding(0);
            labelTime1.Name = "labelTime1";
            labelTime1.Size = new Size(140, 29);
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
            gridPanel2.Location = new Point(13, 66);
            gridPanel2.Margin = new Padding(4);
            gridPanel2.Name = "gridPanel2";
            gridPanel2.Size = new Size(874, 27);
            gridPanel2.Span = "20% 20% 20% 20% 20%;\r\n";
            gridPanel2.TabIndex = 6;
            gridPanel2.Text = "gridPanel2";
            // 
            // label8
            // 
            label8.Location = new Point(704, 4);
            label8.Margin = new Padding(4);
            label8.Name = "label8";
            label8.Size = new Size(167, 19);
            label8.TabIndex = 4;
            label8.Text = "label8";
            // 
            // label7
            // 
            label7.Location = new Point(529, 4);
            label7.Margin = new Padding(4);
            label7.Name = "label7";
            label7.Size = new Size(167, 19);
            label7.TabIndex = 3;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.Location = new Point(354, 4);
            label6.Margin = new Padding(4);
            label6.Name = "label6";
            label6.Size = new Size(167, 19);
            label6.TabIndex = 2;
            label6.Text = "label6";
            // 
            // label5
            // 
            label5.Location = new Point(179, 4);
            label5.Margin = new Padding(4);
            label5.Name = "label5";
            label5.Size = new Size(167, 19);
            label5.TabIndex = 1;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.Location = new Point(4, 4);
            label4.Margin = new Padding(4);
            label4.Name = "label4";
            label4.Size = new Size(167, 19);
            label4.TabIndex = 0;
            label4.Text = "计划产量：5000";
            // 
            // gridPanel5
            // 
            gridPanel5.Dock = DockStyle.Fill;
            gridPanel5.Location = new Point(13, 251);
            gridPanel5.Margin = new Padding(4);
            gridPanel5.Name = "gridPanel5";
            gridPanel5.Size = new Size(874, 437);
            gridPanel5.TabIndex = 8;
            gridPanel5.Text = "gridPanel5";
            // 
            // gridPanel4
            // 
            gridPanel4.Controls.Add(panel7);
            gridPanel4.Controls.Add(panel5);
            gridPanel4.Controls.Add(panel2);
            gridPanel4.Controls.Add(panel3);
            gridPanel4.Dock = DockStyle.Top;
            gridPanel4.Location = new Point(13, 93);
            gridPanel4.Margin = new Padding(4);
            gridPanel4.Name = "gridPanel4";
            gridPanel4.Size = new Size(874, 158);
            gridPanel4.Span = "25% 25% 25% 25%;\r\n";
            gridPanel4.TabIndex = 1;
            gridPanel4.Text = "gridPanel4";
            // 
            // panel7
            // 
            panel7.Back = Color.WhiteSmoke;
            panel7.BackColor = Color.White;
            panel7.BorderColor = Color.FromArgb(217, 217, 217);
            panel7.Controls.Add(deviceValue16);
            panel7.Controls.Add(deviceStatus11);
            panel7.Controls.Add(panel8);
            panel7.Location = new Point(654, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Shadow = 4;
            panel7.ShadowOpacityAnimation = true;
            panel7.Size = new Size(218, 158);
            panel7.TabIndex = 15;
            panel7.Text = "panel7";
            // 
            // deviceValue16
            // 
            deviceValue16.BackColor = Color.Transparent;
            deviceValue16.DeviceName = "精洗喷淋泵压力值";
            deviceValue16.Dock = DockStyle.Top;
            deviceValue16.Location = new Point(5, 69);
            deviceValue16.Margin = new Padding(0);
            deviceValue16.Name = "deviceValue16";
            deviceValue16.Size = new Size(208, 25);
            deviceValue16.TabIndex = 5;
            deviceValue16.Value = 0F;
            // 
            // deviceStatus11
            // 
            deviceStatus11.BackColor = Color.Transparent;
            deviceStatus11.DeviceName = "精洗洗喷淋泵";
            deviceStatus11.Dock = DockStyle.Top;
            deviceStatus11.Location = new Point(5, 44);
            deviceStatus11.Margin = new Padding(0);
            deviceStatus11.Name = "deviceStatus11";
            deviceStatus11.Size = new Size(208, 25);
            deviceStatus11.Status = false;
            deviceStatus11.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Back = Color.LightGray;
            panel8.BackColor = Color.Transparent;
            panel8.Controls.Add(label12);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(5, 5);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(208, 39);
            panel8.TabIndex = 0;
            // 
            // label12
            // 
            label12.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(8, 0);
            label12.Margin = new Padding(3, 4, 3, 4);
            label12.Name = "label12";
            label12.Size = new Size(96, 39);
            label12.TabIndex = 0;
            label12.Text = "精洗";
            // 
            // panel5
            // 
            panel5.Back = Color.WhiteSmoke;
            panel5.BackColor = Color.White;
            panel5.BorderColor = Color.FromArgb(217, 217, 217);
            panel5.Controls.Add(deviceValue2);
            panel5.Controls.Add(deviceValue15);
            panel5.Controls.Add(deviceStatus2);
            panel5.Controls.Add(deviceStatus10);
            panel5.Controls.Add(panel9);
            panel5.Location = new Point(436, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Shadow = 4;
            panel5.ShadowOpacityAnimation = true;
            panel5.Size = new Size(218, 158);
            panel5.TabIndex = 14;
            panel5.Text = "panel5";
            // 
            // deviceValue2
            // 
            deviceValue2.BackColor = Color.Transparent;
            deviceValue2.DeviceName = "陶化PH值";
            deviceValue2.Dock = DockStyle.Top;
            deviceValue2.Location = new Point(5, 119);
            deviceValue2.Margin = new Padding(0);
            deviceValue2.Name = "deviceValue2";
            deviceValue2.Size = new Size(208, 25);
            deviceValue2.TabIndex = 7;
            deviceValue2.Value = 0F;
            // 
            // deviceValue15
            // 
            deviceValue15.BackColor = Color.Transparent;
            deviceValue15.DeviceName = "陶化喷淋泵压力值";
            deviceValue15.Dock = DockStyle.Top;
            deviceValue15.Location = new Point(5, 94);
            deviceValue15.Margin = new Padding(0);
            deviceValue15.Name = "deviceValue15";
            deviceValue15.Size = new Size(208, 25);
            deviceValue15.TabIndex = 5;
            deviceValue15.Value = 0F;
            // 
            // deviceStatus2
            // 
            deviceStatus2.BackColor = Color.Transparent;
            deviceStatus2.DeviceName = "陶化排风机";
            deviceStatus2.Dock = DockStyle.Top;
            deviceStatus2.Location = new Point(5, 69);
            deviceStatus2.Margin = new Padding(0);
            deviceStatus2.Name = "deviceStatus2";
            deviceStatus2.Size = new Size(208, 25);
            deviceStatus2.Status = false;
            deviceStatus2.TabIndex = 6;
            // 
            // deviceStatus10
            // 
            deviceStatus10.BackColor = Color.Transparent;
            deviceStatus10.DeviceName = "陶化喷淋泵";
            deviceStatus10.Dock = DockStyle.Top;
            deviceStatus10.Location = new Point(5, 44);
            deviceStatus10.Margin = new Padding(0);
            deviceStatus10.Name = "deviceStatus10";
            deviceStatus10.Size = new Size(208, 25);
            deviceStatus10.Status = false;
            deviceStatus10.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.Back = Color.LightGray;
            panel9.BackColor = Color.Transparent;
            panel9.Controls.Add(label11);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(5, 5);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Size = new Size(208, 39);
            panel9.TabIndex = 0;
            // 
            // label11
            // 
            label11.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(8, 0);
            label11.Margin = new Padding(3, 4, 3, 4);
            label11.Name = "label11";
            label11.Size = new Size(96, 39);
            label11.TabIndex = 0;
            label11.Text = "陶化";
            // 
            // panel2
            // 
            panel2.Back = Color.WhiteSmoke;
            panel2.BackColor = Color.White;
            panel2.BorderColor = Color.FromArgb(217, 217, 217);
            panel2.Controls.Add(deviceValue14);
            panel2.Controls.Add(deviceStatus9);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(218, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Shadow = 4;
            panel2.ShadowOpacityAnimation = true;
            panel2.Size = new Size(218, 158);
            panel2.TabIndex = 13;
            panel2.Text = "panel2";
            // 
            // deviceValue14
            // 
            deviceValue14.BackColor = Color.Transparent;
            deviceValue14.DeviceName = "粗洗喷淋泵压力值";
            deviceValue14.Dock = DockStyle.Top;
            deviceValue14.Location = new Point(5, 69);
            deviceValue14.Margin = new Padding(0);
            deviceValue14.Name = "deviceValue14";
            deviceValue14.Size = new Size(208, 25);
            deviceValue14.TabIndex = 5;
            deviceValue14.Value = 0F;
            // 
            // deviceStatus9
            // 
            deviceStatus9.BackColor = Color.Transparent;
            deviceStatus9.DeviceName = "粗洗喷淋泵";
            deviceStatus9.Dock = DockStyle.Top;
            deviceStatus9.Location = new Point(5, 44);
            deviceStatus9.Margin = new Padding(0);
            deviceStatus9.Name = "deviceStatus9";
            deviceStatus9.Size = new Size(208, 25);
            deviceStatus9.Status = false;
            deviceStatus9.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Back = Color.LightGray;
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(5, 5);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(208, 39);
            panel4.TabIndex = 0;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(8, 0);
            label3.Margin = new Padding(3, 4, 3, 4);
            label3.Name = "label3";
            label3.Size = new Size(96, 39);
            label3.TabIndex = 0;
            label3.Text = "粗洗";
            // 
            // panel3
            // 
            panel3.Back = Color.WhiteSmoke;
            panel3.BackColor = Color.White;
            panel3.BorderColor = Color.FromArgb(217, 217, 217);
            panel3.Controls.Add(deviceValue11);
            panel3.Controls.Add(deviceValue1);
            panel3.Controls.Add(deviceStatus5);
            panel3.Controls.Add(deviceStatus1);
            panel3.Controls.Add(panel6);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Shadow = 4;
            panel3.ShadowOpacityAnimation = true;
            panel3.Size = new Size(218, 158);
            panel3.TabIndex = 8;
            panel3.Text = "panel3";
            // 
            // deviceValue11
            // 
            deviceValue11.BackColor = Color.Transparent;
            deviceValue11.DeviceName = "脱脂PH值";
            deviceValue11.Dock = DockStyle.Top;
            deviceValue11.Location = new Point(5, 119);
            deviceValue11.Margin = new Padding(0);
            deviceValue11.Name = "deviceValue11";
            deviceValue11.Size = new Size(208, 25);
            deviceValue11.TabIndex = 4;
            deviceValue11.Value = 0F;
            // 
            // deviceValue1
            // 
            deviceValue1.BackColor = Color.Transparent;
            deviceValue1.DeviceName = "脱脂喷淋泵压力值";
            deviceValue1.Dock = DockStyle.Top;
            deviceValue1.Location = new Point(5, 94);
            deviceValue1.Margin = new Padding(0);
            deviceValue1.Name = "deviceValue1";
            deviceValue1.Size = new Size(208, 25);
            deviceValue1.TabIndex = 3;
            deviceValue1.Value = 0F;
            // 
            // deviceStatus5
            // 
            deviceStatus5.BackColor = Color.Transparent;
            deviceStatus5.DeviceName = "脱脂排风机";
            deviceStatus5.Dock = DockStyle.Top;
            deviceStatus5.Location = new Point(5, 69);
            deviceStatus5.Margin = new Padding(0);
            deviceStatus5.Name = "deviceStatus5";
            deviceStatus5.Size = new Size(208, 25);
            deviceStatus5.Status = false;
            deviceStatus5.TabIndex = 2;
            // 
            // deviceStatus1
            // 
            deviceStatus1.BackColor = Color.Transparent;
            deviceStatus1.DeviceName = "脱脂喷淋泵";
            deviceStatus1.Dock = DockStyle.Top;
            deviceStatus1.Location = new Point(5, 44);
            deviceStatus1.Margin = new Padding(0);
            deviceStatus1.Name = "deviceStatus1";
            deviceStatus1.Size = new Size(208, 25);
            deviceStatus1.Status = false;
            deviceStatus1.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Back = Color.LightGray;
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(label1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(5, 5);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(208, 39);
            panel6.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 0);
            label1.Margin = new Padding(3, 4, 3, 4);
            label1.Name = "label1";
            label1.Size = new Size(96, 39);
            label1.TabIndex = 0;
            label1.Text = "脱脂";
            // 
            // ViewProductionBoard
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(gridPanel5);
            Controls.Add(gridPanel4);
            Controls.Add(gridPanel2);
            Controls.Add(gridPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewProductionBoard";
            Padding = new Padding(13, 12, 13, 12);
            Size = new Size(900, 700);
            gridPanel1.ResumeLayout(false);
            gridPanel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            gridPanel2.ResumeLayout(false);
            gridPanel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label2;
        private AntdUI.Label lbl_title;
        private AntdUI.Label lbl_plcStatus;
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
        private UserControls.RunningStatus runningStatus2;
        private UserControls.DeviceValue deviceValue5;
        private UserControls.DeviceValue deviceValue6;
        private UserControls.RunningStatus runningStatus5;
        private UserControls.RunningStatus runningStatus6;
        private UserControls.DeviceValue deviceValue3;
        private UserControls.DeviceValue deviceValue4;
        private UserControls.RunningStatus runningStatus1;
        private UserControls.RunningStatus runningStatus4;
        private UserControls.RunningStatus runningStatus7;
        private UserControls.DeviceValue deviceValue7;
        private UserControls.DeviceStatus deviceStatus2;
        private UserControls.DeviceStatus deviceStatus3;
        private UserControls.DeviceStatus deviceStatus4;
        private UserControls.DeviceValue deviceValue8;
        private UserControls.DeviceValue deviceValue9;
        private AntdUI.Panel panel5;
        private UserControls.DeviceValue deviceValue12;
        private UserControls.DeviceValue deviceValue13;
        private UserControls.DeviceStatus deviceStatus7;
        private UserControls.DeviceStatus deviceStatus8;
        private AntdUI.Panel panel9;
        private AntdUI.Label label11;
        private AntdUI.Panel panel2;
        private UserControls.DeviceValue deviceValue10;
        private UserControls.DeviceStatus deviceStatus6;
        private AntdUI.Panel panel4;
        private AntdUI.Label label3;
        private AntdUI.Panel panel7;
        private AntdUI.Panel panel8;
        private AntdUI.Label label12;
        private UserControls.DeviceAlarm deviceAlarm1;
        private AntdUI.Panel panel3;
        private AntdUI.Panel panel6;
        private AntdUI.Label label1;
        private UserControls.DeviceStatus deviceStatus1;
        private UserControls.DeviceValue deviceValue16;
        private UserControls.DeviceStatus deviceStatus11;
        private UserControls.DeviceValue deviceValue15;
        private UserControls.DeviceStatus deviceStatus10;
        private UserControls.DeviceValue deviceValue14;
        private UserControls.DeviceStatus deviceStatus9;
        private UserControls.DeviceValue deviceValue11;
        private UserControls.DeviceValue deviceValue1;
        private UserControls.DeviceStatus deviceStatus5;
        private UserControls.DeviceValue deviceValue2;
    }
}
