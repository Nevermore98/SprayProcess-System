using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Extensions.Logging;
using SkiaSharp;
using SprayProcessSystem.UI.Views;

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
                .AddLogging(loggerBuilder => {
                    loggerBuilder.ClearProviders(); //清除其他日志的提供者
                    loggerBuilder.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace); //设置等级
                    loggerBuilder.AddNLog(config);
                });

            //获取存储在 appsettings.json 中的 NLog 配置信息
            var nlogConifg = config.GetSection("NLog");

            //设置 NLog 配置
            LogManager.Configuration = new NLogLoggingConfiguration(nlogConifg);

            services.AddSingleton<MainForm>();

            services.AddSingleton<ViewProductionBoard>();
            services.AddSingleton<ViewTotalControl>();
            services.AddSingleton<ViewRecipeManage>();

            services.AddSingleton<ViewChartManage>();
            services.AddSingleton<ViewReportManage>();
            services.AddTransient<ViewLogManage>();

            services.AddSingleton<ViewUserManage>();
            services.AddTransient<ViewAuthManage>();
            services.AddTransient<ViewSettings>();


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
            //LoggerHelper.Logger.Fatal(e.Exception, "未处理的UI线程异常");
            //AntdUI.Notification.error(mainWindow, "未处理的UI线程异常", e.Exception.Message, autoClose: 3, align: AntdUI.TAlignFrom.TR);
        }

        // 捕获非UI线程中的未处理异常
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            //LoggerHelper.Logger.Fatal(e.ExceptionObject as Exception, "未处理的非UI线程异常");
            //AntdUI.Notification.error(mainWindow, "未处理的非UI线程异常", e.ToString(), autoClose: 3, align: AntdUI.TAlignFrom.TR);
        }
    }
}