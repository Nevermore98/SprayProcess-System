using IoTClient.Common.Enums;

namespace SprayProcessSystem.Model
{
    [ConfigFile("Configs/AppConfig.json")]
    public class AppConfig : JsonConfig<AppConfig>
    {
        public PlcSettings Plc { get; set; }
        public DatabaseSettings Database { get; set; }
        public GeneralSettings General { get; set; }
        public LogSettings Log { get; set; }


        public class DatabaseSettings
        {
            public string ConnectionString { get; set; }
            public string Provider { get; set; }
        }

        public class GeneralSettings
        {
            public string Language { get; set; }
            public bool AutoStart { get; set; }
        }

        public class PlcSettings
        {
            public string ConfigPath { get; set; }
            public SiemensVersion SiemensVersion { get; set; }
            public string Ip { get; set; }
            public int Port { get; set; }
            public byte Slot { get; set; }
            public byte Rack { get; set; }
            public int ConnectTimeout { get; set; }
            public int ReadInterval { get; set; }
            public int ReConnectInterval { get; set; }
        }

        public class LogSettings
        {
            public string LogDir { get; set; }
            public int AutoClearDays { get; set; }  
        }

        public override void SetDefault()
        {
            Plc = new PlcSettings
            {
                ConfigPath = $@"{AppDomain.CurrentDomain.BaseDirectory}Configs\PLC_Config.xlsx",
                SiemensVersion = SiemensVersion.S7_1200,
                Ip = "127.0.0.1",
                Port = 102,
                Slot = 0,
                Rack = 0,
                ConnectTimeout  = 3000,
                ReadInterval = 50,
                ReConnectInterval = 2000
            };
            

            Database = new DatabaseSettings
            {
                ConnectionString = "Data Source=.;Initial Catalog=SprayProcessSystem;Integrated Security=True",
                Provider = "System.Data.SqlClient"
            };
            General = new GeneralSettings
            {
                Language = "zh-CN",
                AutoStart = false
            };
            Log = new LogSettings
            {
                LogDir = $@"{AppDomain.CurrentDomain.BaseDirectory}Logs",
                AutoClearDays = 0 // 不清理
            };
        }
    }
}
