using AntdUI;
using Microsoft.Extensions.DependencyInjection;
using NLog;
using SprayProcessSystem.Helper;
using SprayProcessSystem.Model;

using SprayProcessSystem.UI.Views;
using static SprayProcessSystem.Model.Constants;


namespace SprayProcessSystem.UI
{
    public partial class MainForm : AntdUI.Window
    {
        private readonly ILogger _logger;

        public Control CurrentNavigationView { get; set; } = new Control();


        public MainForm()
        {
            InitializeComponent();
            _logger = LogManager.GetCurrentClassLogger();

            LoadMenu();
            BindEvent();
        }

        private void BindEvent()
        {
            menu.SelectChanged += Menu_SelectChanged;
        }

        private void Menu_SelectChanged(object sender, MenuSelectEventArgs e)
        {
            NavigationType navigationType = EnumHelper.GetEnumFromDescription<NavigationType>(e.Value.Text!);
            Control viewToNavigate = navigationType switch
            {
                NavigationType.TotalControl => Program.ServiceProvider.GetRequiredService<ViewTotalControl>(),
                NavigationType.ProductionBoard => Program.ServiceProvider.GetRequiredService<ViewProductionBoard>(),
                NavigationType.RecipeManage => Program.ServiceProvider.GetRequiredService<ViewRecipeManage>(),

                NavigationType.ChartManage => Program.ServiceProvider.GetRequiredService<ViewChartManage>(),
                NavigationType.ReportManage => Program.ServiceProvider.GetRequiredService<ViewReportManage>(),
                NavigationType.LogManage => Program.ServiceProvider.GetRequiredService<ViewLogManage>(),

                NavigationType.UserManage => Program.ServiceProvider.GetRequiredService<ViewUserManage>(),
                NavigationType.AuthManage => Program.ServiceProvider.GetRequiredService<ViewAuthManage>(),
                NavigationType.Settings => Program.ServiceProvider.GetRequiredService<ViewSettings>(),

                _ => Program.ServiceProvider.GetRequiredService<ViewTotalControl>(),
            };


            if (viewToNavigate.GetType == CurrentNavigationView.GetType) return;

            panelContent.Controls.Clear();
            CurrentNavigationView = viewToNavigate;
            CurrentNavigationView.Dock = DockStyle.Fill;
            // �ٷ�˵����������ӿؼ�����Ҫ���� dpi��
            // SingleTon �ᵼ��ÿ���л��ᵼ�¿ؼ����Transient �Ͳ������������
            // �ж� CurrentNavigationView �� SingleTon ���� Transient�������ͱ��ֲ��䣬˲̬�͵��� dpi
            var serviceDescriptor = Global.ViewToLifetimeDict[CurrentNavigationView.GetType().Name];

            if (serviceDescriptor == ServiceLifetime.Transient)
            {
                AutoDpi(CurrentNavigationView);
            }

            panelContent.Controls.Add(CurrentNavigationView);

        }

        private void LoadMenu()
        {
            menu.Items.Clear();

            foreach (var rootItem in DataUtil.MenuItemDict)
            {
                var rootMenu = new AntdUI.MenuItem { Text = rootItem.Key.Text, IconSvg = rootItem.Key.IconSvg };

                foreach (var item in rootItem.Value)
                {
                    var menuItem = new AntdUI.MenuItem
                    {
                        Text = item.Text,
                        IconSvg = item.IconSvg,
                        Tag = item.Tag,
                    };
                    rootMenu.Sub.Add(menuItem);
                }

                menu.Items.Add(rootMenu);
            }
        }
    }

}
