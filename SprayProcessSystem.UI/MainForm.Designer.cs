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
            flowPanel1 = new AntdUI.FlowPanel();
            dropdown1 = new AntdUI.Dropdown();
            menu = new AntdUI.Menu();
            panelContent = new AntdUI.Panel();
            pageHeader.SuspendLayout();
            flowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pageHeader
            // 
            pageHeader.BackColor = Color.White;
            pageHeader.Controls.Add(flowPanel1);
            pageHeader.DividerShow = true;
            pageHeader.Dock = DockStyle.Top;
            pageHeader.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pageHeader.Icon = (Image)resources.GetObject("pageHeader.Icon");
            pageHeader.Location = new Point(0, 0);
            pageHeader.Margin = new Padding(0);
            pageHeader.MaximizeBox = false;
            pageHeader.Name = "pageHeader";
            pageHeader.ShowButton = true;
            pageHeader.ShowIcon = true;
            pageHeader.Size = new Size(1080, 40);
            pageHeader.TabIndex = 0;
            pageHeader.Text = "喷涂工艺 SCADA";
            // 
            // flowPanel1
            // 
            flowPanel1.Align = AntdUI.TAlignFlow.RightCenter;
            flowPanel1.BackColor = Color.Transparent;
            flowPanel1.Controls.Add(dropdown1);
            flowPanel1.Dock = DockStyle.Right;
            flowPanel1.Location = new Point(815, 0);
            flowPanel1.Margin = new Padding(3, 4, 3, 4);
            flowPanel1.Name = "flowPanel1";
            flowPanel1.Size = new Size(141, 40);
            flowPanel1.TabIndex = 4;
            flowPanel1.Text = "flowPanel1";
            // 
            // dropdown1
            // 
            dropdown1.Dock = DockStyle.Right;
            dropdown1.IconRatio = 0.9F;
            dropdown1.IconSvg = resources.GetString("dropdown1.IconSvg");
            dropdown1.Location = new Point(6, 4);
            dropdown1.Margin = new Padding(3, 4, 3, 4);
            dropdown1.Name = "dropdown1";
            dropdown1.ShowArrow = true;
            dropdown1.Size = new Size(132, 34);
            dropdown1.TabIndex = 0;
            dropdown1.Text = "Admin";
            dropdown1.WaveSize = 0;
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
            menu.Size = new Size(180, 810);
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
            panelContent.Size = new Size(900, 810);
            panelContent.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 850);
            Controls.Add(panelContent);
            Controls.Add(menu);
            Controls.Add(pageHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Resizable = false;
            Text = "Form1";
            pageHeader.ResumeLayout(false);
            flowPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.PageHeader pageHeader;
        private AntdUI.Menu menu;
        private AntdUI.Panel panelContent;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Dropdown dropdown1;
    }
}
