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
using SprayProcessSystem.Helper;
using static SprayProcessSystem.Model.Constants;
using Masuit.Tools;

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

            var db = ServiceProvider.GetRequiredService<ISqlSugarClient>();
#if DEBUG
            db.CodeFirst.SetStringDefaultLength(200).InitTables(typeof(AuthEntity), typeof(DataEntity), typeof(RecipeEntity), typeof(UserEntity));
#endif

            var list = EnumHelper.GetAllEnumDescriptionArray<NavigationType>();
            var allAuthList = list.Select(x => x.Description).ToArray();
            var engineerAuthList = list.Where(x => x.Value != NavigationType.UserManage).Select(x => x.Description).ToArray();
            var operatorAuthList = new[] { "��������", "�����ܿ�" };
            var visitorAuthList = new[] { "��������" };

            // Auth ���ʼ��
            if (!db.Queryable<AuthEntity>().Any())
            {
                db.Insertable(new AuthEntity()
                {
                    Role = "������",
                    Auths = AESHelper.Encrypt(string.Join(",", allAuthList), AESHelper.EncryptKey)
                }).ExecuteCommand();

                db.Insertable(new AuthEntity()
                {
                    Role = "����Ա",
                    Auths = AESHelper.Encrypt(string.Join(",", allAuthList), AESHelper.EncryptKey)
                }).ExecuteCommand();

                db.Insertable(new AuthEntity()
                {
                    Role = "����ʦ",
                    Auths = AESHelper.Encrypt(string.Join(",", engineerAuthList), AESHelper.EncryptKey)
                }).ExecuteCommand();

                db.Insertable(new AuthEntity()
                {
                    Role = "����Ա",
                    Auths = AESHelper.Encrypt(string.Join(",", operatorAuthList), AESHelper.EncryptKey)
                }).ExecuteCommand();

                db.Insertable(new AuthEntity()
                {
                    Role = "�ÿ�",
                    Auths = AESHelper.Encrypt(string.Join(",", visitorAuthList), AESHelper.EncryptKey)
                }).ExecuteCommand();
            }

            // ��� User ����û�� Admin�������
            if (!db.Queryable<UserEntity>().Any(x => x.UserName.ToLower() == "admin"))
            {
                db.Insertable(new UserEntity()
                {
                    UserName = "admin",
                    Password = Database.HashValue("admin"),
                    Role = "����Ա",
                    NickName = "Ĭ�Ϲ���Ա",
                    IsEnabled = true
                }).ExecuteCommand();
            }

            if (!db.Queryable<UserEntity>().Any(x => x.UserName.ToLower() == "dev"))
            {
                db.Insertable(new UserEntity()
                {
                    UserName = "dev",
                    Password = Database.HashValue("dev"),
                    Role = "������",
                    NickName = "������ģʽ",
                    IsEnabled = true
                }).ExecuteCommand();
            }

            // ��ǰ�����ܿؽ��棬��ֵί�� AppendLog
            ServiceProvider.GetRequiredService<ViewTotalControl>();
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
                    loggerBuilder.ClearProviders(); //���������־���ṩ��
                    loggerBuilder.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace); //���õȼ�
                    loggerBuilder.AddNLog(config);
                });

            //��ȡ�洢�� appsettings.json �е� NLog ������Ϣ
            var nlogConfig = config.GetSection("NLog");

            //���� NLog ����
            LogManager.Configuration = new NLogLoggingConfiguration(nlogConfig);

            var sqlSugarConfig = config.GetSection("SqlSugar");
            var dbType = Enum.Parse<DbType>(sqlSugarConfig["DbType"]);
            var connectionString = sqlSugarConfig[$"{dbType}:ConnectionString"];

            services.AddSingleton<UserService>();
            services.AddSingleton<UserManager>(sp => new UserManager(sp.GetService<UserService>()));
            services.AddSingleton<AuthService>();
            services.AddSingleton<AuthManager>(sp => new AuthManager(sp.GetService<AuthService>()));
            services.AddSingleton<RecipeService>();
            services.AddSingleton<RecipeManager>(sp => new RecipeManager(sp.GetService<RecipeService>()));

            services.AddSqlSugarSetup(dbType, connectionString);

            services.AddSingleton<MainForm>();

            services.AddSingleton<ViewProductionBoard>();
            services.AddSingleton<ViewTotalControl>();
            services.AddTransient<ViewRecipeManage>();

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



        // ����UI�߳��е�δ�����쳣
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            LogManager.GetCurrentClassLogger().Warn(e.Exception, "δ�����UI�߳��쳣");
        }


        // �����UI�߳��е�δ�����쳣
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            LogManager.GetCurrentClassLogger().Warn(e.ExceptionObject as Exception, "δ����ķ�UI�߳��쳣");
        }
    }
}