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
            gridPanel1 = new AntdUI.GridPanel();
            table_log = new AntdUI.Table();
            panel1 = new AntdUI.Panel();
            stackPanel1 = new AntdUI.StackPanel();
            btn_exportExcel = new AntdUI.Button();
            btn_exportTxt = new AntdUI.Button();
            btn_openDir = new AntdUI.Button();
            stackPanel4 = new AntdUI.StackPanel();
            cmb_level = new AntdUI.Select();
            label3 = new AntdUI.Label();
            stackPanel3 = new AntdUI.StackPanel();
            cmb_day = new AntdUI.Select();
            label2 = new AntdUI.Label();
            stackPanel2 = new AntdUI.StackPanel();
            cmb_yearMonth = new AntdUI.Select();
            label1 = new AntdUI.Label();
            gridPanel1.SuspendLayout();
            panel1.SuspendLayout();
            stackPanel1.SuspendLayout();
            stackPanel4.SuspendLayout();
            stackPanel3.SuspendLayout();
            stackPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // gridPanel1
            // 
            gridPanel1.Controls.Add(table_log);
            gridPanel1.Controls.Add(panel1);
            gridPanel1.Dock = DockStyle.Fill;
            gridPanel1.Location = new Point(0, 0);
            gridPanel1.Name = "gridPanel1";
            gridPanel1.Size = new Size(854, 561);
            gridPanel1.Span = "200 100%;";
            gridPanel1.TabIndex = 0;
            gridPanel1.Text = "gridPanel1";
            // 
            // table_log
            // 
            table_log.Bordered = true;
            table_log.Dock = DockStyle.Fill;
            table_log.Gap = 10;
            table_log.Location = new Point(259, 3);
            table_log.Name = "table_log";
            table_log.ShowTip = false;
            table_log.Size = new Size(592, 555);
            table_log.TabIndex = 1;
            table_log.Text = "table1";
            // 
            // panel1
            // 
            panel1.BorderWidth = 1F;
            panel1.Controls.Add(stackPanel1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(4);
            panel1.Size = new Size(250, 555);
            panel1.TabIndex = 0;
            panel1.Text = "panel1";
            // 
            // stackPanel1
            // 
            stackPanel1.Controls.Add(btn_exportExcel);
            stackPanel1.Controls.Add(btn_exportTxt);
            stackPanel1.Controls.Add(btn_openDir);
            stackPanel1.Controls.Add(stackPanel4);
            stackPanel1.Controls.Add(stackPanel3);
            stackPanel1.Controls.Add(stackPanel2);
            stackPanel1.Dock = DockStyle.Fill;
            stackPanel1.Location = new Point(6, 6);
            stackPanel1.Name = "stackPanel1";
            stackPanel1.Size = new Size(238, 543);
            stackPanel1.TabIndex = 5;
            stackPanel1.Text = "stackPanel1";
            stackPanel1.Vertical = true;
            // 
            // btn_exportExcel
            // 
            btn_exportExcel.Location = new Point(3, 211);
            btn_exportExcel.Name = "btn_exportExcel";
            btn_exportExcel.Size = new Size(232, 35);
            btn_exportExcel.TabIndex = 4;
            btn_exportExcel.Text = "导出为 excel";
            btn_exportExcel.Type = AntdUI.TTypeMini.Primary;
            btn_exportExcel.WaveSize = 1;
            // 
            // btn_exportTxt
            // 
            btn_exportTxt.Location = new Point(3, 170);
            btn_exportTxt.Name = "btn_exportTxt";
            btn_exportTxt.Size = new Size(232, 35);
            btn_exportTxt.TabIndex = 3;
            btn_exportTxt.Text = "导出为 txt";
            btn_exportTxt.Type = AntdUI.TTypeMini.Primary;
            btn_exportTxt.WaveSize = 1;
            // 
            // btn_openDir
            // 
            btn_openDir.Location = new Point(3, 129);
            btn_openDir.Name = "btn_openDir";
            btn_openDir.Size = new Size(232, 35);
            btn_openDir.TabIndex = 2;
            btn_openDir.Text = "打开日志所在目录";
            btn_openDir.Type = AntdUI.TTypeMini.Primary;
            btn_openDir.WaveSize = 1;
            // 
            // stackPanel4
            // 
            stackPanel4.Controls.Add(cmb_level);
            stackPanel4.Controls.Add(label3);
            stackPanel4.Location = new Point(0, 84);
            stackPanel4.Margin = new Padding(0);
            stackPanel4.Name = "stackPanel4";
            stackPanel4.Size = new Size(238, 42);
            stackPanel4.TabIndex = 9;
            stackPanel4.Text = "stackPanel4";
            // 
            // cmb_level
            // 
            cmb_level.List = true;
            cmb_level.Location = new Point(43, 3);
            cmb_level.MaxCount = 10;
            cmb_level.Name = "cmb_level";
            cmb_level.Size = new Size(92, 36);
            cmb_level.TabIndex = 0;
            cmb_level.Text = "选择级别";
            cmb_level.WaveSize = 1;
            // 
            // label3
            // 
            label3.Location = new Point(3, 0);
            label3.Margin = new Padding(3, 0, 0, 0);
            label3.Name = "label3";
            label3.Size = new Size(37, 42);
            label3.TabIndex = 6;
            label3.Text = "级别";
            // 
            // stackPanel3
            // 
            stackPanel3.Controls.Add(cmb_day);
            stackPanel3.Controls.Add(label2);
            stackPanel3.Location = new Point(0, 42);
            stackPanel3.Margin = new Padding(0);
            stackPanel3.Name = "stackPanel3";
            stackPanel3.Size = new Size(238, 42);
            stackPanel3.TabIndex = 8;
            stackPanel3.Text = "stackPanel3";
            // 
            // cmb_day
            // 
            cmb_day.List = true;
            cmb_day.Location = new Point(43, 3);
            cmb_day.MaxCount = 10;
            cmb_day.Name = "cmb_day";
            cmb_day.Size = new Size(92, 36);
            cmb_day.TabIndex = 0;
            cmb_day.Text = "选择日期";
            cmb_day.WaveSize = 1;
            // 
            // label2
            // 
            label2.Location = new Point(3, 0);
            label2.Margin = new Padding(3, 0, 0, 0);
            label2.Name = "label2";
            label2.Size = new Size(37, 42);
            label2.TabIndex = 6;
            label2.Text = "日期";
            // 
            // stackPanel2
            // 
            stackPanel2.Controls.Add(cmb_yearMonth);
            stackPanel2.Controls.Add(label1);
            stackPanel2.Location = new Point(0, 0);
            stackPanel2.Margin = new Padding(0);
            stackPanel2.Name = "stackPanel2";
            stackPanel2.Size = new Size(238, 42);
            stackPanel2.TabIndex = 7;
            stackPanel2.Text = "stackPanel2";
            // 
            // cmb_yearMonth
            // 
            cmb_yearMonth.List = true;
            cmb_yearMonth.Location = new Point(43, 3);
            cmb_yearMonth.MaxCount = 10;
            cmb_yearMonth.Name = "cmb_yearMonth";
            cmb_yearMonth.Size = new Size(92, 36);
            cmb_yearMonth.TabIndex = 0;
            cmb_yearMonth.Text = "选择年月";
            cmb_yearMonth.WaveSize = 1;
            // 
            // label1
            // 
            label1.Location = new Point(3, 0);
            label1.Margin = new Padding(3, 0, 0, 0);
            label1.Name = "label1";
            label1.Size = new Size(37, 42);
            label1.TabIndex = 6;
            label1.Text = "年月";
            // 
            // ViewLogManage
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridPanel1);
            Name = "ViewLogManage";
            Size = new Size(854, 561);
            gridPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            stackPanel1.ResumeLayout(false);
            stackPanel4.ResumeLayout(false);
            stackPanel3.ResumeLayout(false);
            stackPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.GridPanel gridPanel1;
        private AntdUI.Table table_log;
        private AntdUI.Panel panel1;
        private AntdUI.Select cmb_yearMonth;
        private AntdUI.Button btn_openDir;
        private AntdUI.Button btn_exportTxt;
        private AntdUI.Button btn_exportExcel;
        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Select cmb_day;
        private AntdUI.StackPanel stackPanel3;
        private AntdUI.Label label2;
        private AntdUI.StackPanel stackPanel2;
        private AntdUI.Label label1;
        private AntdUI.StackPanel stackPanel4;
        private AntdUI.Select cmb_level;
        private AntdUI.Label label3;
    }
}
