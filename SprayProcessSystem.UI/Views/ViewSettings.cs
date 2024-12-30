using SprayProcessSystem.BLL;
using SprayProcessSystem.Model;

namespace SprayProcessSystem.UI.Views
{
    public partial class ViewSettings : UserControl
    {
        public ViewSettings()
        {
            InitializeComponent();
            Load += ViewSettings_Load;
        }

        private void upd_plcConfigPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = Path.Combine(Environment.CurrentDirectory, "Configs");
            openFileDialog.Filter = "Excel 文件|*.xls;*.xlsx";
            openFileDialog.Title = "选中 PLC 配置 Excel 文件";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] filePaths = openFileDialog.FileNames;
                txt_plcConfigPath.Text = filePaths[0];
                AppConfig.Current.Plc.ConfigPath = filePaths[0];
                AppConfig.Current.Save();
            }
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
