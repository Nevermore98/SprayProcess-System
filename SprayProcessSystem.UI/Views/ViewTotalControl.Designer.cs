namespace SprayProcessSystem.UI.Views
{
    partial class ViewTotalControl
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
            button1 = new AntdUI.Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(215, 122);
            button1.Name = "button1";
            button1.Size = new Size(118, 55);
            button1.TabIndex = 0;
            button1.Text = "总控";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(62, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 27);
            textBox1.TabIndex = 1;
            // 
            // ViewEquipmentControl
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "ViewEquipmentControl";
            Size = new Size(827, 600);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AntdUI.Button button1;
        private TextBox textBox1;
    }
}
