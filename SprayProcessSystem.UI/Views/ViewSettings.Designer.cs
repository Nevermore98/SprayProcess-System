namespace SprayProcessSystem.UI.Views
{
    partial class ViewSettings
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
            label1 = new AntdUI.Label();
            stackPanel1 = new AntdUI.StackPanel();
            flowPanel4 = new AntdUI.FlowPanel();
            txt_trialSeconds = new AntdUI.Input();
            label13 = new AntdUI.Label();
            txt_softVersion = new AntdUI.Input();
            label14 = new AntdUI.Label();
            label11 = new AntdUI.Label();
            flowPanel6 = new AntdUI.FlowPanel();
            cmb_logKeepDays = new AntdUI.Select();
            label8 = new AntdUI.Label();
            gridPanel2 = new AntdUI.GridPanel();
            btn_logDir = new AntdUI.Button();
            txt_logDir = new AntdUI.Input();
            label17 = new AntdUI.Label();
            label12 = new AntdUI.Label();
            flowPanel2 = new AntdUI.FlowPanel();
            txt_plcReConnectInterval = new AntdUI.Input();
            label4 = new AntdUI.Label();
            txt_plcReadInterval = new AntdUI.Input();
            label3 = new AntdUI.Label();
            txt_plcConnectTimeout = new AntdUI.Input();
            label2 = new AntdUI.Label();
            flowPanel3 = new AntdUI.FlowPanel();
            txt_plcSlot = new AntdUI.Input();
            label9 = new AntdUI.Label();
            txt_plcRack = new AntdUI.Input();
            label10 = new AntdUI.Label();
            flowPanel1 = new AntdUI.FlowPanel();
            cmb_plcType = new AntdUI.Select();
            label5 = new AntdUI.Label();
            txt_plcPort = new AntdUI.Input();
            label6 = new AntdUI.Label();
            txt_plcIp = new AntdUI.Input();
            label7 = new AntdUI.Label();
            upd_plcExcel = new AntdUI.UploadDragger();
            gridPanel1 = new AntdUI.GridPanel();
            txt_plcConfigPath = new AntdUI.Input();
            label15 = new AntdUI.Label();
            stackPanel1.SuspendLayout();
            flowPanel4.SuspendLayout();
            flowPanel6.SuspendLayout();
            gridPanel2.SuspendLayout();
            flowPanel2.SuspendLayout();
            flowPanel3.SuspendLayout();
            flowPanel1.SuspendLayout();
            gridPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(894, 40);
            label1.TabIndex = 0;
            label1.Text = "PLC 设置";
            // 
            // stackPanel1
            // 
            stackPanel1.AutoScroll = true;
            stackPanel1.Controls.Add(flowPanel4);
            stackPanel1.Controls.Add(label11);
            stackPanel1.Controls.Add(flowPanel6);
            stackPanel1.Controls.Add(gridPanel2);
            stackPanel1.Controls.Add(label12);
            stackPanel1.Controls.Add(flowPanel2);
            stackPanel1.Controls.Add(flowPanel3);
            stackPanel1.Controls.Add(flowPanel1);
            stackPanel1.Controls.Add(upd_plcExcel);
            stackPanel1.Controls.Add(gridPanel1);
            stackPanel1.Controls.Add(label1);
            stackPanel1.Dock = DockStyle.Fill;
            stackPanel1.Location = new Point(0, 0);
            stackPanel1.Name = "stackPanel1";
            stackPanel1.Size = new Size(900, 700);
            stackPanel1.TabIndex = 1;
            stackPanel1.Text = "stackPanel1";
            stackPanel1.Vertical = true;
            // 
            // flowPanel4
            // 
            flowPanel4.Controls.Add(txt_trialSeconds);
            flowPanel4.Controls.Add(label13);
            flowPanel4.Controls.Add(txt_softVersion);
            flowPanel4.Controls.Add(label14);
            flowPanel4.Location = new Point(3, 533);
            flowPanel4.Name = "flowPanel4";
            flowPanel4.Size = new Size(894, 45);
            flowPanel4.TabIndex = 7;
            flowPanel4.Text = "flowPanel4";
            flowPanel4.Visible = false;
            // 
            // txt_trialSeconds
            // 
            txt_trialSeconds.Location = new Point(286, 3);
            txt_trialSeconds.Margin = new Padding(3, 3, 13, 3);
            txt_trialSeconds.Name = "txt_trialSeconds";
            txt_trialSeconds.Size = new Size(130, 36);
            txt_trialSeconds.TabIndex = 4;
            txt_trialSeconds.WaveSize = 0;
            // 
            // label13
            // 
            label13.Location = new Point(210, 3);
            label13.Name = "label13";
            label13.Size = new Size(70, 36);
            label13.TabIndex = 3;
            label13.Text = "试用时间（s）";
            // 
            // txt_softVersion
            // 
            txt_softVersion.Location = new Point(64, 3);
            txt_softVersion.Margin = new Padding(3, 3, 13, 3);
            txt_softVersion.Name = "txt_softVersion";
            txt_softVersion.Size = new Size(130, 36);
            txt_softVersion.TabIndex = 0;
            txt_softVersion.WaveSize = 0;
            // 
            // label14
            // 
            label14.Location = new Point(3, 3);
            label14.Name = "label14";
            label14.Size = new Size(55, 36);
            label14.TabIndex = 2;
            label14.Text = "软件版本";
            // 
            // label11
            // 
            label11.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(3, 487);
            label11.Name = "label11";
            label11.Size = new Size(894, 40);
            label11.TabIndex = 6;
            label11.Text = "软件参数";
            label11.Visible = false;
            // 
            // flowPanel6
            // 
            flowPanel6.Controls.Add(cmb_logKeepDays);
            flowPanel6.Controls.Add(label8);
            flowPanel6.Location = new Point(3, 436);
            flowPanel6.Name = "flowPanel6";
            flowPanel6.Size = new Size(894, 45);
            flowPanel6.TabIndex = 10;
            flowPanel6.Text = "flowPanel6";
            // 
            // cmb_logKeepDays
            // 
            cmb_logKeepDays.Items.AddRange(new object[] { "不清理", "3天", "7天", "15天", "30天", "60天" });
            cmb_logKeepDays.List = true;
            cmb_logKeepDays.Location = new Point(69, 3);
            cmb_logKeepDays.Name = "cmb_logKeepDays";
            cmb_logKeepDays.Size = new Size(130, 36);
            cmb_logKeepDays.TabIndex = 7;
            cmb_logKeepDays.WaveSize = 0;
            // 
            // label8
            // 
            label8.Location = new Point(3, 3);
            label8.Name = "label8";
            label8.Size = new Size(60, 36);
            label8.TabIndex = 5;
            label8.Text = "清理周期";
            // 
            // gridPanel2
            // 
            gridPanel2.Controls.Add(btn_logDir);
            gridPanel2.Controls.Add(txt_logDir);
            gridPanel2.Controls.Add(label17);
            gridPanel2.Location = new Point(3, 385);
            gridPanel2.Name = "gridPanel2";
            gridPanel2.Size = new Size(894, 45);
            gridPanel2.Span = "86 100% 90;";
            gridPanel2.TabIndex = 11;
            gridPanel2.Text = "gridPanel2";
            // 
            // btn_logDir
            // 
            btn_logDir.Location = new Point(779, 0);
            btn_logDir.Margin = new Padding(0);
            btn_logDir.Name = "btn_logDir";
            btn_logDir.Size = new Size(115, 45);
            btn_logDir.TabIndex = 3;
            btn_logDir.Text = "选择目录";
            btn_logDir.Type = AntdUI.TTypeMini.Primary;
            // 
            // txt_logDir
            // 
            txt_logDir.Location = new Point(113, 3);
            txt_logDir.Name = "txt_logDir";
            txt_logDir.ReadOnly = true;
            txt_logDir.Size = new Size(663, 39);
            txt_logDir.TabIndex = 0;
            txt_logDir.WaveSize = 0;
            // 
            // label17
            // 
            label17.Location = new Point(3, 3);
            label17.Name = "label17";
            label17.Size = new Size(104, 39);
            label17.TabIndex = 2;
            label17.Text = "存放目录";
            // 
            // label12
            // 
            label12.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(3, 339);
            label12.Name = "label12";
            label12.Size = new Size(894, 40);
            label12.TabIndex = 8;
            label12.Text = "日志设置";
            // 
            // flowPanel2
            // 
            flowPanel2.Controls.Add(txt_plcReConnectInterval);
            flowPanel2.Controls.Add(label4);
            flowPanel2.Controls.Add(txt_plcReadInterval);
            flowPanel2.Controls.Add(label3);
            flowPanel2.Controls.Add(txt_plcConnectTimeout);
            flowPanel2.Controls.Add(label2);
            flowPanel2.Location = new Point(3, 288);
            flowPanel2.Name = "flowPanel2";
            flowPanel2.Size = new Size(894, 45);
            flowPanel2.TabIndex = 3;
            flowPanel2.Text = "flowPanel2";
            // 
            // txt_plcReConnectInterval
            // 
            txt_plcReConnectInterval.Location = new Point(493, 3);
            txt_plcReConnectInterval.Margin = new Padding(3, 3, 13, 3);
            txt_plcReConnectInterval.Name = "txt_plcReConnectInterval";
            txt_plcReConnectInterval.Size = new Size(130, 36);
            txt_plcReConnectInterval.TabIndex = 8;
            txt_plcReConnectInterval.WaveSize = 0;
            // 
            // label4
            // 
            label4.Location = new Point(427, 3);
            label4.Name = "label4";
            label4.Size = new Size(60, 36);
            label4.TabIndex = 5;
            label4.Text = "重连时间（ms）";
            // 
            // txt_plcReadInterval
            // 
            txt_plcReadInterval.Location = new Point(281, 3);
            txt_plcReadInterval.Margin = new Padding(3, 3, 13, 3);
            txt_plcReadInterval.Name = "txt_plcReadInterval";
            txt_plcReadInterval.Size = new Size(130, 36);
            txt_plcReadInterval.TabIndex = 4;
            txt_plcReadInterval.WaveSize = 0;
            // 
            // label3
            // 
            label3.Location = new Point(215, 3);
            label3.Name = "label3";
            label3.Size = new Size(60, 36);
            label3.TabIndex = 3;
            label3.Text = "读取时间（ms）";
            // 
            // txt_plcConnectTimeout
            // 
            txt_plcConnectTimeout.Location = new Point(69, 3);
            txt_plcConnectTimeout.Margin = new Padding(3, 3, 13, 3);
            txt_plcConnectTimeout.Name = "txt_plcConnectTimeout";
            txt_plcConnectTimeout.Size = new Size(130, 36);
            txt_plcConnectTimeout.TabIndex = 0;
            txt_plcConnectTimeout.WaveSize = 0;
            // 
            // label2
            // 
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(60, 36);
            label2.TabIndex = 2;
            label2.Text = "超时时间（ms）";
            // 
            // flowPanel3
            // 
            flowPanel3.Controls.Add(txt_plcSlot);
            flowPanel3.Controls.Add(label9);
            flowPanel3.Controls.Add(txt_plcRack);
            flowPanel3.Controls.Add(label10);
            flowPanel3.Location = new Point(3, 237);
            flowPanel3.Name = "flowPanel3";
            flowPanel3.Size = new Size(894, 45);
            flowPanel3.TabIndex = 5;
            flowPanel3.Text = "flowPanel3";
            // 
            // txt_plcSlot
            // 
            txt_plcSlot.Location = new Point(281, 3);
            txt_plcSlot.Margin = new Padding(3, 3, 13, 3);
            txt_plcSlot.Name = "txt_plcSlot";
            txt_plcSlot.Size = new Size(130, 36);
            txt_plcSlot.TabIndex = 4;
            txt_plcSlot.WaveSize = 0;
            // 
            // label9
            // 
            label9.Location = new Point(215, 3);
            label9.Name = "label9";
            label9.Size = new Size(60, 36);
            label9.TabIndex = 3;
            label9.Text = "插槽号";
            // 
            // txt_plcRack
            // 
            txt_plcRack.Location = new Point(69, 3);
            txt_plcRack.Margin = new Padding(3, 3, 13, 3);
            txt_plcRack.Name = "txt_plcRack";
            txt_plcRack.Size = new Size(130, 36);
            txt_plcRack.TabIndex = 0;
            txt_plcRack.WaveSize = 0;
            // 
            // label10
            // 
            label10.Location = new Point(3, 3);
            label10.Name = "label10";
            label10.Size = new Size(60, 36);
            label10.TabIndex = 2;
            label10.Text = "机架号";
            // 
            // flowPanel1
            // 
            flowPanel1.Controls.Add(cmb_plcType);
            flowPanel1.Controls.Add(label5);
            flowPanel1.Controls.Add(txt_plcPort);
            flowPanel1.Controls.Add(label6);
            flowPanel1.Controls.Add(txt_plcIp);
            flowPanel1.Controls.Add(label7);
            flowPanel1.Location = new Point(3, 186);
            flowPanel1.Name = "flowPanel1";
            flowPanel1.Size = new Size(894, 45);
            flowPanel1.TabIndex = 4;
            flowPanel1.Text = "flowPanel1";
            // 
            // cmb_plcType
            // 
            cmb_plcType.List = true;
            cmb_plcType.Location = new Point(493, 3);
            cmb_plcType.Name = "cmb_plcType";
            cmb_plcType.Size = new Size(130, 36);
            cmb_plcType.TabIndex = 7;
            cmb_plcType.WaveSize = 0;
            // 
            // label5
            // 
            label5.Location = new Point(427, 3);
            label5.Name = "label5";
            label5.Size = new Size(60, 36);
            label5.TabIndex = 5;
            label5.Text = "PLC 类型";
            // 
            // txt_plcPort
            // 
            txt_plcPort.Location = new Point(281, 3);
            txt_plcPort.Margin = new Padding(3, 3, 13, 3);
            txt_plcPort.Name = "txt_plcPort";
            txt_plcPort.Size = new Size(130, 36);
            txt_plcPort.TabIndex = 4;
            txt_plcPort.WaveSize = 0;
            // 
            // label6
            // 
            label6.Location = new Point(215, 3);
            label6.Name = "label6";
            label6.Size = new Size(60, 36);
            label6.TabIndex = 3;
            label6.Text = "端口号";
            // 
            // txt_plcIp
            // 
            txt_plcIp.Location = new Point(69, 3);
            txt_plcIp.Margin = new Padding(3, 3, 13, 3);
            txt_plcIp.Name = "txt_plcIp";
            txt_plcIp.Size = new Size(130, 36);
            txt_plcIp.TabIndex = 0;
            txt_plcIp.WaveSize = 0;
            // 
            // label7
            // 
            label7.Location = new Point(3, 3);
            label7.Name = "label7";
            label7.Size = new Size(60, 36);
            label7.TabIndex = 2;
            label7.Text = "IP 地址";
            // 
            // upd_plcExcel
            // 
            upd_plcExcel.Location = new Point(3, 100);
            upd_plcExcel.Name = "upd_plcExcel";
            upd_plcExcel.Size = new Size(894, 80);
            upd_plcExcel.TabIndex = 4;
            upd_plcExcel.Text = "点击或拖拽 PLC 配置 Excel 文件";
            upd_plcExcel.DragChanged += upd_plcConfigPath_DragChanged;
            // 
            // gridPanel1
            // 
            gridPanel1.Controls.Add(txt_plcConfigPath);
            gridPanel1.Controls.Add(label15);
            gridPanel1.Location = new Point(3, 49);
            gridPanel1.Name = "gridPanel1";
            gridPanel1.Size = new Size(894, 45);
            gridPanel1.Span = "86 100%;";
            gridPanel1.TabIndex = 3;
            gridPanel1.Text = "gridPanel1";
            // 
            // txt_plcConfigPath
            // 
            txt_plcConfigPath.Location = new Point(113, 3);
            txt_plcConfigPath.Name = "txt_plcConfigPath";
            txt_plcConfigPath.ReadOnly = true;
            txt_plcConfigPath.Size = new Size(778, 39);
            txt_plcConfigPath.TabIndex = 0;
            txt_plcConfigPath.WaveSize = 0;
            // 
            // label15
            // 
            label15.Location = new Point(3, 3);
            label15.Name = "label15";
            label15.Size = new Size(104, 39);
            label15.TabIndex = 2;
            label15.Text = "配置路径";
            // 
            // ViewSettings
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(stackPanel1);
            Name = "ViewSettings";
            Size = new Size(900, 700);
            Load += ViewSettings_Load;
            stackPanel1.ResumeLayout(false);
            flowPanel4.ResumeLayout(false);
            flowPanel6.ResumeLayout(false);
            gridPanel2.ResumeLayout(false);
            flowPanel2.ResumeLayout(false);
            flowPanel3.ResumeLayout(false);
            flowPanel1.ResumeLayout(false);
            gridPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.StackPanel stackPanel1;
        private AntdUI.FlowPanel flowPanel2;
        private AntdUI.Input txt_plcConnectTimeout;
        private AntdUI.Label label2;
        private AntdUI.Label label4;
        private AntdUI.Input txt_plcReadInterval;
        private AntdUI.Label label3;
        private AntdUI.FlowPanel flowPanel4;
        private AntdUI.Input txt_trialSeconds;
        private AntdUI.Label label13;
        private AntdUI.Input txt_softVersion;
        private AntdUI.Label label14;
        private AntdUI.Label label11;
        private AntdUI.Input txt_plcReConnectInterval;
        private AntdUI.FlowPanel flowPanel3;
        private AntdUI.Input txt_plcSlot;
        private AntdUI.Label label9;
        private AntdUI.Input txt_plcRack;
        private AntdUI.Label label10;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Select cmb_plcType;
        private AntdUI.Label label5;
        private AntdUI.Input txt_plcPort;
        private AntdUI.Label label6;
        private AntdUI.Input txt_plcIp;
        private AntdUI.Label label7;
        private AntdUI.Label label17;
        private AntdUI.Label label12;
        private AntdUI.FlowPanel flowPanel6;
        private AntdUI.Select cmb_logKeepDays;
        private AntdUI.Label label8;
        private AntdUI.Input txt_plcConfigPath;
        private AntdUI.Label label15;
        private AntdUI.UploadDragger upd_plcExcel;
        private AntdUI.GridPanel gridPanel1;
        private AntdUI.GridPanel gridPanel2;
        private AntdUI.Input txt_logDir;
        private AntdUI.Button btn_logDir;
    }
}
