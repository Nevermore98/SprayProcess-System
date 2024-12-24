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
            menu = new AntdUI.Menu();
            panelContent = new AntdUI.Panel();
            SuspendLayout();
            // 
            // pageHeader
            // 
            pageHeader.BackColor = Color.White;
            pageHeader.Dock = DockStyle.Top;
            pageHeader.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            pageHeader.Icon = (Image)resources.GetObject("pageHeader.Icon");
            pageHeader.Location = new Point(0, 0);
            pageHeader.Name = "pageHeader";
            pageHeader.ShowButton = true;
            pageHeader.ShowIcon = true;
            pageHeader.Size = new Size(800, 32);
            pageHeader.TabIndex = 0;
            pageHeader.Text = "喷涂工艺 SCADA";
            // 
            // menu
            // 
            menu.Dock = DockStyle.Left;
            menu.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            menu.Indent = true;
            menu.Location = new Point(0, 32);
            menu.Name = "menu";
            menu.Size = new Size(176, 418);
            menu.TabIndex = 0;
            menu.Text = "menu1";
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(176, 32);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(624, 418);
            panelContent.TabIndex = 1;
            panelContent.Text = "panel1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContent);
            Controls.Add(menu);
            Controls.Add(pageHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.PageHeader pageHeader;
        private AntdUI.Menu menu;
        private AntdUI.Panel panelContent;
    }
}
