namespace SprayProcessSystem.UI.UserControls.Modals
{
    partial class ModalLogin
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
            flowPanel2 = new AntdUI.FlowPanel();
            btn_ok = new AntdUI.Button();
            btn_cancel = new AntdUI.Button();
            stackPanel5 = new AntdUI.StackPanel();
            txt_password = new AntdUI.Input();
            lbl_password = new AntdUI.Label();
            stackPanel1 = new AntdUI.StackPanel();
            txt_userName = new AntdUI.Input();
            label1 = new AntdUI.Label();
            flowPanel2.SuspendLayout();
            stackPanel5.SuspendLayout();
            stackPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowPanel2
            // 
            flowPanel2.Align = AntdUI.TAlignFlow.Center;
            flowPanel2.Controls.Add(btn_ok);
            flowPanel2.Controls.Add(btn_cancel);
            flowPanel2.Location = new Point(25, 155);
            flowPanel2.Margin = new Padding(0, 30, 0, 0);
            flowPanel2.Name = "flowPanel2";
            flowPanel2.Size = new Size(240, 38);
            flowPanel2.TabIndex = 0;
            flowPanel2.Text = "flowPanel2";
            // 
            // btn_ok
            // 
            btn_ok.BorderWidth = 1F;
            btn_ok.Location = new Point(131, 3);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(80, 32);
            btn_ok.TabIndex = 99;
            btn_ok.Text = "登录";
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
            btn_cancel.TabIndex = 99;
            btn_cancel.Text = "取消";
            btn_cancel.WaveSize = 1;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // stackPanel5
            // 
            stackPanel5.Controls.Add(txt_password);
            stackPanel5.Controls.Add(lbl_password);
            stackPanel5.Location = new Point(25, 85);
            stackPanel5.Margin = new Padding(0);
            stackPanel5.Name = "stackPanel5";
            stackPanel5.Size = new Size(235, 40);
            stackPanel5.TabIndex = 2;
            stackPanel5.Text = "stackPanel5";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(74, 3);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(161, 34);
            txt_password.TabIndex = 1;
            txt_password.WaveSize = 1;
            txt_password.KeyDown += txt_password_KeyDown;
            // 
            // lbl_password
            // 
            lbl_password.Location = new Point(3, 3);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(65, 34);
            lbl_password.TabIndex = 0;
            lbl_password.Text = "密码";
            // 
            // stackPanel1
            // 
            stackPanel1.Controls.Add(txt_userName);
            stackPanel1.Controls.Add(label1);
            stackPanel1.Location = new Point(25, 36);
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
            // label1
            // 
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(65, 34);
            label1.TabIndex = 0;
            label1.Text = "账号名";
            // 
            // ModalLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowPanel2);
            Controls.Add(stackPanel5);
            Controls.Add(stackPanel1);
            Name = "ModalLogin";
            Size = new Size(295, 232);
            flowPanel2.ResumeLayout(false);
            stackPanel5.ResumeLayout(false);
            stackPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.FlowPanel flowPanel2;
        private AntdUI.Button btn_ok;
        private AntdUI.Button btn_cancel;
        private AntdUI.StackPanel stackPanel5;
        private AntdUI.Input txt_password;
        private AntdUI.Label lbl_password;
        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Input txt_userName;
        private AntdUI.Label label1;
    }
}
