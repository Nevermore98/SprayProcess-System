using SprayProcessSystem.Model;

namespace SprayProcessSystem.UI.Views
{
    public partial class ViewSettings : UserControl
    {
        public ViewSettings()
        {
            InitializeComponent();
            Load += ViewSettings_Load;

            upd_plcExcel.Filter = "Excel 文件|*.xls;*.xlsx";
        }


        private void upd_plcConfigPath_DragChanged(object sender, AntdUI.StringsEventArgs e)
        {
            string[] filePaths = e.Value;
            txt_plcConfigPath.Text = filePaths[0];
        }

        private void ViewSettings_Load(object? sender, EventArgs e)
        {
            txt_plcConfigPath.Text = AppConfig.Current.Plc.ConfigPath;
        }
    }
}
