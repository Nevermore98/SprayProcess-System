namespace SprayProcessSystem.UI.Views
{
    partial class ViewLogManage
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(276, 228);
            label1.Name = "label1";
            label1.Size = new Size(96, 29);
            label1.TabIndex = 1;
            label1.Text = "日志";
            // 
            // ViewLogManage
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Name = "ViewLogManage";
            Size = new Size(649, 485);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
    }
}
