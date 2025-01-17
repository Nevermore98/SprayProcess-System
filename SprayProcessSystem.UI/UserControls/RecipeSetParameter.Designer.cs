namespace SprayProcessSystem.UI.UserControls
{
    partial class RecipeSetParameter
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
            gridPanel1 = new AntdUI.GridPanel();
            lbl_unit = new AntdUI.Label();
            txt_value = new AntdUI.InputNumber();
            lbl_name = new AntdUI.Label();
            gridPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // gridPanel1
            // 
            gridPanel1.Controls.Add(lbl_unit);
            gridPanel1.Controls.Add(txt_value);
            gridPanel1.Controls.Add(lbl_name);
            gridPanel1.Dock = DockStyle.Fill;
            gridPanel1.Location = new Point(0, 0);
            gridPanel1.Name = "gridPanel1";
            gridPanel1.Size = new Size(284, 53);
            gridPanel1.Span = "100% 90 40;";
            gridPanel1.TabIndex = 0;
            gridPanel1.Text = "gridPanel1";
            // 
            // lbl_unit
            // 
            lbl_unit.Location = new Point(233, 0);
            lbl_unit.Margin = new Padding(0);
            lbl_unit.Name = "lbl_unit";
            lbl_unit.Size = new Size(51, 53);
            lbl_unit.TabIndex = 2;
            lbl_unit.Text = "单位";
            // 
            // txt_value
            // 
            txt_value.DecimalPlaces = 1;
            txt_value.Location = new Point(121, 3);
            txt_value.Name = "txt_value";
            txt_value.Size = new Size(109, 47);
            txt_value.TabIndex = 3;
            txt_value.Text = "0.0";
            txt_value.WaveSize = 1;
            txt_value.TextChanged += txt_value_TextChanged;
            // 
            // lbl_name
            // 
            lbl_name.Location = new Point(0, 0);
            lbl_name.Margin = new Padding(0);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(118, 53);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "参数名称";
            // 
            // RecipeSetParameter
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridPanel1);
            Name = "RecipeSetParameter";
            Size = new Size(284, 53);
            gridPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.GridPanel gridPanel1;
        private AntdUI.Label lbl_unit;
        private AntdUI.Label lbl_name;
        private AntdUI.InputNumber txt_value;
    }
}
