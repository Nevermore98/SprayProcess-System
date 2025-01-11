namespace SprayProcessSystem.UI.Views
{
    partial class ViewUserManage
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
            panel3 = new Panel();
            btnSaveAuth = new AntdUI.Button();
            flowPanel1 = new AntdUI.FlowPanel();
            panel_visitorAuth = new AntdUI.Panel();
            checkbox20 = new AntdUI.Checkbox();
            checkbox21 = new AntdUI.Checkbox();
            checkbox22 = new AntdUI.Checkbox();
            checkbox23 = new AntdUI.Checkbox();
            checkbox24 = new AntdUI.Checkbox();
            checkbox25 = new AntdUI.Checkbox();
            checkbox29 = new AntdUI.Checkbox();
            label6 = new AntdUI.Label();
            panel_operatorAuth = new AntdUI.Panel();
            checkbox2 = new AntdUI.Checkbox();
            checkbox3 = new AntdUI.Checkbox();
            checkbox16 = new AntdUI.Checkbox();
            checkbox17 = new AntdUI.Checkbox();
            checkbox18 = new AntdUI.Checkbox();
            checkbox19 = new AntdUI.Checkbox();
            checkbox28 = new AntdUI.Checkbox();
            label5 = new AntdUI.Label();
            panel_engineerAuth = new AntdUI.Panel();
            checkbox8 = new AntdUI.Checkbox();
            checkbox7 = new AntdUI.Checkbox();
            checkbox6 = new AntdUI.Checkbox();
            checkbox5 = new AntdUI.Checkbox();
            checkbox4 = new AntdUI.Checkbox();
            checkbox1 = new AntdUI.Checkbox();
            checkbox27 = new AntdUI.Checkbox();
            label3 = new AntdUI.Label();
            panel_adminAuth = new AntdUI.Panel();
            checkbox9 = new AntdUI.Checkbox();
            checkbox15 = new AntdUI.Checkbox();
            checkbox10 = new AntdUI.Checkbox();
            checkbox11 = new AntdUI.Checkbox();
            checkbox12 = new AntdUI.Checkbox();
            checkbox13 = new AntdUI.Checkbox();
            checkbox14 = new AntdUI.Checkbox();
            checkbox26 = new AntdUI.Checkbox();
            label4 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            table_user = new AntdUI.Table();
            flowPanel2 = new AntdUI.FlowPanel();
            btn_removeBatch = new AntdUI.Button();
            btn_addUser = new AntdUI.Button();
            stackPanel1.SuspendLayout();
            panel3.SuspendLayout();
            flowPanel1.SuspendLayout();
            panel_visitorAuth.SuspendLayout();
            panel_operatorAuth.SuspendLayout();
            panel_engineerAuth.SuspendLayout();
            panel_adminAuth.SuspendLayout();
            flowPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(894, 36);
            label1.TabIndex = 1;
            label1.Text = "用户配置";
            // 
            // stackPanel1
            // 
            stackPanel1.Controls.Add(panel3);
            stackPanel1.Controls.Add(flowPanel1);
            stackPanel1.Controls.Add(label2);
            stackPanel1.Controls.Add(table_user);
            stackPanel1.Controls.Add(flowPanel2);
            stackPanel1.Controls.Add(label1);
            stackPanel1.Dock = DockStyle.Fill;
            stackPanel1.Location = new Point(0, 0);
            stackPanel1.Name = "stackPanel1";
            stackPanel1.Size = new Size(900, 700);
            stackPanel1.TabIndex = 2;
            stackPanel1.Text = "stackPanel1";
            stackPanel1.Vertical = true;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(btnSaveAuth);
            panel3.Location = new Point(3, 546);
            panel3.Name = "panel3";
            panel3.Size = new Size(894, 32);
            panel3.TabIndex = 9;
            // 
            // btnSaveAuth
            // 
            btnSaveAuth.Dock = DockStyle.Left;
            btnSaveAuth.Location = new Point(0, 0);
            btnSaveAuth.Name = "btnSaveAuth";
            btnSaveAuth.Size = new Size(96, 32);
            btnSaveAuth.TabIndex = 8;
            btnSaveAuth.Text = "保存权限";
            btnSaveAuth.Type = AntdUI.TTypeMini.Primary;
            btnSaveAuth.WaveSize = 1;
            btnSaveAuth.Click += btnSaveAuth_Click;
            // 
            // flowPanel1
            // 
            flowPanel1.Align = AntdUI.TAlignFlow.Center;
            flowPanel1.Controls.Add(panel_visitorAuth);
            flowPanel1.Controls.Add(panel_operatorAuth);
            flowPanel1.Controls.Add(panel_engineerAuth);
            flowPanel1.Controls.Add(panel_adminAuth);
            flowPanel1.Gap = 20;
            flowPanel1.Location = new Point(0, 336);
            flowPanel1.Margin = new Padding(0);
            flowPanel1.Name = "flowPanel1";
            flowPanel1.Size = new Size(900, 207);
            flowPanel1.TabIndex = 6;
            flowPanel1.Text = "flowPanel1";
            // 
            // panel_visitorAuth
            // 
            panel_visitorAuth.Controls.Add(checkbox20);
            panel_visitorAuth.Controls.Add(checkbox21);
            panel_visitorAuth.Controls.Add(checkbox22);
            panel_visitorAuth.Controls.Add(checkbox23);
            panel_visitorAuth.Controls.Add(checkbox24);
            panel_visitorAuth.Controls.Add(checkbox25);
            panel_visitorAuth.Controls.Add(checkbox29);
            panel_visitorAuth.Controls.Add(label6);
            panel_visitorAuth.Location = new Point(638, 3);
            panel_visitorAuth.Name = "panel_visitorAuth";
            panel_visitorAuth.Padding = new Padding(6);
            panel_visitorAuth.Shadow = 2;
            panel_visitorAuth.Size = new Size(140, 190);
            panel_visitorAuth.TabIndex = 9;
            panel_visitorAuth.Text = "panel1";
            // 
            // checkbox20
            // 
            checkbox20.Dock = DockStyle.Top;
            checkbox20.Location = new Point(8, 157);
            checkbox20.Name = "checkbox20";
            checkbox20.Size = new Size(124, 20);
            checkbox20.TabIndex = 9;
            checkbox20.Text = "系统参数";
            // 
            // checkbox21
            // 
            checkbox21.Dock = DockStyle.Top;
            checkbox21.Location = new Point(8, 137);
            checkbox21.Name = "checkbox21";
            checkbox21.Size = new Size(124, 20);
            checkbox21.TabIndex = 8;
            checkbox21.Text = "日志管理";
            // 
            // checkbox22
            // 
            checkbox22.Dock = DockStyle.Top;
            checkbox22.Location = new Point(8, 117);
            checkbox22.Name = "checkbox22";
            checkbox22.Size = new Size(124, 20);
            checkbox22.TabIndex = 7;
            checkbox22.Text = "报表管理";
            // 
            // checkbox23
            // 
            checkbox23.Dock = DockStyle.Top;
            checkbox23.Location = new Point(8, 97);
            checkbox23.Name = "checkbox23";
            checkbox23.Size = new Size(124, 20);
            checkbox23.TabIndex = 6;
            checkbox23.Text = "图表管理";
            // 
            // checkbox24
            // 
            checkbox24.Dock = DockStyle.Top;
            checkbox24.Location = new Point(8, 77);
            checkbox24.Name = "checkbox24";
            checkbox24.Size = new Size(124, 20);
            checkbox24.TabIndex = 5;
            checkbox24.Text = "配方管理";
            // 
            // checkbox25
            // 
            checkbox25.Dock = DockStyle.Top;
            checkbox25.Location = new Point(8, 57);
            checkbox25.Name = "checkbox25";
            checkbox25.Size = new Size(124, 20);
            checkbox25.TabIndex = 3;
            checkbox25.Text = "产线总控";
            // 
            // checkbox29
            // 
            checkbox29.Checked = true;
            checkbox29.Dock = DockStyle.Top;
            checkbox29.Enabled = false;
            checkbox29.Location = new Point(8, 37);
            checkbox29.Name = "checkbox29";
            checkbox29.Size = new Size(124, 20);
            checkbox29.TabIndex = 12;
            checkbox29.Text = "生产看板";
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Dock = DockStyle.Top;
            label6.Location = new Point(8, 8);
            label6.Name = "label6";
            label6.Size = new Size(124, 29);
            label6.TabIndex = 4;
            label6.Text = "访客权限";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_operatorAuth
            // 
            panel_operatorAuth.Controls.Add(checkbox2);
            panel_operatorAuth.Controls.Add(checkbox3);
            panel_operatorAuth.Controls.Add(checkbox16);
            panel_operatorAuth.Controls.Add(checkbox17);
            panel_operatorAuth.Controls.Add(checkbox18);
            panel_operatorAuth.Controls.Add(checkbox19);
            panel_operatorAuth.Controls.Add(checkbox28);
            panel_operatorAuth.Controls.Add(label5);
            panel_operatorAuth.Location = new Point(466, 3);
            panel_operatorAuth.Name = "panel_operatorAuth";
            panel_operatorAuth.Padding = new Padding(6);
            panel_operatorAuth.Shadow = 2;
            panel_operatorAuth.Size = new Size(140, 190);
            panel_operatorAuth.TabIndex = 8;
            panel_operatorAuth.Text = "panel1";
            // 
            // checkbox2
            // 
            checkbox2.Dock = DockStyle.Top;
            checkbox2.Location = new Point(8, 157);
            checkbox2.Name = "checkbox2";
            checkbox2.Size = new Size(124, 20);
            checkbox2.TabIndex = 9;
            checkbox2.Text = "系统参数";
            // 
            // checkbox3
            // 
            checkbox3.Dock = DockStyle.Top;
            checkbox3.Location = new Point(8, 137);
            checkbox3.Name = "checkbox3";
            checkbox3.Size = new Size(124, 20);
            checkbox3.TabIndex = 8;
            checkbox3.Text = "日志管理";
            // 
            // checkbox16
            // 
            checkbox16.Dock = DockStyle.Top;
            checkbox16.Location = new Point(8, 117);
            checkbox16.Name = "checkbox16";
            checkbox16.Size = new Size(124, 20);
            checkbox16.TabIndex = 7;
            checkbox16.Text = "报表管理";
            // 
            // checkbox17
            // 
            checkbox17.Dock = DockStyle.Top;
            checkbox17.Location = new Point(8, 97);
            checkbox17.Name = "checkbox17";
            checkbox17.Size = new Size(124, 20);
            checkbox17.TabIndex = 6;
            checkbox17.Text = "图表管理";
            // 
            // checkbox18
            // 
            checkbox18.Dock = DockStyle.Top;
            checkbox18.Location = new Point(8, 77);
            checkbox18.Name = "checkbox18";
            checkbox18.Size = new Size(124, 20);
            checkbox18.TabIndex = 5;
            checkbox18.Text = "配方管理";
            // 
            // checkbox19
            // 
            checkbox19.Dock = DockStyle.Top;
            checkbox19.Location = new Point(8, 57);
            checkbox19.Name = "checkbox19";
            checkbox19.Size = new Size(124, 20);
            checkbox19.TabIndex = 3;
            checkbox19.Text = "产线总控";
            // 
            // checkbox28
            // 
            checkbox28.Checked = true;
            checkbox28.Dock = DockStyle.Top;
            checkbox28.Enabled = false;
            checkbox28.Location = new Point(8, 37);
            checkbox28.Name = "checkbox28";
            checkbox28.Size = new Size(124, 20);
            checkbox28.TabIndex = 12;
            checkbox28.Text = "生产看板";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(8, 8);
            label5.Name = "label5";
            label5.Size = new Size(124, 29);
            label5.TabIndex = 4;
            label5.Text = "操作员权限";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_engineerAuth
            // 
            panel_engineerAuth.Controls.Add(checkbox8);
            panel_engineerAuth.Controls.Add(checkbox7);
            panel_engineerAuth.Controls.Add(checkbox6);
            panel_engineerAuth.Controls.Add(checkbox5);
            panel_engineerAuth.Controls.Add(checkbox4);
            panel_engineerAuth.Controls.Add(checkbox1);
            panel_engineerAuth.Controls.Add(checkbox27);
            panel_engineerAuth.Controls.Add(label3);
            panel_engineerAuth.Location = new Point(294, 3);
            panel_engineerAuth.Name = "panel_engineerAuth";
            panel_engineerAuth.Padding = new Padding(6);
            panel_engineerAuth.Shadow = 2;
            panel_engineerAuth.Size = new Size(140, 190);
            panel_engineerAuth.TabIndex = 4;
            panel_engineerAuth.Text = "panel1";
            // 
            // checkbox8
            // 
            checkbox8.Dock = DockStyle.Top;
            checkbox8.Location = new Point(8, 157);
            checkbox8.Name = "checkbox8";
            checkbox8.Size = new Size(124, 20);
            checkbox8.TabIndex = 9;
            checkbox8.Text = "系统参数";
            // 
            // checkbox7
            // 
            checkbox7.Dock = DockStyle.Top;
            checkbox7.Location = new Point(8, 137);
            checkbox7.Name = "checkbox7";
            checkbox7.Size = new Size(124, 20);
            checkbox7.TabIndex = 8;
            checkbox7.Text = "日志管理";
            // 
            // checkbox6
            // 
            checkbox6.Dock = DockStyle.Top;
            checkbox6.Location = new Point(8, 117);
            checkbox6.Name = "checkbox6";
            checkbox6.Size = new Size(124, 20);
            checkbox6.TabIndex = 7;
            checkbox6.Text = "报表管理";
            // 
            // checkbox5
            // 
            checkbox5.Dock = DockStyle.Top;
            checkbox5.Location = new Point(8, 97);
            checkbox5.Name = "checkbox5";
            checkbox5.Size = new Size(124, 20);
            checkbox5.TabIndex = 6;
            checkbox5.Text = "图表管理";
            // 
            // checkbox4
            // 
            checkbox4.Dock = DockStyle.Top;
            checkbox4.Location = new Point(8, 77);
            checkbox4.Name = "checkbox4";
            checkbox4.Size = new Size(124, 20);
            checkbox4.TabIndex = 5;
            checkbox4.Text = "配方管理";
            // 
            // checkbox1
            // 
            checkbox1.Dock = DockStyle.Top;
            checkbox1.Location = new Point(8, 57);
            checkbox1.Name = "checkbox1";
            checkbox1.Size = new Size(124, 20);
            checkbox1.TabIndex = 3;
            checkbox1.Text = "产线总控";
            // 
            // checkbox27
            // 
            checkbox27.Checked = true;
            checkbox27.Dock = DockStyle.Top;
            checkbox27.Enabled = false;
            checkbox27.Location = new Point(8, 37);
            checkbox27.Name = "checkbox27";
            checkbox27.Size = new Size(124, 20);
            checkbox27.TabIndex = 12;
            checkbox27.Text = "生产看板";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(8, 8);
            label3.Name = "label3";
            label3.Size = new Size(124, 29);
            label3.TabIndex = 4;
            label3.Text = "工程师权限";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_adminAuth
            // 
            panel_adminAuth.Controls.Add(checkbox9);
            panel_adminAuth.Controls.Add(checkbox15);
            panel_adminAuth.Controls.Add(checkbox10);
            panel_adminAuth.Controls.Add(checkbox11);
            panel_adminAuth.Controls.Add(checkbox12);
            panel_adminAuth.Controls.Add(checkbox13);
            panel_adminAuth.Controls.Add(checkbox14);
            panel_adminAuth.Controls.Add(checkbox26);
            panel_adminAuth.Controls.Add(label4);
            panel_adminAuth.Location = new Point(122, 3);
            panel_adminAuth.Name = "panel_adminAuth";
            panel_adminAuth.Padding = new Padding(6);
            panel_adminAuth.Shadow = 2;
            panel_adminAuth.Size = new Size(140, 200);
            panel_adminAuth.TabIndex = 7;
            panel_adminAuth.Text = "panel4";
            // 
            // checkbox9
            // 
            checkbox9.Checked = true;
            checkbox9.Dock = DockStyle.Top;
            checkbox9.Enabled = false;
            checkbox9.Location = new Point(8, 177);
            checkbox9.Name = "checkbox9";
            checkbox9.Size = new Size(124, 20);
            checkbox9.TabIndex = 9;
            checkbox9.Text = "系统参数";
            // 
            // checkbox15
            // 
            checkbox15.Checked = true;
            checkbox15.Dock = DockStyle.Top;
            checkbox15.Enabled = false;
            checkbox15.Location = new Point(8, 157);
            checkbox15.Name = "checkbox15";
            checkbox15.Size = new Size(124, 20);
            checkbox15.TabIndex = 10;
            checkbox15.Text = "用户管理";
            // 
            // checkbox10
            // 
            checkbox10.Checked = true;
            checkbox10.Dock = DockStyle.Top;
            checkbox10.Enabled = false;
            checkbox10.Location = new Point(8, 137);
            checkbox10.Name = "checkbox10";
            checkbox10.Size = new Size(124, 20);
            checkbox10.TabIndex = 8;
            checkbox10.Text = "日志管理";
            // 
            // checkbox11
            // 
            checkbox11.Checked = true;
            checkbox11.Dock = DockStyle.Top;
            checkbox11.Enabled = false;
            checkbox11.Location = new Point(8, 117);
            checkbox11.Name = "checkbox11";
            checkbox11.Size = new Size(124, 20);
            checkbox11.TabIndex = 7;
            checkbox11.Text = "报表管理";
            // 
            // checkbox12
            // 
            checkbox12.Checked = true;
            checkbox12.Dock = DockStyle.Top;
            checkbox12.Enabled = false;
            checkbox12.Location = new Point(8, 97);
            checkbox12.Name = "checkbox12";
            checkbox12.Size = new Size(124, 20);
            checkbox12.TabIndex = 6;
            checkbox12.Text = "图表管理";
            // 
            // checkbox13
            // 
            checkbox13.Checked = true;
            checkbox13.Dock = DockStyle.Top;
            checkbox13.Enabled = false;
            checkbox13.Location = new Point(8, 77);
            checkbox13.Name = "checkbox13";
            checkbox13.Size = new Size(124, 20);
            checkbox13.TabIndex = 5;
            checkbox13.Text = "配方管理";
            // 
            // checkbox14
            // 
            checkbox14.Checked = true;
            checkbox14.Dock = DockStyle.Top;
            checkbox14.Enabled = false;
            checkbox14.Location = new Point(8, 57);
            checkbox14.Name = "checkbox14";
            checkbox14.Size = new Size(124, 20);
            checkbox14.TabIndex = 3;
            checkbox14.Text = "产线总控";
            // 
            // checkbox26
            // 
            checkbox26.Checked = true;
            checkbox26.Dock = DockStyle.Top;
            checkbox26.Enabled = false;
            checkbox26.Location = new Point(8, 37);
            checkbox26.Name = "checkbox26";
            checkbox26.Size = new Size(124, 20);
            checkbox26.TabIndex = 11;
            checkbox26.Text = "生产看板";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(8, 8);
            label4.Name = "label4";
            label4.Size = new Size(124, 29);
            label4.TabIndex = 4;
            label4.Text = "管理员权限";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 297);
            label2.Name = "label2";
            label2.Size = new Size(894, 36);
            label2.TabIndex = 4;
            label2.Text = "权限配置";
            // 
            // table_user
            // 
            table_user.Bordered = true;
            table_user.Gap = 10;
            table_user.Location = new Point(3, 81);
            table_user.LostFocusClearSelection = true;
            table_user.Name = "table_user";
            table_user.Size = new Size(894, 210);
            table_user.TabIndex = 2;
            table_user.CellButtonClick += table_user_CellButtonClick;
            // 
            // flowPanel2
            // 
            flowPanel2.Controls.Add(btn_removeBatch);
            flowPanel2.Controls.Add(btn_addUser);
            flowPanel2.Location = new Point(0, 42);
            flowPanel2.Margin = new Padding(0);
            flowPanel2.Name = "flowPanel2";
            flowPanel2.Size = new Size(900, 36);
            flowPanel2.TabIndex = 7;
            flowPanel2.Text = "flowPanel2";
            // 
            // btn_removeBatch
            // 
            btn_removeBatch.Location = new Point(105, 3);
            btn_removeBatch.Name = "btn_removeBatch";
            btn_removeBatch.Size = new Size(96, 34);
            btn_removeBatch.TabIndex = 0;
            btn_removeBatch.Text = "批量删除";
            btn_removeBatch.Type = AntdUI.TTypeMini.Error;
            btn_removeBatch.WaveSize = 2;
            btn_removeBatch.Click += btn_removeBatch_Click;
            // 
            // btn_addUser
            // 
            btn_addUser.Location = new Point(3, 3);
            btn_addUser.Name = "btn_addUser";
            btn_addUser.Size = new Size(96, 34);
            btn_addUser.TabIndex = 1;
            btn_addUser.Text = "添加";
            btn_addUser.Type = AntdUI.TTypeMini.Primary;
            btn_addUser.WaveSize = 2;
            btn_addUser.Click += btn_addUser_ClickAsync;
            // 
            // ViewUserManage
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(stackPanel1);
            Name = "ViewUserManage";
            Size = new Size(900, 700);
            stackPanel1.ResumeLayout(false);
            stackPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            flowPanel1.ResumeLayout(false);
            panel_visitorAuth.ResumeLayout(false);
            panel_operatorAuth.ResumeLayout(false);
            panel_engineerAuth.ResumeLayout(false);
            panel_adminAuth.ResumeLayout(false);
            flowPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private AntdUI.Label label1;
        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Checkbox checkbox1;
        private AntdUI.Table table_user;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Panel panel_engineerAuth;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private AntdUI.Checkbox checkbox8;
        private AntdUI.Checkbox checkbox7;
        private AntdUI.Checkbox checkbox6;
        private AntdUI.Checkbox checkbox5;
        private AntdUI.Checkbox checkbox4;
        private AntdUI.Panel panel_adminAuth;
        private AntdUI.Checkbox checkbox9;
        private AntdUI.Checkbox checkbox15;
        private AntdUI.Checkbox checkbox10;
        private AntdUI.Checkbox checkbox11;
        private AntdUI.Checkbox checkbox12;
        private AntdUI.Checkbox checkbox13;
        private AntdUI.Checkbox checkbox14;
        private AntdUI.Label label4;
        private AntdUI.FlowPanel flowPanel2;
        private AntdUI.Button btn_removeBatch;
        private AntdUI.Button btn_addUser;
        private AntdUI.Button btnSaveAuth;
        private AntdUI.Panel panel_visitorAuth;
        private AntdUI.Checkbox checkbox20;
        private AntdUI.Checkbox checkbox21;
        private AntdUI.Checkbox checkbox22;
        private AntdUI.Checkbox checkbox23;
        private AntdUI.Checkbox checkbox24;
        private AntdUI.Checkbox checkbox25;
        private AntdUI.Label label6;
        private AntdUI.Panel panel_operatorAuth;
        private AntdUI.Checkbox checkbox2;
        private AntdUI.Checkbox checkbox3;
        private AntdUI.Checkbox checkbox16;
        private AntdUI.Checkbox checkbox17;
        private AntdUI.Checkbox checkbox18;
        private AntdUI.Checkbox checkbox19;
        private AntdUI.Label label5;
        private Panel panel3;
        private AntdUI.Checkbox checkbox29;
        private AntdUI.Checkbox checkbox28;
        private AntdUI.Checkbox checkbox27;
        private AntdUI.Checkbox checkbox26;
    }
}
