namespace SprayProcessSystem.UI.Views
{
    partial class ViewChartManage
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
            btn_query = new AntdUI.Button();
            dpr_chartDateRange = new AntdUI.DatePickerRange();
            lineChart_data = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            panel_legend = new AntdUI.StackPanel();
            stackPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // stackPanel1
            // 
            stackPanel1.Controls.Add(btn_query);
            stackPanel1.Controls.Add(dpr_chartDateRange);
            stackPanel1.Dock = DockStyle.Top;
            stackPanel1.Location = new Point(0, 0);
            stackPanel1.Name = "stackPanel1";
            stackPanel1.Size = new Size(790, 42);
            stackPanel1.TabIndex = 2;
            stackPanel1.Text = "stackPanel1";
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
            // dpr_chartDateRange
            // 
            dpr_chartDateRange.Location = new Point(3, 3);
            dpr_chartDateRange.Name = "dpr_chartDateRange";
            dpr_chartDateRange.PlaceholderEnd = "结束日期";
            dpr_chartDateRange.PlaceholderStart = "开始日期";
            dpr_chartDateRange.Presets.AddRange(new object[] { "今天", "近三天", "近一周", "近一月", "近三月", "近半年", "近一年" });
            dpr_chartDateRange.Size = new Size(277, 36);
            dpr_chartDateRange.TabIndex = 4;
            dpr_chartDateRange.WaveSize = 1;
            dpr_chartDateRange.ValueChanged += dpr_chartDateRange_ValueChanged;
            dpr_chartDateRange.PresetsClickChanged += dpr_chartDateRange_PresetsClickChanged;
            // 
            // lineChart_data
            // 
            lineChart_data.Dock = DockStyle.Fill;
            lineChart_data.Location = new Point(171, 42);
            lineChart_data.Name = "lineChart_data";
            lineChart_data.Size = new Size(619, 559);
            lineChart_data.TabIndex = 3;
            // 
            // panel_legend
            // 
            panel_legend.Dock = DockStyle.Left;
            panel_legend.Location = new Point(0, 42);
            panel_legend.Name = "panel_legend";
            panel_legend.Size = new Size(171, 559);
            panel_legend.TabIndex = 4;
            panel_legend.Text = "stackPanel2";
            panel_legend.Vertical = true;
            // 
            // ViewChartManage
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lineChart_data);
            Controls.Add(panel_legend);
            Controls.Add(stackPanel1);
            Name = "ViewChartManage";
            Size = new Size(790, 601);
            stackPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Button btn_query;
        private AntdUI.DatePickerRange dpr_chartDateRange;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart lineChart_data;
        private AntdUI.StackPanel panel_legend;
    }
}
