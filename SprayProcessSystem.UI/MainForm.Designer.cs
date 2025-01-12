namespace SprayProcessSystem.UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pageHeader = new AntdUI.PageHeader();
            btn_devTool = new AntdUI.Button();
            dp_user = new AntdUI.Dropdown();
            menu = new AntdUI.Menu();
            panelContent = new AntdUI.Panel();
            pageHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pageHeader
            // 
            pageHeader.BackColor = Color.White;
            pageHeader.Controls.Add(btn_devTool);
            pageHeader.Controls.Add(dp_user);
            pageHeader.DividerShow = true;
            pageHeader.Dock = DockStyle.Top;
            pageHeader.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pageHeader.Icon = (Image)resources.GetObject("pageHeader.Icon");
            pageHeader.Location = new Point(0, 0);
            pageHeader.Margin = new Padding(0);
            pageHeader.MaximizeBox = false;
            pageHeader.Name = "pageHeader";
            pageHeader.Padding = new Padding(0, 0, 0, 1);
            pageHeader.ShowButton = true;
            pageHeader.ShowIcon = true;
            pageHeader.Size = new Size(1080, 40);
            pageHeader.TabIndex = 0;
            pageHeader.Text = "喷涂工艺 SCADA";
            // 
            // btn_devTool
            // 
            btn_devTool.AutoSizeMode = AntdUI.TAutoSize.Width;
            btn_devTool.Dock = DockStyle.Right;
            btn_devTool.Location = new Point(708, 0);
            btn_devTool.Margin = new Padding(4);
            btn_devTool.Name = "btn_devTool";
            btn_devTool.Padding = new Padding(2);
            btn_devTool.Size = new Size(138, 39);
            btn_devTool.TabIndex = 1;
            btn_devTool.Text = "开发者工具";
            btn_devTool.Visible = false;
            btn_devTool.WaveSize = 0;
            // 
            // dp_user
            // 
            dp_user.AutoSizeMode = AntdUI.TAutoSize.Width;
            dp_user.Dock = DockStyle.Right;
            dp_user.IconRatio = 1F;
            dp_user.IconSvg = resources.GetString("dp_user.IconSvg");
            dp_user.Location = new Point(846, 0);
            dp_user.Margin = new Padding(4, 4, 6, 6);
            dp_user.Name = "dp_user";
            dp_user.Size = new Size(110, 39);
            dp_user.TabIndex = 0;
            dp_user.Text = "登录";
            dp_user.WaveSize = 0;
            // 
            // menu
            // 
            menu.BackColor = SystemColors.Control;
            menu.Dock = DockStyle.Left;
            menu.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            menu.Indent = true;
            menu.Location = new Point(0, 40);
            menu.Margin = new Padding(3, 4, 3, 4);
            menu.Name = "menu";
            menu.Size = new Size(180, 720);
            menu.TabIndex = 0;
            menu.Text = "menu1";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(180, 40);
            panelContent.Margin = new Padding(3, 4, 3, 4);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(13, 12, 13, 12);
            panelContent.Size = new Size(900, 720);
            panelContent.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 760);
            Controls.Add(panelContent);
            Controls.Add(menu);
            Controls.Add(pageHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "喷涂工艺 SCADA";
            pageHeader.ResumeLayout(false);
            pageHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.PageHeader pageHeader;
        private AntdUI.Menu menu;
        private AntdUI.Panel panelContent;
        private AntdUI.Dropdown dp_user;
        private AntdUI.Button btn_devTool;
    }
}
