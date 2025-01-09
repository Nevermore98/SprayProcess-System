namespace SprayProcessSystem.UI.UserControls.Modals
{
    partial class ModalUserEdit
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
            txt_userName = new AntdUI.Input();
            flowPanel1 = new AntdUI.FlowPanel();
            flowPanel2 = new AntdUI.FlowPanel();
            btn_ok = new AntdUI.Button();
            btn_cancel = new AntdUI.Button();
            stackPanel4 = new AntdUI.StackPanel();
            switch_enabled = new AntdUI.Switch();
            label4 = new AntdUI.Label();
            stackPanel5 = new AntdUI.StackPanel();
            txt_password = new AntdUI.Input();
            lbl_password = new AntdUI.Label();
            stackPanel3 = new AntdUI.StackPanel();
            select_role = new AntdUI.Select();
            label3 = new AntdUI.Label();
            stackPanel2 = new AntdUI.StackPanel();
            txt_nickName = new AntdUI.Input();
            label2 = new AntdUI.Label();
            stackPanel1.SuspendLayout();
            flowPanel1.SuspendLayout();
            flowPanel2.SuspendLayout();
            stackPanel4.SuspendLayout();
            stackPanel5.SuspendLayout();
            stackPanel3.SuspendLayout();
            stackPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(65, 34);
            label1.TabIndex = 0;
            label1.Text = "账号名";
            // 
            // stackPanel1
            // 
            stackPanel1.Controls.Add(txt_userName);
            stackPanel1.Controls.Add(label1);
            stackPanel1.Location = new Point(26, 0);
            stackPanel1.Margin = new Padding(0);
            stackPanel1.Name = "stackPanel1";
            stackPanel1.Size = new Size(235, 40);
            stackPanel1.TabIndex = 1;
            stackPanel1.Text = "stackPanel1";
            // 
            // txt_userName
            // 
            txt_userName.Location = new Point(74, 3);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(161, 34);
            txt_userName.TabIndex = 1;
            txt_userName.WaveSize = 1;
            // 
            // flowPanel1
            // 
            flowPanel1.Align = AntdUI.TAlignFlow.Center;
            flowPanel1.Controls.Add(flowPanel2);
            flowPanel1.Controls.Add(stackPanel4);
            flowPanel1.Controls.Add(stackPanel5);
            flowPanel1.Controls.Add(stackPanel3);
            flowPanel1.Controls.Add(stackPanel2);
            flowPanel1.Controls.Add(stackPanel1);
            flowPanel1.Dock = DockStyle.Fill;
            flowPanel1.Location = new Point(0, 0);
            flowPanel1.Margin = new Padding(0);
            flowPanel1.Name = "flowPanel1";
            flowPanel1.Padding = new Padding(0, 0, 12, 0);
            flowPanel1.Size = new Size(300, 350);
            flowPanel1.TabIndex = 0;
            flowPanel1.Text = "flowPanel1";
            // 
            // flowPanel2
            // 
            flowPanel2.Align = AntdUI.TAlignFlow.Center;
            flowPanel2.Controls.Add(btn_ok);
            flowPanel2.Controls.Add(btn_cancel);
            flowPanel2.Location = new Point(24, 262);
            flowPanel2.Margin = new Padding(0, 30, 0, 0);
            flowPanel2.Name = "flowPanel2";
            flowPanel2.Size = new Size(240, 38);
            flowPanel2.TabIndex = 6;
            flowPanel2.Text = "flowPanel2";
            // 
            // btn_ok
            // 
            btn_ok.BorderWidth = 1F;
            btn_ok.Location = new Point(131, 3);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(80, 32);
            btn_ok.TabIndex = 0;
            btn_ok.Text = "确定";
            btn_ok.Type = AntdUI.TTypeMini.Primary;
            btn_ok.WaveSize = 1;
            btn_ok.Click += btn_ok_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.BorderWidth = 1F;
            btn_cancel.Location = new Point(28, 3);
            btn_cancel.Margin = new Padding(3, 3, 20, 3);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(80, 32);
            btn_cancel.TabIndex = 0;
            btn_cancel.Text = "取消";
            btn_cancel.WaveSize = 1;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // stackPanel4
            // 
            stackPanel4.Controls.Add(switch_enabled);
            stackPanel4.Controls.Add(label4);
            stackPanel4.Location = new Point(26, 167);
            stackPanel4.Margin = new Padding(0, 3, 0, 0);
            stackPanel4.Name = "stackPanel4";
            stackPanel4.Size = new Size(235, 41);
            stackPanel4.TabIndex = 5;
            stackPanel4.Text = "stackPanel4";
            // 
            // switch_enabled
            // 
            switch_enabled.Location = new Point(77, 6);
            switch_enabled.Margin = new Padding(6);
            switch_enabled.Name = "switch_enabled";
            switch_enabled.Size = new Size(40, 29);
            switch_enabled.TabIndex = 0;
            switch_enabled.Text = "switch1";
            // 
            // label4
            // 
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(65, 35);
            label4.TabIndex = 0;
            label4.Text = "是否启用";
            // 
            // stackPanel5
            // 
            stackPanel5.Controls.Add(txt_password);
            stackPanel5.Controls.Add(lbl_password);
            stackPanel5.Location = new Point(26, 120);
            stackPanel5.Margin = new Padding(0);
            stackPanel5.Name = "stackPanel5";
            stackPanel5.Size = new Size(235, 40);
            stackPanel5.TabIndex = 4;
            stackPanel5.Text = "stackPanel5";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(74, 3);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(161, 34);
            txt_password.TabIndex = 3;
            txt_password.WaveSize = 1;
            // 
            // lbl_password
            // 
            lbl_password.Location = new Point(3, 3);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(65, 34);
            lbl_password.TabIndex = 0;
            lbl_password.Text = "密码";
            // 
            // stackPanel3
            // 
            stackPanel3.Controls.Add(select_role);
            stackPanel3.Controls.Add(label3);
            stackPanel3.Location = new Point(26, 80);
            stackPanel3.Margin = new Padding(0);
            stackPanel3.Name = "stackPanel3";
            stackPanel3.Size = new Size(235, 40);
            stackPanel3.TabIndex = 3;
            stackPanel3.Text = "stackPanel3";
            // 
            // select_role
            // 
            select_role.List = true;
            select_role.Location = new Point(74, 3);
            select_role.Name = "select_role";
            select_role.Size = new Size(161, 34);
            select_role.TabIndex = 0;
            select_role.WaveSize = 1;
            // 
            // label3
            // 
            label3.Location = new Point(3, 3);
            label3.Name = "label3";
            label3.Size = new Size(65, 34);
            label3.TabIndex = 0;
            label3.Text = "角色";
            // 
            // stackPanel2
            // 
            stackPanel2.Controls.Add(txt_nickName);
            stackPanel2.Controls.Add(label2);
            stackPanel2.Location = new Point(26, 40);
            stackPanel2.Margin = new Padding(0);
            stackPanel2.Name = "stackPanel2";
            stackPanel2.Size = new Size(235, 40);
            stackPanel2.TabIndex = 2;
            stackPanel2.Text = "stackPanel2";
            // 
            // txt_nickName
            // 
            txt_nickName.Location = new Point(74, 3);
            txt_nickName.Name = "txt_nickName";
            txt_nickName.Size = new Size(161, 34);
            txt_nickName.TabIndex = 2;
            txt_nickName.WaveSize = 1;
            // 
            // label2
            // 
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(65, 34);
            label2.TabIndex = 0;
            label2.Text = "昵称";
            // 
            // ModalUserEdit
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowPanel1);
            Margin = new Padding(0);
            Name = "ModalUserEdit";
            Size = new Size(300, 350);
            stackPanel1.ResumeLayout(false);
            flowPanel1.ResumeLayout(false);
            flowPanel2.ResumeLayout(false);
            stackPanel4.ResumeLayout(false);
            stackPanel5.ResumeLayout(false);
            stackPanel3.ResumeLayout(false);
            stackPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Input txt_userName;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.StackPanel stackPanel3;
        private AntdUI.Select select_role;
        private AntdUI.Label label3;
        private AntdUI.StackPanel stackPanel2;
        private AntdUI.Input txt_nickName;
        private AntdUI.Label label2;
        private AntdUI.Button btn_cancel;
        private AntdUI.FlowPanel flowPanel2;
        private AntdUI.Button btn_ok;
        private AntdUI.StackPanel stackPanel4;
        private AntdUI.Switch switch_enabled;
        private AntdUI.Label label4;
        private AntdUI.StackPanel stackPanel5;
        private AntdUI.Input txt_password;
        private AntdUI.Label lbl_password;
    }
}
