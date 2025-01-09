using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Extensions.Logging;
using SkiaSharp;
using SprayProcessSystem.UI.Views;
using SprayProcessSystem.DAL;
using SqlSugar;
using SprayProcessSystem.Model.Entities;
using SprayProcessSystem.UI.UserControls.Modals;
using SprayProcessSystem.BLL.Managers;
using SprayProcessSystem.DAL.Services;

namespace SprayProcessSystem.UI
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; } = null!;

        [STAThread]
        static void Main()
        {
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            AntdUI.Localization.DefaultLanguage = "zh-CN";
            AntdUI.Config.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);

            // 解决 liveCharts 中文乱码问题
            LiveCharts.Configure(config => config.HasGlobalSKTypeface(SKFontManager.Default.MatchCharacter('汉')));

            ConfigureServices();

            var db = ServiceProvider.GetRequiredService<ISqlSugarClient>();
#if DEBUG
            db.CodeFirst.SetStringDefaultLength(200).InitTables(typeof(AuthEntity), typeof(DataEntity), typeof(RecipeEntity), typeof(UserEntity));
#endif

            // 如果 User 表里没有 Admin，则添加
            if (!db.Queryable<UserEntity>().Any(x => x.UserName.ToLower() == "admin"))
            {
                db.Insertable(new UserEntity()
                {
                    UserName = "admin",
                    Password = Database.HashValue("admin"),
                    Role = "管理员",
                    NickName = "默认管理员",
                    IsEnabled = true
                }).ExecuteCommand();
            }


            var mainForm = ServiceProvider.GetRequiredService<MainForm>();
            Application.Run(mainForm);
        }


        private static void ConfigureServices()
        {
            var services = new ServiceCollection();

            var config = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Environment.CurrentDirectory, "Configs"))
                .AddJsonFile("appsettings.json")
                .Build();


            services.AddSingleton<IConfiguration>(config)
                .AddLogging(loggerBuilder =>
                {
                    loggerBuilder.ClearProviders(); //清除其他日志的提供者
                    loggerBuilder.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace); //设置等级
                    loggerBuilder.AddNLog(config);
                });

            //获取存储在 appsettings.json 中的 NLog 配置信息
            var nlogConifg = config.GetSection("NLog");

            //设置 NLog 配置
            LogManager.Configuration = new NLogLoggingConfiguration(nlogConifg);

            var sqlSugarConfig = config.GetSection("SqlSugar");
            var dbType = Enum.Parse<DbType>(sqlSugarConfig["DbType"]);
            var connectionString = sqlSugarConfig[$"{dbType}:ConnectionString"];

            services.AddSingleton<UserService>();
            services.AddSingleton<UserManager>(sp => new UserManager(sp.GetService<UserService>()));

            services.AddSqlSugarSetup(dbType, connectionString);

            services.AddSingleton<MainForm>();

            services.AddSingleton<ViewProductionBoard>();
            services.AddSingleton<ViewTotalControl>();
            services.AddSingleton<ViewRecipeManage>();

            services.AddSingleton<ViewChartManage>();
            services.AddSingleton<ViewReportManage>();
            services.AddTransient<ViewLogManage>();

            services.AddTransient<ViewUserManage>();
            services.AddTransient<ViewSettings>();

            services.AddTransient<ModalUserEdit>();
            services.AddTransient<ModalLogin>();


            ServiceProvider = services.BuildServiceProvider();

            foreach (var item in services)
            {
                if (item.ServiceType.Name.StartsWith("View"))
                {
                    Global.ViewToLifetimeDict.Add(item.ServiceType.Name, item.Lifetime);
                }
            }
        }



        // 捕获UI线程中的未处理异常
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            //AntdUI.Notification.error(mainWindow, "未处理的UI线程异常", e.Exception.Message, autoClose: 3, align: AntdUI.TAlignFrom.TR);
            LogManager.GetCurrentClassLogger().Warn(e.Exception, "未处理的UI线程异常");
        }


        // 捕获非UI线程中的未处理异常
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            //AntdUI.Notification.error(mainWindow, "未处理的非UI线程异常", e.ToString(), autoClose: 3, align: AntdUI.TAlignFrom.TR);
            LogManager.GetCurrentClassLogger().Warn(e.ExceptionObject as Exception, "未处理的非UI线程异常");
        }
    }
}