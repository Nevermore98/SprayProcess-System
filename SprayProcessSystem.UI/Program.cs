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

            // ��� liveCharts ������������
            LiveCharts.Configure(config => config.HasGlobalSKTypeface(SKFontManager.Default.MatchCharacter('��')));

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
                    loggerBuilder.ClearProviders(); //���������־���ṩ��
                    loggerBuilder.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace); //���õȼ�
                    loggerBuilder.AddNLog(config);
                });

            //��ȡ�洢�� appsettings.json �е� NLog ������Ϣ
            var nlogConifg = config.GetSection("NLog");

            //���� NLog ����
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



        // ����UI�߳��е�δ�����쳣
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            //LoggerHelper.Logger.Fatal(e.Exception, "δ�����UI�߳��쳣");
            //AntdUI.Notification.error(mainWindow, "δ�����UI�߳��쳣", e.Exception.Message, autoClose: 3, align: AntdUI.TAlignFrom.TR);
        }

        // �����UI�߳��е�δ�����쳣
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            //LoggerHelper.Logger.Fatal(e.ExceptionObject as Exception, "δ����ķ�UI�߳��쳣");
            //AntdUI.Notification.error(mainWindow, "δ����ķ�UI�߳��쳣", e.ToString(), autoClose: 3, align: AntdUI.TAlignFrom.TR);
        }
    }
}