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
            lbl_sysStatus = new AntdUI.Label();
            lbl_title = new AntdUI.Label();
            lbl_plcStatus = new AntdUI.Label();
            lbl_temperature = new AntdUI.Label();
            lbl_humidity = new AntdUI.Label();
            gridPanel1 = new AntdUI.GridPanel();
            gridPanel_TitleInfo = new AntdUI.GridPanel();
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
            panel12 = new AntdUI.Panel();
            panel15 = new AntdUI.Panel();
            deviceValue16 = new UserControls.StationValue();
            deviceStatus12 = new UserControls.StationStatus();
            panel16 = new AntdUI.Panel();
            deviceAlarm7 = new UserControls.StationAlarm();
            deviceAlarm8 = new UserControls.StationAlarm();
            panel17 = new AntdUI.Panel();
            label12 = new AntdUI.Label();
            panel5 = new AntdUI.Panel();
            panel9 = new AntdUI.Panel();
            deviceValue2 = new UserControls.StationValue();
            deviceValue15 = new UserControls.StationValue();
            deviceStatus10 = new UserControls.StationStatus();
            deviceStatus2 = new UserControls.StationStatus();
            panel13 = new AntdUI.Panel();
            deviceAlarm4 = new UserControls.StationAlarm();
            deviceAlarm1 = new UserControls.StationAlarm();
            panel14 = new AntdUI.Panel();
            label11 = new AntdUI.Label();
            panel2 = new AntdUI.Panel();
            panel10 = new AntdUI.Panel();
            deviceValue14 = new UserControls.StationValue();
            deviceStatus9 = new UserControls.StationStatus();
            panel11 = new AntdUI.Panel();
            deviceAlarm3 = new UserControls.StationAlarm();
            deviceAlarm2 = new UserControls.StationAlarm();
            panel4 = new AntdUI.Panel();
            label3 = new AntdUI.Label();
            panel3 = new AntdUI.Panel();
            panel6 = new AntdUI.Panel();
            deviceValue1 = new UserControls.StationValue();
            deviceValue11 = new UserControls.StationValue();
            deviceStatus1 = new UserControls.StationStatus();
            deviceStatus5 = new UserControls.StationStatus();
            panel7 = new AntdUI.Panel();
            deviceAlarm5 = new UserControls.StationAlarm();
            panel8 = new AntdUI.Panel();
            label1 = new AntdUI.Label();
            gridPanel1.SuspendLayout();
            gridPanel_TitleInfo.SuspendLayout();
            panel1.SuspendLayout();
            gridPanel2.SuspendLayout();
            gridPanel4.SuspendLayout();
            panel12.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            panel5.SuspendLayout();
            panel9.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel2.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_sysStatus
            // 
            lbl_sysStatus.Location = new Point(141, 0);
            lbl_sysStatus.Margin = new Padding(0);
            lbl_sysStatus.Name = "lbl_sysStatus";
            lbl_sysStatus.Size = new Size(141, 23);
            lbl_sysStatus.TabIndex = 2;
            lbl_sysStatus.Text = "系统状态：";
            // 
            // lbl_title
            // 
            lbl_title.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_title.Location = new Point(282, 0);
            lbl_title.Margin = new Padding(0);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(336, 46);
            lbl_title.TabIndex = 3;
            lbl_title.Text = "喷涂工艺数字看板";
            lbl_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_plcStatus
            // 
            lbl_plcStatus.Location = new Point(141, 23);
            lbl_plcStatus.Margin = new Padding(0);
            lbl_plcStatus.Name = "lbl_plcStatus";
            lbl_plcStatus.Size = new Size(141, 23);
            lbl_plcStatus.TabIndex = 4;
            lbl_plcStatus.Text = "PLC状态：";
            // 
            // lbl_temperature
            // 
            lbl_temperature.Location = new Point(0, 0);
            lbl_temperature.Margin = new Padding(0);
            lbl_temperature.Name = "lbl_temperature";
            lbl_temperature.Size = new Size(141, 23);
            lbl_temperature.TabIndex = 5;
            lbl_temperature.Text = "厂房温度：26.5℃";
            // 
            // lbl_humidity
            // 
            lbl_humidity.Location = new Point(0, 23);
            lbl_humidity.Margin = new Padding(0);
            lbl_humidity.Name = "lbl_humidity";
            lbl_humidity.Size = new Size(141, 23);
            lbl_humidity.TabIndex = 6;
            lbl_humidity.Text = "厂房湿度：50%";
            // 
            // gridPanel1
            // 
            gridPanel1.Controls.Add(gridPanel_TitleInfo);
            gridPanel1.Controls.Add(lbl_title);
            gridPanel1.Controls.Add(panel1);
            gridPanel1.Dock = DockStyle.Top;
            gridPanel1.Location = new Point(0, 0);
            gridPanel1.Margin = new Padding(3, 4, 3, 4);
            gridPanel1.Name = "gridPanel1";
            gridPanel1.Size = new Size(900, 46);
            gridPanel1.Span = "220 100% 220;\r\n";
            gridPanel1.TabIndex = 5;
            gridPanel1.Text = "gridPanel1";
            // 
            // gridPanel_TitleInfo
            // 
            gridPanel_TitleInfo.Controls.Add(lbl_plcStatus);
            gridPanel_TitleInfo.Controls.Add(lbl_humidity);
            gridPanel_TitleInfo.Controls.Add(lbl_sysStatus);
            gridPanel_TitleInfo.Controls.Add(lbl_temperature);
            gridPanel_TitleInfo.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            gridPanel_TitleInfo.Location = new Point(618, 0);
            gridPanel_TitleInfo.Margin = new Padding(0);
            gridPanel_TitleInfo.Name = "gridPanel_TitleInfo";
            gridPanel_TitleInfo.Size = new Size(282, 46);
            gridPanel_TitleInfo.Span = "50% 50%;50% 50%\r\n\r\n";
            gridPanel_TitleInfo.TabIndex = 7;
            gridPanel_TitleInfo.Text = "gridPanel3";
            // 
            // panel1
            // 
            panel1.Controls.Add(labelTime1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 46);
            panel1.TabIndex = 2;
            // 
            // labelTime1
            // 
            labelTime1.BackColor = Color.Transparent;
            labelTime1.Location = new Point(26, 6);
            labelTime1.Margin = new Padding(0);
            labelTime1.Name = "labelTime1";
            labelTime1.Size = new Size(216, 32);
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
            gridPanel2.Margin = new Padding(4);
            gridPanel2.Name = "gridPanel2";
            gridPanel2.Size = new Size(900, 27);
            gridPanel2.Span = "20% 20% 20% 20% 20%;\r\n";
            gridPanel2.TabIndex = 6;
            gridPanel2.Text = "gridPanel2";
            // 
            // label8
            // 
            label8.Location = new Point(724, 4);
            label8.Margin = new Padding(4);
            label8.Name = "label8";
            label8.Size = new Size(172, 19);
            label8.TabIndex = 4;
            label8.Text = "label8";
            // 
            // label7
            // 
            label7.Location = new Point(544, 4);
            label7.Margin = new Padding(4);
            label7.Name = "label7";
            label7.Size = new Size(172, 19);
            label7.TabIndex = 3;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.Location = new Point(364, 4);
            label6.Margin = new Padding(4);
            label6.Name = "label6";
            label6.Size = new Size(172, 19);
            label6.TabIndex = 2;
            label6.Text = "label6";
            // 
            // label5
            // 
            label5.Location = new Point(184, 4);
            label5.Margin = new Padding(4);
            label5.Name = "label5";
            label5.Size = new Size(172, 19);
            label5.TabIndex = 1;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.Location = new Point(4, 4);
            label4.Margin = new Padding(4);
            label4.Name = "label4";
            label4.Size = new Size(172, 19);
            label4.TabIndex = 0;
            label4.Text = "计划产量：5000";
            // 
            // gridPanel5
            // 
            gridPanel5.Dock = DockStyle.Fill;
            gridPanel5.Location = new Point(0, 231);
            gridPanel5.Margin = new Padding(4);
            gridPanel5.Name = "gridPanel5";
            gridPanel5.Size = new Size(900, 469);
            gridPanel5.TabIndex = 8;
            gridPanel5.Text = "gridPanel5";
            // 
            // gridPanel4
            // 
            gridPanel4.Controls.Add(panel12);
            gridPanel4.Controls.Add(panel5);
            gridPanel4.Controls.Add(panel2);
            gridPanel4.Controls.Add(panel3);
            gridPanel4.Dock = DockStyle.Top;
            gridPanel4.Location = new Point(0, 73);
            gridPanel4.Margin = new Padding(4);
            gridPanel4.Name = "gridPanel4";
            gridPanel4.Size = new Size(900, 158);
            gridPanel4.Span = "25% 25% 25% 25%;\r\n";
            gridPanel4.TabIndex = 1;
            gridPanel4.Text = "gridPanel4";
            // 
            // panel12
            // 
            panel12.Back = Color.WhiteSmoke;
            panel12.BackColor = Color.White;
            panel12.BorderColor = Color.FromArgb(217, 217, 217);
            panel12.Controls.Add(panel15);
            panel12.Controls.Add(panel16);
            panel12.Controls.Add(panel17);
            panel12.Location = new Point(675, 0);
            panel12.Margin = new Padding(0);
            panel12.Name = "panel12";
            panel12.Shadow = 4;
            panel12.ShadowOpacityAnimation = true;
            panel12.Size = new Size(225, 158);
            panel12.TabIndex = 18;
            panel12.Text = "panel12";
            // 
            // panel15
            // 
            panel15.Back = Color.Transparent;
            panel15.BackColor = SystemColors.Control;
            panel15.Controls.Add(deviceValue16);
            panel15.Controls.Add(deviceStatus12);
            panel15.Dock = DockStyle.Fill;
            panel15.Location = new Point(5, 44);
            panel15.Name = "panel15";
            panel15.Size = new Size(215, 109);
            panel15.TabIndex = 9;
            panel15.Tag = "精洗监控";
            panel15.Text = "panel15";
            // 
            // deviceValue16
            // 
            deviceValue16.BackColor = Color.Transparent;
            deviceValue16.DeviceName = "精洗喷淋泵压力值";
            deviceValue16.Dock = DockStyle.Top;
            deviceValue16.Location = new Point(0, 25);
            deviceValue16.Margin = new Padding(0);
            deviceValue16.Name = "deviceValue16";
            deviceValue16.Size = new Size(215, 25);
            deviceValue16.TabIndex = 5;
            deviceValue16.Value = 0F;
            // 
            // deviceStatus12
            // 
            deviceStatus12.BackColor = Color.Transparent;
            deviceStatus12.DeviceName = "精洗喷淋泵";
            deviceStatus12.Dock = DockStyle.Top;
            deviceStatus12.Location = new Point(0, 0);
            deviceStatus12.Margin = new Padding(0);
            deviceStatus12.Name = "deviceStatus12";
            deviceStatus12.Size = new Size(215, 25);
            deviceStatus12.Status = false;
            deviceStatus12.TabIndex = 2;
            // 
            // panel16
            // 
            panel16.Back = Color.Transparent;
            panel16.BackColor = SystemColors.Control;
            panel16.Controls.Add(deviceAlarm7);
            panel16.Controls.Add(deviceAlarm8);
            panel16.Dock = DockStyle.Fill;
            panel16.Location = new Point(5, 44);
            panel16.Name = "panel16";
            panel16.Size = new Size(215, 109);
            panel16.TabIndex = 8;
            panel16.Tag = "精洗报警";
            panel16.Text = "panel16";
            // 
            // deviceAlarm7
            // 
            deviceAlarm7.AlarmName = "精洗低液位";
            deviceAlarm7.BackColor = Color.Transparent;
            deviceAlarm7.Dock = DockStyle.Top;
            deviceAlarm7.IsAlarm = false;
            deviceAlarm7.Location = new Point(0, 25);
            deviceAlarm7.Name = "deviceAlarm7";
            deviceAlarm7.Size = new Size(215, 25);
            deviceAlarm7.TabIndex = 6;
            deviceAlarm7.Visible = false;
            // 
            // deviceAlarm8
            // 
            deviceAlarm8.AlarmName = "精洗喷淋泵过载";
            deviceAlarm8.BackColor = Color.Transparent;
            deviceAlarm8.Dock = DockStyle.Top;
            deviceAlarm8.IsAlarm = false;
            deviceAlarm8.Location = new Point(0, 0);
            deviceAlarm8.Name = "deviceAlarm8";
            deviceAlarm8.Size = new Size(215, 25);
            deviceAlarm8.TabIndex = 7;
            deviceAlarm8.Visible = false;
            // 
            // panel17
            // 
            panel17.Back = Color.LightGray;
            panel17.BackColor = Color.Transparent;
            panel17.Controls.Add(label12);
            panel17.Dock = DockStyle.Top;
            panel17.Location = new Point(5, 5);
            panel17.Margin = new Padding(0);
            panel17.Name = "panel17";
            panel17.Size = new Size(215, 39);
            panel17.TabIndex = 0;
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
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel13);
            panel5.Controls.Add(panel14);
            panel5.Location = new Point(450, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Shadow = 4;
            panel5.ShadowOpacityAnimation = true;
            panel5.Size = new Size(225, 158);
            panel5.TabIndex = 16;
            panel5.Text = "panel5";
            // 
            // panel9
            // 
            panel9.Back = Color.Transparent;
            panel9.BackColor = SystemColors.Control;
            panel9.Controls.Add(deviceValue2);
            panel9.Controls.Add(deviceValue15);
            panel9.Controls.Add(deviceStatus10);
            panel9.Controls.Add(deviceStatus2);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(5, 44);
            panel9.Name = "panel9";
            panel9.Size = new Size(215, 109);
            panel9.TabIndex = 9;
            panel9.Tag = "陶化监控";
            panel9.Text = "panel9";
            // 
            // deviceValue2
            // 
            deviceValue2.BackColor = Color.Transparent;
            deviceValue2.DeviceName = "陶化pH值";
            deviceValue2.Dock = DockStyle.Top;
            deviceValue2.Location = new Point(0, 75);
            deviceValue2.Margin = new Padding(0);
            deviceValue2.Name = "deviceValue2";
            deviceValue2.Size = new Size(215, 25);
            deviceValue2.TabIndex = 5;
            deviceValue2.Value = 0F;
            // 
            // deviceValue15
            // 
            deviceValue15.BackColor = Color.Transparent;
            deviceValue15.DeviceName = "陶化喷淋泵压力值";
            deviceValue15.Dock = DockStyle.Top;
            deviceValue15.Location = new Point(0, 50);
            deviceValue15.Margin = new Padding(0);
            deviceValue15.Name = "deviceValue15";
            deviceValue15.Size = new Size(215, 25);
            deviceValue15.TabIndex = 6;
            deviceValue15.Value = 0F;
            // 
            // deviceStatus10
            // 
            deviceStatus10.BackColor = Color.Transparent;
            deviceStatus10.DeviceName = "陶化排风机";
            deviceStatus10.Dock = DockStyle.Top;
            deviceStatus10.Location = new Point(0, 25);
            deviceStatus10.Margin = new Padding(0);
            deviceStatus10.Name = "deviceStatus10";
            deviceStatus10.Size = new Size(215, 25);
            deviceStatus10.Status = false;
            deviceStatus10.TabIndex = 7;
            // 
            // deviceStatus2
            // 
            deviceStatus2.BackColor = Color.Transparent;
            deviceStatus2.DeviceName = "陶化喷淋泵";
            deviceStatus2.Dock = DockStyle.Top;
            deviceStatus2.Location = new Point(0, 0);
            deviceStatus2.Margin = new Padding(0);
            deviceStatus2.Name = "deviceStatus2";
            deviceStatus2.Size = new Size(215, 25);
            deviceStatus2.Status = false;
            deviceStatus2.TabIndex = 2;
            // 
            // panel13
            // 
            panel13.Back = Color.Transparent;
            panel13.BackColor = SystemColors.Control;
            panel13.Controls.Add(deviceAlarm4);
            panel13.Controls.Add(deviceAlarm1);
            panel13.Dock = DockStyle.Fill;
            panel13.Location = new Point(5, 44);
            panel13.Name = "panel13";
            panel13.Size = new Size(215, 109);
            panel13.TabIndex = 8;
            panel13.Tag = "陶化报警";
            panel13.Text = "panel13";
            // 
            // deviceAlarm4
            // 
            deviceAlarm4.AlarmName = "陶化低液位";
            deviceAlarm4.BackColor = Color.Transparent;
            deviceAlarm4.Dock = DockStyle.Top;
            deviceAlarm4.IsAlarm = false;
            deviceAlarm4.Location = new Point(0, 25);
            deviceAlarm4.Name = "deviceAlarm4";
            deviceAlarm4.Size = new Size(215, 25);
            deviceAlarm4.TabIndex = 6;
            deviceAlarm4.Visible = false;
            // 
            // deviceAlarm1
            // 
            deviceAlarm1.AlarmName = "陶化喷淋泵过载";
            deviceAlarm1.BackColor = Color.Transparent;
            deviceAlarm1.Dock = DockStyle.Top;
            deviceAlarm1.IsAlarm = false;
            deviceAlarm1.Location = new Point(0, 0);
            deviceAlarm1.Name = "deviceAlarm1";
            deviceAlarm1.Size = new Size(215, 25);
            deviceAlarm1.TabIndex = 7;
            deviceAlarm1.Visible = false;
            // 
            // panel14
            // 
            panel14.Back = Color.LightGray;
            panel14.BackColor = Color.Transparent;
            panel14.Controls.Add(label11);
            panel14.Dock = DockStyle.Top;
            panel14.Location = new Point(5, 5);
            panel14.Margin = new Padding(0);
            panel14.Name = "panel14";
            panel14.Size = new Size(215, 39);
            panel14.TabIndex = 0;
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
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(panel11);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(225, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Shadow = 4;
            panel2.ShadowOpacityAnimation = true;
            panel2.Size = new Size(225, 158);
            panel2.TabIndex = 13;
            panel2.Text = "panel2";
            // 
            // panel10
            // 
            panel10.Back = Color.Transparent;
            panel10.BackColor = SystemColors.Control;
            panel10.Controls.Add(deviceValue14);
            panel10.Controls.Add(deviceStatus9);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(5, 44);
            panel10.Name = "panel10";
            panel10.Size = new Size(215, 109);
            panel10.TabIndex = 9;
            panel10.Tag = "粗洗监控";
            panel10.Text = "panel10";
            // 
            // deviceValue14
            // 
            deviceValue14.BackColor = Color.Transparent;
            deviceValue14.DeviceName = "粗洗喷淋泵压力值";
            deviceValue14.Dock = DockStyle.Top;
            deviceValue14.Location = new Point(0, 25);
            deviceValue14.Margin = new Padding(0);
            deviceValue14.Name = "deviceValue14";
            deviceValue14.Size = new Size(215, 25);
            deviceValue14.TabIndex = 5;
            deviceValue14.Value = 0F;
            // 
            // deviceStatus9
            // 
            deviceStatus9.BackColor = Color.Transparent;
            deviceStatus9.DeviceName = "粗洗喷淋泵";
            deviceStatus9.Dock = DockStyle.Top;
            deviceStatus9.Location = new Point(0, 0);
            deviceStatus9.Margin = new Padding(0);
            deviceStatus9.Name = "deviceStatus9";
            deviceStatus9.Size = new Size(215, 25);
            deviceStatus9.Status = false;
            deviceStatus9.TabIndex = 2;
            // 
            // panel11
            // 
            panel11.Back = Color.Transparent;
            panel11.BackColor = SystemColors.Control;
            panel11.Controls.Add(deviceAlarm3);
            panel11.Controls.Add(deviceAlarm2);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(5, 44);
            panel11.Name = "panel11";
            panel11.Size = new Size(215, 109);
            panel11.TabIndex = 8;
            panel11.Tag = "粗洗报警";
            panel11.Text = "panel11";
            // 
            // deviceAlarm3
            // 
            deviceAlarm3.AlarmName = "粗洗低液位";
            deviceAlarm3.BackColor = Color.Transparent;
            deviceAlarm3.Dock = DockStyle.Top;
            deviceAlarm3.IsAlarm = false;
            deviceAlarm3.Location = new Point(0, 25);
            deviceAlarm3.Name = "deviceAlarm3";
            deviceAlarm3.Size = new Size(215, 25);
            deviceAlarm3.TabIndex = 7;
            deviceAlarm3.Visible = false;
            // 
            // deviceAlarm2
            // 
            deviceAlarm2.AlarmName = "粗洗喷淋泵过载";
            deviceAlarm2.BackColor = Color.Transparent;
            deviceAlarm2.Dock = DockStyle.Top;
            deviceAlarm2.IsAlarm = false;
            deviceAlarm2.Location = new Point(0, 0);
            deviceAlarm2.Name = "deviceAlarm2";
            deviceAlarm2.Size = new Size(215, 25);
            deviceAlarm2.TabIndex = 6;
            deviceAlarm2.Visible = false;
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
            panel4.Size = new Size(215, 39);
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
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel8);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Shadow = 4;
            panel3.ShadowOpacityAnimation = true;
            panel3.Size = new Size(225, 158);
            panel3.TabIndex = 17;
            panel3.Text = "panel3";
            // 
            // panel6
            // 
            panel6.Back = Color.Transparent;
            panel6.BackColor = SystemColors.Control;
            panel6.Controls.Add(deviceValue1);
            panel6.Controls.Add(deviceValue11);
            panel6.Controls.Add(deviceStatus1);
            panel6.Controls.Add(deviceStatus5);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(5, 44);
            panel6.Name = "panel6";
            panel6.Size = new Size(215, 109);
            panel6.TabIndex = 9;
            panel6.Tag = "脱脂监控";
            panel6.Text = "panel6";
            // 
            // deviceValue1
            // 
            deviceValue1.BackColor = Color.Transparent;
            deviceValue1.DeviceName = "脱脂pH值";
            deviceValue1.Dock = DockStyle.Top;
            deviceValue1.Location = new Point(0, 75);
            deviceValue1.Margin = new Padding(0);
            deviceValue1.Name = "deviceValue1";
            deviceValue1.Size = new Size(215, 25);
            deviceValue1.TabIndex = 5;
            deviceValue1.Value = 0F;
            // 
            // deviceValue11
            // 
            deviceValue11.BackColor = Color.Transparent;
            deviceValue11.DeviceName = "脱脂喷淋泵压力值";
            deviceValue11.Dock = DockStyle.Top;
            deviceValue11.Location = new Point(0, 50);
            deviceValue11.Margin = new Padding(0);
            deviceValue11.Name = "deviceValue11";
            deviceValue11.Size = new Size(215, 25);
            deviceValue11.TabIndex = 6;
            deviceValue11.Value = 0F;
            // 
            // deviceStatus1
            // 
            deviceStatus1.BackColor = Color.Transparent;
            deviceStatus1.DeviceName = "脱脂排风机";
            deviceStatus1.Dock = DockStyle.Top;
            deviceStatus1.Location = new Point(0, 25);
            deviceStatus1.Margin = new Padding(0);
            deviceStatus1.Name = "deviceStatus1";
            deviceStatus1.Size = new Size(215, 25);
            deviceStatus1.Status = false;
            deviceStatus1.TabIndex = 7;
            // 
            // deviceStatus5
            // 
            deviceStatus5.BackColor = Color.Transparent;
            deviceStatus5.DeviceName = "脱脂喷淋泵";
            deviceStatus5.Dock = DockStyle.Top;
            deviceStatus5.Location = new Point(0, 0);
            deviceStatus5.Margin = new Padding(0);
            deviceStatus5.Name = "deviceStatus5";
            deviceStatus5.Size = new Size(215, 25);
            deviceStatus5.Status = false;
            deviceStatus5.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.Back = Color.Transparent;
            panel7.BackColor = SystemColors.Control;
            panel7.Controls.Add(deviceAlarm5);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(5, 44);
            panel7.Name = "panel7";
            panel7.Size = new Size(215, 109);
            panel7.TabIndex = 8;
            panel7.Tag = "脱脂报警";
            panel7.Text = "panel7";
            // 
            // deviceAlarm5
            // 
            deviceAlarm5.AlarmName = "脱脂低液位";
            deviceAlarm5.BackColor = Color.Transparent;
            deviceAlarm5.Dock = DockStyle.Top;
            deviceAlarm5.IsAlarm = false;
            deviceAlarm5.Location = new Point(0, 0);
            deviceAlarm5.Name = "deviceAlarm5";
            deviceAlarm5.Size = new Size(215, 25);
            deviceAlarm5.TabIndex = 6;
            deviceAlarm5.Visible = false;
            // 
            // panel8
            // 
            panel8.Back = Color.LightGray;
            panel8.BackColor = Color.Transparent;
            panel8.Controls.Add(label1);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(5, 5);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(215, 39);
            panel8.TabIndex = 0;
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
            Size = new Size(900, 700);
            gridPanel1.ResumeLayout(false);
            gridPanel_TitleInfo.ResumeLayout(false);
            panel1.ResumeLayout(false);
            gridPanel2.ResumeLayout(false);
            gridPanel4.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label lbl_sysStatus;
        private AntdUI.Label lbl_title;
        private AntdUI.Label lbl_plcStatus;
        private AntdUI.GridPanel gridPanel1;
        private AntdUI.LabelTime labelTime1;
        private AntdUI.Label lbl_temperature;
        private AntdUI.Label lbl_humidity;
        private AntdUI.GridPanel gridPanel_TitleInfo;
        private Panel panel1;
        private AntdUI.GridPanel gridPanel2;
        private AntdUI.Label label4;
        private AntdUI.Label label8;
        private AntdUI.Label label7;
        private AntdUI.Label label6;
        private AntdUI.Label label5;
        private AntdUI.GridPanel gridPanel5;
        private AntdUI.GridPanel gridPanel4;
        private UserControls.StationValue deviceValue5;
        private UserControls.StationValue deviceValue6;
        private UserControls.StationValue deviceValue3;
        private UserControls.StationValue deviceValue4;
        private UserControls.StationValue deviceValue7;
        private UserControls.StationStatus deviceStatus3;
        private UserControls.StationStatus deviceStatus4;
        private UserControls.StationValue deviceValue8;
        private UserControls.StationValue deviceValue9;
        private UserControls.StationValue deviceValue12;
        private UserControls.StationValue deviceValue13;
        private UserControls.StationStatus deviceStatus7;
        private UserControls.StationStatus deviceStatus8;
        private AntdUI.Panel panel2;
        private UserControls.StationValue deviceValue10;
        private UserControls.StationStatus deviceStatus6;
        private AntdUI.Panel panel4;
        private AntdUI.Label label3;
        private UserControls.StationValue deviceValue14;
        private UserControls.StationStatus deviceStatus9;
        private UserControls.StationAlarm deviceAlarm3;
        private UserControls.StationAlarm deviceAlarm2;
        private AntdUI.Panel panel11;
        private AntdUI.Panel panel10;
        private AntdUI.Panel panel5;
        private AntdUI.Panel panel9;
        private UserControls.StationValue deviceValue2;
        private UserControls.StationValue deviceValue15;
        private UserControls.StationStatus deviceStatus10;
        private UserControls.StationStatus deviceStatus2;
        private AntdUI.Panel panel13;
        private UserControls.StationAlarm deviceAlarm1;
        private UserControls.StationAlarm deviceAlarm4;
        private AntdUI.Panel panel14;
        private AntdUI.Label label11;
        private AntdUI.Panel panel12;
        private AntdUI.Panel panel15;
        private UserControls.StationValue deviceValue16;
        private UserControls.StationStatus deviceStatus12;
        private AntdUI.Panel panel16;
        private UserControls.StationAlarm deviceAlarm7;
        private UserControls.StationAlarm deviceAlarm8;
        private AntdUI.Panel panel17;
        private AntdUI.Label label12;
        private AntdUI.Panel panel3;
        private AntdUI.Panel panel6;
        private UserControls.StationValue deviceValue1;
        private UserControls.StationValue deviceValue11;
        private UserControls.StationStatus deviceStatus1;
        private UserControls.StationStatus deviceStatus5;
        private AntdUI.Panel panel7;
        private UserControls.StationAlarm deviceAlarm5;
        private AntdUI.Panel panel8;
        private AntdUI.Label label1;
    }
}
