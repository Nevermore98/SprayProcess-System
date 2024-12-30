using AntdUI;
using IoTClient.Clients.PLC;
using Microsoft.Extensions.DependencyInjection;
using MiniExcelLibs;
using NLog;
using SprayProcessSystem.BLL;
using SprayProcessSystem.Helper;
using SprayProcessSystem.Model;
using SprayProcessSystem.UI.Views;
using static SprayProcessSystem.Model.Constants;


namespace SprayProcessSystem.UI
{
    public partial class MainForm : AntdUI.Window
    {
        private readonly ILogger _logger;
        private readonly IAppConfigService _appConfig;

        public Control CurrentNavigationView { get; set; } = new Control();


        public MainForm()
        {
            InitializeComponent();
            LoadCustomFont(@"Assets/Fonts/DingTalk-JinBuTi.ttf");

            SetFontForApplication(this, new Font(Global.FontCollection.Families[0], 12)); // 设置全局字体
            _logger = LogManager.GetCurrentClassLogger();

            AppConfig.Current.Load();

            LoadMenu();
            BindEvent();
            InitPlcClient();
            menu.SelectIndex(0);
        }


        private void InitPlcClient()
        {
            var plcVarConfigList = MiniExcel.Query<PLCVarConfig>(AppConfig.Current.Plc.ConfigPath).ToList();

            var plcConfig = new AppConfig.PlcSettings
            {
                SiemensVersion = AppConfig.Current.Plc.SiemensVersion,
                Ip = AppConfig.Current.Plc.Ip,
                Port = AppConfig.Current.Plc.Port,
                Rack = AppConfig.Current.Plc.Rack,
                Slot = AppConfig.Current.Plc.Slot,
                ConnectTimeout = AppConfig.Current.Plc.ConnectTimeout
            };

            Global.SiemensClient = new SiemensClient(plcConfig.SiemensVersion, plcConfig.Ip, plcConfig.Port, plcConfig.Rack, plcConfig.Slot, plcConfig.ConnectTimeout);
        }

        // 加载自定义字体
        private void LoadCustomFont(string fontPath)
        {
            Global.FontCollection.AddFontFile(fontPath);
        }

        // 设置应用程序所有控件的字体
        private void SetFontForApplication(Control parent, Font font)
        {
            foreach (Control ctrl in parent.Controls)
            {
                ctrl.Font = font; // 设置字体
                if (ctrl.HasChildren)
                {
                    SetFontForApplication(ctrl, font);
                }
            }
        }

        private void BindEvent()
        {
            menu.SelectChanged += Menu_SelectChanged;
            Closing += (s, e) =>
            {

                AntdUI.Modal.open(new AntdUI.Modal.Config(this, "警告", "是否确认关闭系统")
                {
                    Btns = new Modal.Btn[]{ new AntdUI.Modal.Btn("cancel", "取消", AntdUI.TTypeMini.Default) },
                    MaskClosable = false,
                    CancelText = null,
                    OkText = "关闭",
                    OkType = TTypeMini.Error,
                    OnOk = config =>
                    {
                        return true;
                    },

                    OnBtns = button =>
                    {
                        switch (button.Text)
                        {
                            case "取消":
                                e.Cancel = true;
                                return true;
                            default:
                                return true;
                        }
                    }
                });
            };
            Closed += (s, e) =>
            {
                Global.SiemensClient.Close();
            };
        }


        private void Menu_SelectChanged(object sender, MenuSelectEventArgs e)
        {
            Navigate(e.Value.Text!);
        }

        private void Navigate(string view)
        {
            NavigationType navigationType = EnumHelper.GetEnumFromDescription<NavigationType>(view);
            Control viewToNavigate = navigationType switch
            {
                NavigationType.ProductionBoard => Program.ServiceProvider.GetRequiredService<ViewProductionBoard>(),
                NavigationType.TotalControl => Program.ServiceProvider.GetRequiredService<ViewTotalControl>(),
                NavigationType.RecipeManage => Program.ServiceProvider.GetRequiredService<ViewRecipeManage>(),

                NavigationType.ChartManage => Program.ServiceProvider.GetRequiredService<ViewChartManage>(),
                NavigationType.ReportManage => Program.ServiceProvider.GetRequiredService<ViewReportManage>(),
                NavigationType.LogManage => Program.ServiceProvider.GetRequiredService<ViewLogManage>(),

                NavigationType.UserManage => Program.ServiceProvider.GetRequiredService<ViewUserManage>(),
                NavigationType.AuthManage => Program.ServiceProvider.GetRequiredService<ViewAuthManage>(),
                NavigationType.Settings => Program.ServiceProvider.GetRequiredService<ViewSettings>(),

                _ => Program.ServiceProvider.GetRequiredService<ViewTotalControl>(),
            };


            if (viewToNavigate.GetType() == CurrentNavigationView.GetType()) return;

            panelContent.Controls.Clear();
            CurrentNavigationView = viewToNavigate;
            CurrentNavigationView.Dock = DockStyle.Fill;
            // 官方说明：容器添加控件，需要调整 dpi。
            // SingleTon 会导致每次切换会导致控件变大，Transient 就不会有这个问题
            // 判断 CurrentNavigationView 是 SingleTon 还是 Transient。单例就保持不变，瞬态就调整 dpi
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

            foreach (var rootItem in Constants.MenuItemDict)
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
