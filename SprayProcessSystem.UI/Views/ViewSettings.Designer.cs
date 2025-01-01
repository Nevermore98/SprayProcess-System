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
            flowPanel6 = new AntdUI.FlowPanel();
            select3 = new AntdUI.Select();
            label8 = new AntdUI.Label();
            flowPanel5 = new AntdUI.FlowPanel();
            input11 = new AntdUI.Input();
            label17 = new AntdUI.Label();
            label12 = new AntdUI.Label();
            flowPanel4 = new AntdUI.FlowPanel();
            input8 = new AntdUI.Input();
            label13 = new AntdUI.Label();
            input9 = new AntdUI.Input();
            label14 = new AntdUI.Label();
            label11 = new AntdUI.Label();
            flowPanel2 = new AntdUI.FlowPanel();
            input7 = new AntdUI.Input();
            label4 = new AntdUI.Label();
            input1 = new AntdUI.Input();
            label3 = new AntdUI.Label();
            input3 = new AntdUI.Input();
            label2 = new AntdUI.Label();
            flowPanel3 = new AntdUI.FlowPanel();
            input5 = new AntdUI.Input();
            label9 = new AntdUI.Label();
            input6 = new AntdUI.Input();
            label10 = new AntdUI.Label();
            flowPanel1 = new AntdUI.FlowPanel();
            select2 = new AntdUI.Select();
            label5 = new AntdUI.Label();
            input2 = new AntdUI.Input();
            label6 = new AntdUI.Label();
            input4 = new AntdUI.Input();
            label7 = new AntdUI.Label();
            uploadDragger2 = new AntdUI.UploadDragger();
            flowPanel7 = new AntdUI.FlowPanel();
            txt_plcConfigPath = new AntdUI.Input();
            label15 = new AntdUI.Label();
            stackPanel1.SuspendLayout();
            flowPanel6.SuspendLayout();
            flowPanel5.SuspendLayout();
            flowPanel4.SuspendLayout();
            flowPanel2.SuspendLayout();
            flowPanel3.SuspendLayout();
            flowPanel1.SuspendLayout();
            flowPanel7.SuspendLayout();
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
            stackPanel1.Controls.Add(flowPanel6);
            stackPanel1.Controls.Add(flowPanel5);
            stackPanel1.Controls.Add(label12);
            stackPanel1.Controls.Add(flowPanel4);
            stackPanel1.Controls.Add(label11);
            stackPanel1.Controls.Add(flowPanel2);
            stackPanel1.Controls.Add(flowPanel3);
            stackPanel1.Controls.Add(flowPanel1);
            stackPanel1.Controls.Add(uploadDragger2);
            stackPanel1.Controls.Add(flowPanel7);
            stackPanel1.Controls.Add(label1);
            stackPanel1.Dock = DockStyle.Fill;
            stackPanel1.Location = new Point(0, 0);
            stackPanel1.Name = "stackPanel1";
            stackPanel1.Size = new Size(900, 700);
            stackPanel1.TabIndex = 1;
            stackPanel1.Text = "stackPanel1";
            stackPanel1.Vertical = true;
            // 
            // flowPanel6
            // 
            flowPanel6.Controls.Add(select3);
            flowPanel6.Controls.Add(label8);
            flowPanel6.Location = new Point(3, 530);
            flowPanel6.Name = "flowPanel6";
            flowPanel6.Size = new Size(894, 45);
            flowPanel6.TabIndex = 10;
            flowPanel6.Text = "flowPanel6";
            // 
            // select3
            // 
            select3.Items.AddRange(new object[] { "不清理", "3天", "7天", "15天", "30天", "60天" });
            select3.List = true;
            select3.Location = new Point(69, 3);
            select3.Name = "select3";
            select3.Size = new Size(130, 36);
            select3.TabIndex = 7;
            select3.WaveSize = 0;
            // 
            // label8
            // 
            label8.Location = new Point(3, 3);
            label8.Name = "label8";
            label8.Size = new Size(60, 36);
            label8.TabIndex = 5;
            label8.Text = "清理周期";
            // 
            // flowPanel5
            // 
            flowPanel5.Controls.Add(input11);
            flowPanel5.Controls.Add(label17);
            flowPanel5.Location = new Point(3, 479);
            flowPanel5.Name = "flowPanel5";
            flowPanel5.Size = new Size(894, 45);
            flowPanel5.TabIndex = 9;
            flowPanel5.Text = "flowPanel5";
            // 
            // input11
            // 
            input11.Location = new Point(69, 3);
            input11.Margin = new Padding(3, 3, 13, 3);
            input11.Name = "input11";
            input11.Size = new Size(554, 36);
            input11.TabIndex = 0;
            input11.Text = "input11";
            input11.WaveSize = 0;
            // 
            // label17
            // 
            label17.Location = new Point(3, 3);
            label17.Name = "label17";
            label17.Size = new Size(60, 36);
            label17.TabIndex = 2;
            label17.Text = "日志文件夹";
            // 
            // label12
            // 
            label12.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(3, 433);
            label12.Name = "label12";
            label12.Size = new Size(894, 40);
            label12.TabIndex = 8;
            label12.Text = "日志设置";
            // 
            // flowPanel4
            // 
            flowPanel4.Controls.Add(input8);
            flowPanel4.Controls.Add(label13);
            flowPanel4.Controls.Add(input9);
            flowPanel4.Controls.Add(label14);
            flowPanel4.Location = new Point(3, 382);
            flowPanel4.Name = "flowPanel4";
            flowPanel4.Size = new Size(894, 45);
            flowPanel4.TabIndex = 7;
            flowPanel4.Text = "flowPanel4";
            // 
            // input8
            // 
            input8.Location = new Point(286, 3);
            input8.Margin = new Padding(3, 3, 13, 3);
            input8.Name = "input8";
            input8.Size = new Size(130, 36);
            input8.TabIndex = 4;
            input8.WaveSize = 0;
            // 
            // label13
            // 
            label13.Location = new Point(210, 3);
            label13.Name = "label13";
            label13.Size = new Size(70, 36);
            label13.TabIndex = 3;
            label13.Text = "试用时间（s）";
            // 
            // input9
            // 
            input9.Location = new Point(64, 3);
            input9.Margin = new Padding(3, 3, 13, 3);
            input9.Name = "input9";
            input9.Size = new Size(130, 36);
            input9.TabIndex = 0;
            input9.Text = "input9";
            input9.WaveSize = 0;
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
            label11.Location = new Point(3, 336);
            label11.Name = "label11";
            label11.Size = new Size(894, 40);
            label11.TabIndex = 6;
            label11.Text = "软件参数";
            // 
            // flowPanel2
            // 
            flowPanel2.Controls.Add(input7);
            flowPanel2.Controls.Add(label4);
            flowPanel2.Controls.Add(input1);
            flowPanel2.Controls.Add(label3);
            flowPanel2.Controls.Add(input3);
            flowPanel2.Controls.Add(label2);
            flowPanel2.Location = new Point(3, 285);
            flowPanel2.Name = "flowPanel2";
            flowPanel2.Size = new Size(894, 45);
            flowPanel2.TabIndex = 3;
            flowPanel2.Text = "flowPanel2";
            // 
            // input7
            // 
            input7.Location = new Point(493, 3);
            input7.Margin = new Padding(3, 3, 13, 3);
            input7.Name = "input7";
            input7.Size = new Size(130, 36);
            input7.TabIndex = 8;
            input7.WaveSize = 0;
            // 
            // label4
            // 
            label4.Location = new Point(427, 3);
            label4.Name = "label4";
            label4.Size = new Size(60, 36);
            label4.TabIndex = 5;
            label4.Text = "重连时间（ms）";
            // 
            // input1
            // 
            input1.Location = new Point(281, 3);
            input1.Margin = new Padding(3, 3, 13, 3);
            input1.Name = "input1";
            input1.Size = new Size(130, 36);
            input1.TabIndex = 4;
            input1.WaveSize = 0;
            // 
            // label3
            // 
            label3.Location = new Point(215, 3);
            label3.Name = "label3";
            label3.Size = new Size(60, 36);
            label3.TabIndex = 3;
            label3.Text = "读取时间（ms）";
            // 
            // input3
            // 
            input3.Location = new Point(69, 3);
            input3.Margin = new Padding(3, 3, 13, 3);
            input3.Name = "input3";
            input3.Size = new Size(130, 36);
            input3.TabIndex = 0;
            input3.Text = "input3";
            input3.WaveSize = 0;
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
            flowPanel3.Controls.Add(input5);
            flowPanel3.Controls.Add(label9);
            flowPanel3.Controls.Add(input6);
            flowPanel3.Controls.Add(label10);
            flowPanel3.Location = new Point(3, 234);
            flowPanel3.Name = "flowPanel3";
            flowPanel3.Size = new Size(894, 45);
            flowPanel3.TabIndex = 5;
            flowPanel3.Text = "flowPanel3";
            // 
            // input5
            // 
            input5.Location = new Point(281, 3);
            input5.Margin = new Padding(3, 3, 13, 3);
            input5.Name = "input5";
            input5.Size = new Size(130, 36);
            input5.TabIndex = 4;
            input5.WaveSize = 0;
            // 
            // label9
            // 
            label9.Location = new Point(215, 3);
            label9.Name = "label9";
            label9.Size = new Size(60, 36);
            label9.TabIndex = 3;
            label9.Text = "插槽号";
            // 
            // input6
            // 
            input6.Location = new Point(69, 3);
            input6.Margin = new Padding(3, 3, 13, 3);
            input6.Name = "input6";
            input6.Size = new Size(130, 36);
            input6.TabIndex = 0;
            input6.Text = "input6";
            input6.WaveSize = 0;
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
            flowPanel1.Controls.Add(select2);
            flowPanel1.Controls.Add(label5);
            flowPanel1.Controls.Add(input2);
            flowPanel1.Controls.Add(label6);
            flowPanel1.Controls.Add(input4);
            flowPanel1.Controls.Add(label7);
            flowPanel1.Location = new Point(3, 183);
            flowPanel1.Name = "flowPanel1";
            flowPanel1.Size = new Size(894, 45);
            flowPanel1.TabIndex = 4;
            flowPanel1.Text = "flowPanel1";
            // 
            // select2
            // 
            select2.Items.AddRange(new object[] { "S7" });
            select2.List = true;
            select2.Location = new Point(493, 3);
            select2.Name = "select2";
            select2.Size = new Size(130, 36);
            select2.TabIndex = 7;
            select2.WaveSize = 0;
            // 
            // label5
            // 
            label5.Location = new Point(427, 3);
            label5.Name = "label5";
            label5.Size = new Size(60, 36);
            label5.TabIndex = 5;
            label5.Text = "PLC 类型";
            // 
            // input2
            // 
            input2.Location = new Point(281, 3);
            input2.Margin = new Padding(3, 3, 13, 3);
            input2.Name = "input2";
            input2.Size = new Size(130, 36);
            input2.TabIndex = 4;
            input2.WaveSize = 0;
            // 
            // label6
            // 
            label6.Location = new Point(215, 3);
            label6.Name = "label6";
            label6.Size = new Size(60, 36);
            label6.TabIndex = 3;
            label6.Text = "端口号";
            // 
            // input4
            // 
            input4.Location = new Point(69, 3);
            input4.Margin = new Padding(3, 3, 13, 3);
            input4.Name = "input4";
            input4.Size = new Size(130, 36);
            input4.TabIndex = 0;
            input4.Text = "input4";
            input4.WaveSize = 0;
            // 
            // label7
            // 
            label7.Location = new Point(3, 3);
            label7.Name = "label7";
            label7.Size = new Size(60, 36);
            label7.TabIndex = 2;
            label7.Text = "IP 地址";
            // 
            // uploadDragger2
            // 
            uploadDragger2.Location = new Point(3, 100);
            uploadDragger2.Name = "uploadDragger2";
            uploadDragger2.Size = new Size(894, 77);
            uploadDragger2.TabIndex = 4;
            uploadDragger2.Text = "点击或拖拽 PLC 配置 Excel 文件";
            uploadDragger2.DragChanged += upd_plcConfigPath_DragChanged;
            uploadDragger2.Click += upd_plcConfigPath_Click;
            // 
            // flowPanel7
            // 
            flowPanel7.Controls.Add(txt_plcConfigPath);
            flowPanel7.Controls.Add(label15);
            flowPanel7.Location = new Point(3, 49);
            flowPanel7.Name = "flowPanel7";
            flowPanel7.Size = new Size(894, 45);
            flowPanel7.TabIndex = 11;
            flowPanel7.Text = "flowPanel7";
            // 
            // txt_plcConfigPath
            // 
            txt_plcConfigPath.Location = new Point(69, 3);
            txt_plcConfigPath.Margin = new Padding(3, 3, 13, 3);
            txt_plcConfigPath.Name = "txt_plcConfigPath";
            txt_plcConfigPath.ReadOnly = true;
            txt_plcConfigPath.Size = new Size(554, 36);
            txt_plcConfigPath.TabIndex = 0;
            txt_plcConfigPath.WaveSize = 0;
            // 
            // label15
            // 
            label15.Location = new Point(3, 3);
            label15.Name = "label15";
            label15.Size = new Size(60, 36);
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
            flowPanel6.ResumeLayout(false);
            flowPanel5.ResumeLayout(false);
            flowPanel4.ResumeLayout(false);
            flowPanel2.ResumeLayout(false);
            flowPanel3.ResumeLayout(false);
            flowPanel1.ResumeLayout(false);
            flowPanel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.StackPanel stackPanel1;
        private AntdUI.FlowPanel flowPanel2;
        private AntdUI.Input input3;
        private AntdUI.Label label2;
        private AntdUI.Label label4;
        private AntdUI.Input input1;
        private AntdUI.Label label3;
        private AntdUI.FlowPanel flowPanel4;
        private AntdUI.Input input8;
        private AntdUI.Label label13;
        private AntdUI.Input input9;
        private AntdUI.Label label14;
        private AntdUI.Label label11;
        private AntdUI.Input input7;
        private AntdUI.FlowPanel flowPanel3;
        private AntdUI.Input input5;
        private AntdUI.Label label9;
        private AntdUI.Input input6;
        private AntdUI.Label label10;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Select select2;
        private AntdUI.Label label5;
        private AntdUI.Input input2;
        private AntdUI.Label label6;
        private AntdUI.Input input4;
        private AntdUI.Label label7;
        private AntdUI.FlowPanel flowPanel5;
        private AntdUI.Input input11;
        private AntdUI.Label label17;
        private AntdUI.Label label12;
        private AntdUI.FlowPanel flowPanel6;
        private AntdUI.Select select3;
        private AntdUI.Label label8;
        private AntdUI.FlowPanel flowPanel7;
        private AntdUI.Input txt_plcConfigPath;
        private AntdUI.Label label15;
        private AntdUI.UploadDragger uploadDragger2;
    }
}
