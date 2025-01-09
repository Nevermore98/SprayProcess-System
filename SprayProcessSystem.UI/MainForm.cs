using AntdUI;
using IoTClient.Clients.PLC;
using Microsoft.Extensions.DependencyInjection;
using MiniExcelLibs;
using NLog;
using SprayProcessSystem.BLL.Managers;
using SprayProcessSystem.Helper;
using SprayProcessSystem.Model;
using SprayProcessSystem.UI.Models;
using SprayProcessSystem.UI.UserControls.Modals;
using SprayProcessSystem.UI.Views;
using static SprayProcessSystem.Model.Constants;


namespace SprayProcessSystem.UI
{
    public partial class MainForm : AntdUI.Window
    {
        private readonly ILogger _logger;
        private readonly UserManager _userManager;
        public User CurrentUser { get; set; }

        public Control CurrentNavigationView { get; set; } = new Control();


        public MainForm()
        {
            InitializeComponent();
            _logger = LogManager.GetCurrentClassLogger();
            AppConfig.Current.Load();
            _userManager = Program.ServiceProvider.GetRequiredService<UserManager>();

            InitPlcClient();
            InitControl();
            BindEvent();
        }

        private void InitControl()
        {
            LoadCustomFont(@"Assets/Fonts/DingTalk-JinBuTi.ttf");
            SetFontForApplication(this, new Font(Global.FontCollection.Families[0], 12)); // 设置全局字体
            AntdUI.Style.SetPrimary(Color.FromArgb(64, 158, 255));

            LoadMenu();
   
            // 设置初始的页面
            menu.SelectIndex(0);
            Navigate(EnumHelper.GetEnumDescription(NavigationType.ProductionBoard));

            dp_user.ShowArrow = false;
            dp_user.Text = "登录";
            dp_user.Trigger = Trigger.Click;

            dp_user.Click += async (s, e) =>
            {
                var form = ActivatorUtilities.CreateInstance<ModalLogin>(Program.ServiceProvider, this);
                form.Size = new Size(300, 200);
                Generic.ShowModal(this, "登录用户", form, TType.None, false);
                // 提交编辑
                if (form.Submit)
                {
                    CurrentUser = form.CurrentUser;
                    dp_user.ShowArrow = true;
                    dp_user.Text = CurrentUser.NickName;
                    dp_user.Trigger = Trigger.Hover;
                    dp_user.Items.Clear();
                    dp_user.IconSvg = "<svg xmlns=\"http://www.w3.org/2000/svg\" width=\"200\" height=\"200\" viewBox=\"0 0 24 24\"><path d=\"M5.85 17.1q1.275-.975 2.85-1.537T12 15t3.3.563t2.85 1.537q.875-1.025 1.363-2.325T20 12q0-3.325-2.337-5.663T12 4T6.337 6.338T4 12q0 1.475.488 2.775T5.85 17.1M12 13q-1.475 0-2.488-1.012T8.5 9.5t1.013-2.488T12 6t2.488 1.013T15.5 9.5t-1.012 2.488T12 13m0 9q-2.075 0-3.9-.788t-3.175-2.137T2.788 15.9T2 12t.788-3.9t2.137-3.175T8.1 2.788T12 2t3.9.788t3.175 2.137T21.213 8.1T22 12t-.788 3.9t-2.137 3.175t-3.175 2.138T12 22\"/></svg>";
                    dp_user.Items.AddRange(new AntdUI.SelectItem[]
                    {
                        new AntdUI.SelectItem("切换用户"){
                            IconSvg = "<svg xmlns=\"http://www.w3.org/2000/svg\" width=\"200\" height=\"200\" viewBox=\"0 0 24 24\"><path d=\"M5.825 16L7.7 17.875q.275.275.275.688t-.275.712q-.3.3-.712.3t-.713-.3L2.7 15.7q-.15-.15-.213-.325T2.426 15t.063-.375t.212-.325l3.6-3.6q.3-.3.7-.287t.7.312q.275.3.288.7t-.288.7L5.825 14H12q.425 0 .713.288T13 15t-.288.713T12 16zm12.35-6H12q-.425 0-.712-.288T11 9t.288-.712T12 8h6.175L16.3 6.125q-.275-.275-.275-.687t.275-.713q.3-.3.713-.3t.712.3L21.3 8.3q.15.15.212.325t.063.375t-.063.375t-.212.325l-3.6 3.6q-.3.3-.7.288t-.7-.313q-.275-.3-.288-.7t.288-.7z\"/></svg>"
                        },
                        new AntdUI.SelectItem("退出"){
                            IconSvg = "<svg xmlns=\"http://www.w3.org/2000/svg\" width=\"200\" height=\"200\" viewBox=\"0 0 24 24\"><path d=\"M5 21q-.825 0-1.412-.587T3 19V5q0-.825.588-1.412T5 3h6q.425 0 .713.288T12 4t-.288.713T11 5H5v14h6q.425 0 .713.288T12 20t-.288.713T11 21zm12.175-8H10q-.425 0-.712-.288T9 12t.288-.712T10 11h7.175L15.3 9.125q-.275-.275-.275-.675t.275-.7t.7-.313t.725.288L20.3 11.3q.3.3.3.7t-.3.7l-3.575 3.575q-.3.3-.712.288t-.713-.313q-.275-.3-.262-.712t.287-.688z\"/></svg>"
                        },
                    });

                    LoadMenu();
                }
            };

            dp_user.SelectedValueChanged += (s, e) =>
            {
                var item = e.Value as AntdUI.SelectItem;
                switch (item.Text)
                {
                    case "退出":
                        dp_user.ShowArrow = false;
                        dp_user.Text = "登录";
                        dp_user.Trigger = Trigger.Click;
                        dp_user.Items.Clear();
                        dp_user.IconSvg = "<svg xmlns=\"http://www.w3.org/2000/svg\" width=\"200\" height=\"200\" viewBox=\"0 0 24 24\"><path d=\"M13 21q-.425 0-.712-.288T12 20t.288-.712T13 19h6V5h-6q-.425 0-.712-.288T12 4t.288-.712T13 3h6q.825 0 1.413.588T21 5v14q0 .825-.587 1.413T19 21zm-1.825-8H4q-.425 0-.712-.288T3 12t.288-.712T4 11h7.175L9.3 9.125q-.275-.275-.275-.675t.275-.7t.7-.313t.725.288L14.3 11.3q.3.3.3.7t-.3.7l-3.575 3.575q-.3.3-.712.288T9.3 16.25q-.275-.3-.262-.712t.287-.688z\"/></svg>";
                        CurrentUser = null;
                        LoadMenu();
                        break;
                    // TODO0 切换用户
                    case "切换用户":
                        break;
                }
            };

        }

        private void BindEvent()
        {
            menu.SelectChanged += (s, e) =>
            {
                Navigate(e.Value.Text!);
            };

            Closing += (s, e) =>
            {
                AntdUI.Modal.open(new AntdUI.Modal.Config(this, "警告", "是否确认关闭系统？", TType.Warn)
                {
                    Btns = new Modal.Btn[] { new AntdUI.Modal.Btn("cancel", "取消", AntdUI.TTypeMini.Default) },
                    MaskClosable = false,
                    CancelText = null,
                    Font = new Font(Global.FontCollection.Families[0], 11),
                    OkText = "关闭",
                    OkType = TTypeMini.Error,
                    OnOk = config =>
                    {
                        Global.SiemensClient.Close();
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


        private void InitPlcClient()
        {
            var plcVarConfigList = MiniExcel.Query<PlcVarConfig>(AppConfig.Current.Plc.ConfigPath).ToList();

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
