namespace SprayProcessSystem.UI.Views
{
    partial class ViewRecipeManage
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
            panel_recipeDetail = new AntdUI.Panel();
            lbl_updatedAt = new AntdUI.Label();
            lbl_createdAt = new AntdUI.Label();
            recipeSetParameter14 = new UserControls.RecipeSetParameter();
            recipeSetParameter13 = new UserControls.RecipeSetParameter();
            recipeSetParameter12 = new UserControls.RecipeSetParameter();
            recipeSetParameter11 = new UserControls.RecipeSetParameter();
            recipeSetParameter10 = new UserControls.RecipeSetParameter();
            recipeSetParameter9 = new UserControls.RecipeSetParameter();
            recipeSetParameter8 = new UserControls.RecipeSetParameter();
            recipeSetParameter7 = new UserControls.RecipeSetParameter();
            recipeSetParameter6 = new UserControls.RecipeSetParameter();
            recipeSetParameter5 = new UserControls.RecipeSetParameter();
            recipeSetParameter4 = new UserControls.RecipeSetParameter();
            recipeSetParameter3 = new UserControls.RecipeSetParameter();
            recipeSetParameter2 = new UserControls.RecipeSetParameter();
            recipeSetParameter1 = new UserControls.RecipeSetParameter();
            flowPanel1 = new AntdUI.FlowPanel();
            btn_delete = new AntdUI.Button();
            btn_save = new AntdUI.Button();
            btn_download = new AntdUI.Button();
            panel4 = new AntdUI.Panel();
            table_recipe = new AntdUI.Table();
            panel3 = new AntdUI.Panel();
            btn_export = new AntdUI.Button();
            btn_add = new AntdUI.Button();
            btn_refresh = new AntdUI.Button();
            btn_import = new AntdUI.Button();
            gridPanel1.SuspendLayout();
            panel_recipeDetail.SuspendLayout();
            flowPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // gridPanel1
            // 
            gridPanel1.Controls.Add(panel_recipeDetail);
            gridPanel1.Controls.Add(panel4);
            gridPanel1.Dock = DockStyle.Fill;
            gridPanel1.Location = new Point(0, 0);
            gridPanel1.Margin = new Padding(0);
            gridPanel1.Name = "gridPanel1";
            gridPanel1.Size = new Size(869, 558);
            gridPanel1.Span = "200 100%;";
            gridPanel1.TabIndex = 3;
            gridPanel1.Text = "gridPanel1";
            // 
            // panel_recipeDetail
            // 
            panel_recipeDetail.BorderWidth = 1F;
            panel_recipeDetail.Controls.Add(lbl_updatedAt);
            panel_recipeDetail.Controls.Add(lbl_createdAt);
            panel_recipeDetail.Controls.Add(recipeSetParameter14);
            panel_recipeDetail.Controls.Add(recipeSetParameter13);
            panel_recipeDetail.Controls.Add(recipeSetParameter12);
            panel_recipeDetail.Controls.Add(recipeSetParameter11);
            panel_recipeDetail.Controls.Add(recipeSetParameter10);
            panel_recipeDetail.Controls.Add(recipeSetParameter9);
            panel_recipeDetail.Controls.Add(recipeSetParameter8);
            panel_recipeDetail.Controls.Add(recipeSetParameter7);
            panel_recipeDetail.Controls.Add(recipeSetParameter6);
            panel_recipeDetail.Controls.Add(recipeSetParameter5);
            panel_recipeDetail.Controls.Add(recipeSetParameter4);
            panel_recipeDetail.Controls.Add(recipeSetParameter3);
            panel_recipeDetail.Controls.Add(recipeSetParameter2);
            panel_recipeDetail.Controls.Add(recipeSetParameter1);
            panel_recipeDetail.Controls.Add(flowPanel1);
            panel_recipeDetail.Location = new Point(259, 3);
            panel_recipeDetail.Name = "panel_recipeDetail";
            panel_recipeDetail.Size = new Size(607, 552);
            panel_recipeDetail.TabIndex = 0;
            panel_recipeDetail.Text = "panel2";
            panel_recipeDetail.Visible = false;
            // 
            // lbl_updatedAt
            // 
            lbl_updatedAt.Font = new Font("Microsoft YaHei UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_updatedAt.Location = new Point(13, 495);
            lbl_updatedAt.Name = "lbl_updatedAt";
            lbl_updatedAt.Size = new Size(230, 26);
            lbl_updatedAt.TabIndex = 24;
            lbl_updatedAt.Text = "更新日期：";
            // 
            // lbl_createdAt
            // 
            lbl_createdAt.Font = new Font("Microsoft YaHei UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_createdAt.Location = new Point(13, 474);
            lbl_createdAt.Name = "lbl_createdAt";
            lbl_createdAt.Size = new Size(230, 26);
            lbl_createdAt.TabIndex = 23;
            lbl_createdAt.Text = "创建日期：";
            // 
            // recipeSetParameter14
            // 
            recipeSetParameter14.Increment = 1;
            recipeSetParameter14.Location = new Point(261, 421);
            recipeSetParameter14.Name = "recipeSetParameter14";
            recipeSetParameter14.ParameterName = "输送机设定频率";
            recipeSetParameter14.ParameterUnit = "Mpa";
            recipeSetParameter14.ParameterValue = "0";
            recipeSetParameter14.Size = new Size(230, 35);
            recipeSetParameter14.TabIndex = 22;
            // 
            // recipeSetParameter13
            // 
            recipeSetParameter13.Increment = 1;
            recipeSetParameter13.Location = new Point(13, 421);
            recipeSetParameter13.Name = "recipeSetParameter13";
            recipeSetParameter13.ParameterName = "输送机设定速度";
            recipeSetParameter13.ParameterUnit = "Mpa";
            recipeSetParameter13.ParameterValue = "0";
            recipeSetParameter13.Size = new Size(230, 35);
            recipeSetParameter13.TabIndex = 21;
            // 
            // recipeSetParameter12
            // 
            recipeSetParameter12.Increment = 1;
            recipeSetParameter12.Location = new Point(261, 363);
            recipeSetParameter12.Name = "recipeSetParameter12";
            recipeSetParameter12.ParameterName = "固化炉温度下限值";
            recipeSetParameter12.ParameterUnit = "Mpa";
            recipeSetParameter12.ParameterValue = "0";
            recipeSetParameter12.Size = new Size(230, 35);
            recipeSetParameter12.TabIndex = 20;
            // 
            // recipeSetParameter11
            // 
            recipeSetParameter11.Increment = 1;
            recipeSetParameter11.Location = new Point(13, 363);
            recipeSetParameter11.Name = "recipeSetParameter11";
            recipeSetParameter11.ParameterName = "固化炉温度上限值";
            recipeSetParameter11.ParameterUnit = "Mpa";
            recipeSetParameter11.ParameterValue = "0";
            recipeSetParameter11.Size = new Size(230, 35);
            recipeSetParameter11.TabIndex = 19;
            // 
            // recipeSetParameter10
            // 
            recipeSetParameter10.Increment = 1;
            recipeSetParameter10.Location = new Point(13, 305);
            recipeSetParameter10.Name = "recipeSetParameter10";
            recipeSetParameter10.ParameterName = "离心风机过载上限值";
            recipeSetParameter10.ParameterUnit = "Mpa";
            recipeSetParameter10.ParameterValue = "0";
            recipeSetParameter10.Size = new Size(230, 35);
            recipeSetParameter10.TabIndex = 18;
            // 
            // recipeSetParameter9
            // 
            recipeSetParameter9.Increment = 1;
            recipeSetParameter9.Location = new Point(261, 247);
            recipeSetParameter9.Name = "recipeSetParameter9";
            recipeSetParameter9.ParameterName = "水分炉温度下限值";
            recipeSetParameter9.ParameterUnit = "Mpa";
            recipeSetParameter9.ParameterValue = "0";
            recipeSetParameter9.Size = new Size(230, 35);
            recipeSetParameter9.TabIndex = 17;
            // 
            // recipeSetParameter8
            // 
            recipeSetParameter8.Increment = 1;
            recipeSetParameter8.Location = new Point(13, 247);
            recipeSetParameter8.Name = "recipeSetParameter8";
            recipeSetParameter8.ParameterName = "水分炉温度上限值";
            recipeSetParameter8.ParameterUnit = "Mpa";
            recipeSetParameter8.ParameterValue = "0";
            recipeSetParameter8.Size = new Size(230, 35);
            recipeSetParameter8.TabIndex = 16;
            // 
            // recipeSetParameter7
            // 
            recipeSetParameter7.Increment = 1;
            recipeSetParameter7.Location = new Point(261, 189);
            recipeSetParameter7.Name = "recipeSetParameter7";
            recipeSetParameter7.ParameterName = "精洗液位下限值";
            recipeSetParameter7.ParameterUnit = "Mpa";
            recipeSetParameter7.ParameterValue = "0";
            recipeSetParameter7.Size = new Size(230, 35);
            recipeSetParameter7.TabIndex = 15;
            // 
            // recipeSetParameter6
            // 
            recipeSetParameter6.Increment = 1;
            recipeSetParameter6.Location = new Point(13, 189);
            recipeSetParameter6.Name = "recipeSetParameter6";
            recipeSetParameter6.ParameterName = "精洗喷淋泵过载上限值";
            recipeSetParameter6.ParameterUnit = "Mpa";
            recipeSetParameter6.ParameterValue = "0";
            recipeSetParameter6.Size = new Size(230, 35);
            recipeSetParameter6.TabIndex = 14;
            // 
            // recipeSetParameter5
            // 
            recipeSetParameter5.Increment = 1;
            recipeSetParameter5.Location = new Point(13, 131);
            recipeSetParameter5.Name = "recipeSetParameter5";
            recipeSetParameter5.ParameterName = "陶化喷淋泵过载上限值";
            recipeSetParameter5.ParameterUnit = "Mpa";
            recipeSetParameter5.ParameterValue = "0";
            recipeSetParameter5.Size = new Size(230, 35);
            recipeSetParameter5.TabIndex = 13;
            // 
            // recipeSetParameter4
            // 
            recipeSetParameter4.Increment = 1;
            recipeSetParameter4.Location = new Point(261, 73);
            recipeSetParameter4.Name = "recipeSetParameter4";
            recipeSetParameter4.ParameterName = "粗洗液位下限值";
            recipeSetParameter4.ParameterUnit = "Mpa";
            recipeSetParameter4.ParameterValue = "0";
            recipeSetParameter4.Size = new Size(230, 35);
            recipeSetParameter4.TabIndex = 12;
            // 
            // recipeSetParameter3
            // 
            recipeSetParameter3.Increment = 1;
            recipeSetParameter3.Location = new Point(13, 73);
            recipeSetParameter3.Name = "recipeSetParameter3";
            recipeSetParameter3.ParameterName = "粗洗喷淋泵过载上限值";
            recipeSetParameter3.ParameterUnit = "Mpa";
            recipeSetParameter3.ParameterValue = "0";
            recipeSetParameter3.Size = new Size(230, 35);
            recipeSetParameter3.TabIndex = 11;
            // 
            // recipeSetParameter2
            // 
            recipeSetParameter2.Increment = 1;
            recipeSetParameter2.Location = new Point(261, 15);
            recipeSetParameter2.Name = "recipeSetParameter2";
            recipeSetParameter2.ParameterName = "脱脂设定压力下限值";
            recipeSetParameter2.ParameterUnit = "Mpa";
            recipeSetParameter2.ParameterValue = "0";
            recipeSetParameter2.Size = new Size(230, 35);
            recipeSetParameter2.TabIndex = 10;
            // 
            // recipeSetParameter1
            // 
            recipeSetParameter1.Increment = 1;
            recipeSetParameter1.Location = new Point(13, 15);
            recipeSetParameter1.Name = "recipeSetParameter1";
            recipeSetParameter1.ParameterName = "脱脂设定压力上限值";
            recipeSetParameter1.ParameterUnit = "Mpa";
            recipeSetParameter1.ParameterValue = "0";
            recipeSetParameter1.Size = new Size(230, 35);
            recipeSetParameter1.TabIndex = 9;
            // 
            // flowPanel1
            // 
            flowPanel1.Align = AntdUI.TAlignFlow.RightCenter;
            flowPanel1.BackColor = Color.Transparent;
            flowPanel1.Controls.Add(btn_delete);
            flowPanel1.Controls.Add(btn_save);
            flowPanel1.Controls.Add(btn_download);
            flowPanel1.Dock = DockStyle.Bottom;
            flowPanel1.Location = new Point(2, 507);
            flowPanel1.Name = "flowPanel1";
            flowPanel1.Size = new Size(603, 43);
            flowPanel1.TabIndex = 8;
            flowPanel1.Text = "flowPanel1";
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(530, 3);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(70, 35);
            btn_delete.TabIndex = 7;
            btn_delete.Text = "删除";
            btn_delete.Type = AntdUI.TTypeMini.Error;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(454, 3);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(70, 35);
            btn_save.TabIndex = 2;
            btn_save.Text = "保存";
            btn_save.Type = AntdUI.TTypeMini.Primary;
            // 
            // btn_download
            // 
            btn_download.Location = new Point(348, 3);
            btn_download.Name = "btn_download";
            btn_download.Size = new Size(100, 35);
            btn_download.TabIndex = 3;
            btn_download.Text = "下载到 PLC";
            btn_download.Type = AntdUI.TTypeMini.Primary;
            // 
            // panel4
            // 
            panel4.BorderWidth = 1F;
            panel4.Controls.Add(table_recipe);
            panel4.Controls.Add(panel3);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(4);
            panel4.Size = new Size(250, 552);
            panel4.TabIndex = 7;
            panel4.Text = "panel4";
            // 
            // table_recipe
            // 
            table_recipe.Dock = DockStyle.Fill;
            table_recipe.Location = new Point(6, 92);
            table_recipe.Name = "table_recipe";
            table_recipe.Radius = 6;
            table_recipe.Size = new Size(238, 454);
            table_recipe.TabIndex = 3;
            table_recipe.Text = "table1";
            // 
            // panel3
            // 
            panel3.Back = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(btn_export);
            panel3.Controls.Add(btn_add);
            panel3.Controls.Add(btn_refresh);
            panel3.Controls.Add(btn_import);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(6, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(238, 86);
            panel3.TabIndex = 6;
            panel3.Text = "panel3";
            // 
            // btn_export
            // 
            btn_export.Location = new Point(66, 41);
            btn_export.Name = "btn_export";
            btn_export.Size = new Size(65, 35);
            btn_export.TabIndex = 7;
            btn_export.Text = "导出";
            btn_export.Type = AntdUI.TTypeMini.Primary;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(66, 3);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(65, 35);
            btn_add.TabIndex = 6;
            btn_add.Text = "添加";
            btn_add.Type = AntdUI.TTypeMini.Primary;
            // 
            // btn_refresh
            // 
            btn_refresh.Location = new Point(1, 3);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(65, 35);
            btn_refresh.TabIndex = 1;
            btn_refresh.Text = "刷新";
            btn_refresh.Type = AntdUI.TTypeMini.Primary;
            // 
            // btn_import
            // 
            btn_import.Location = new Point(1, 41);
            btn_import.Name = "btn_import";
            btn_import.Size = new Size(65, 35);
            btn_import.TabIndex = 5;
            btn_import.Text = "导入";
            btn_import.Type = AntdUI.TTypeMini.Primary;
            // 
            // ViewRecipeManage
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridPanel1);
            Name = "ViewRecipeManage";
            Size = new Size(869, 558);
            gridPanel1.ResumeLayout(false);
            panel_recipeDetail.ResumeLayout(false);
            flowPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.GridPanel gridPanel1;
        private AntdUI.Panel panel_recipeDetail;
        private AntdUI.Button btn_save;
        private AntdUI.Button btn_download;
        private AntdUI.Table table_recipe;
        private AntdUI.Button btn_import;
        private AntdUI.Button btn_refresh;
        private AntdUI.Button btn_delete;
        private AntdUI.Panel panel3;
        private AntdUI.Button btn_add;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Panel panel4;
        private AntdUI.Button btn_export;
        private UserControls.RecipeSetParameter recipeSetParameter1;
        private UserControls.RecipeSetParameter recipeSetParameter2;
        private UserControls.RecipeSetParameter recipeSetParameter3;
        private UserControls.RecipeSetParameter recipeSetParameter7;
        private UserControls.RecipeSetParameter recipeSetParameter6;
        private UserControls.RecipeSetParameter recipeSetParameter5;
        private UserControls.RecipeSetParameter recipeSetParameter4;
        private UserControls.RecipeSetParameter recipeSetParameter14;
        private UserControls.RecipeSetParameter recipeSetParameter13;
        private UserControls.RecipeSetParameter recipeSetParameter12;
        private UserControls.RecipeSetParameter recipeSetParameter11;
        private UserControls.RecipeSetParameter recipeSetParameter10;
        private UserControls.RecipeSetParameter recipeSetParameter9;
        private UserControls.RecipeSetParameter recipeSetParameter8;
        private AntdUI.Label lbl_updatedAt;
        private AntdUI.Label lbl_createdAt;
    }
}
