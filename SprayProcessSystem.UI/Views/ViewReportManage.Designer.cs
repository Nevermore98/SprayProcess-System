namespace SprayProcessSystem.UI.Views
{
    partial class ViewReportManage
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
            stackPanel1 = new AntdUI.StackPanel();
            btn_export = new AntdUI.Button();
            btn_query = new AntdUI.Button();
            dpr_dataDateRange = new AntdUI.DatePickerRange();
            pag_data = new AntdUI.Pagination();
            table_data = new AntdUI.Table();
            stackPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // stackPanel1
            // 
            stackPanel1.Controls.Add(btn_export);
            stackPanel1.Controls.Add(btn_query);
            stackPanel1.Controls.Add(dpr_dataDateRange);
            stackPanel1.Dock = DockStyle.Top;
            stackPanel1.Location = new Point(0, 0);
            stackPanel1.Name = "stackPanel1";
            stackPanel1.Size = new Size(868, 42);
            stackPanel1.TabIndex = 1;
            stackPanel1.Text = "stackPanel1";
            // 
            // btn_export
            // 
            btn_export.Location = new Point(388, 3);
            btn_export.Name = "btn_export";
            btn_export.Size = new Size(96, 36);
            btn_export.TabIndex = 2;
            btn_export.Text = "导出";
            btn_export.Type = AntdUI.TTypeMini.Primary;
            btn_export.WaveSize = 1;
            btn_export.Click += btn_export_Click;
            // 
            // btn_query
            // 
            btn_query.Location = new Point(286, 3);
            btn_query.Name = "btn_query";
            btn_query.Size = new Size(96, 36);
            btn_query.TabIndex = 1;
            btn_query.Text = "查询";
            btn_query.Type = AntdUI.TTypeMini.Primary;
            btn_query.WaveSize = 1;
            btn_query.Click += btn_query_Click;
            // 
            // dpr_dataDateRange
            // 
            dpr_dataDateRange.Location = new Point(3, 3);
            dpr_dataDateRange.Name = "dpr_dataDateRange";
            dpr_dataDateRange.PlaceholderEnd = "结束日期";
            dpr_dataDateRange.PlaceholderStart = "开始日期";
            dpr_dataDateRange.Presets.AddRange(new object[] { "今天", "近三天", "近一周", "近一月", "近三月", "近半年", "近一年" });
            dpr_dataDateRange.Size = new Size(277, 36);
            dpr_dataDateRange.TabIndex = 4;
            dpr_dataDateRange.WaveSize = 1;
            dpr_dataDateRange.ValueChanged += dpr_dataDateRange_ValueChanged;
            dpr_dataDateRange.PresetsClickChanged += dpr_dataDateRange_PresetsClickChanged;
            // 
            // pag_data
            // 
            pag_data.Current = 0;
            pag_data.Dock = DockStyle.Bottom;
            pag_data.Location = new Point(0, 569);
            pag_data.MaxPageTotal = 10;
            pag_data.Name = "pag_data";
            pag_data.PageSize = 0;
            pag_data.PageSizeOptions = new int[]
    {
    20,
    30,
    50,
    100,
    300,
    500
    };
            pag_data.ShowSizeChanger = true;
            pag_data.Size = new Size(868, 44);
            pag_data.SizeChangerWidth = 90;
            pag_data.TabIndex = 3;
            pag_data.Text = "pagination1";
            pag_data.ValueChanged += pag_data_ValueChanged;
            // 
            // table_data
            // 
            table_data.Bordered = true;
            table_data.Dock = DockStyle.Fill;
            table_data.Gap = 10;
            table_data.Location = new Point(0, 42);
            table_data.Name = "table_data";
            table_data.ShowTip = false;
            table_data.Size = new Size(868, 527);
            table_data.TabIndex = 4;
            table_data.Text = "table1";
            // 
            // ViewReportManage
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(table_data);
            Controls.Add(pag_data);
            Controls.Add(stackPanel1);
            Name = "ViewReportManage";
            Size = new Size(868, 613);
            stackPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Button btn_export;
        private AntdUI.Button btn_query;
        private AntdUI.DatePickerRange dpr_dataDateRange;
        private AntdUI.Pagination pag_data;
        private AntdUI.Table table_data;
    }
}
