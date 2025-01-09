using Microsoft.Extensions.DependencyInjection;
using SqlSugar;
using BCrypt.Net;

namespace SprayProcessSystem.DAL
{
    public static class Database
    {
        public static ISqlSugarClient SqlSugarClient { get; set; }
        public static void AddSqlSugarSetup(this IServiceCollection services, DbType dataType, string connectionString)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            //"ConnectionString": "Data Source=${currentdir}\\Data\\SprayProcessSystem.db"
            // 动态创建 {currentdir} 目录，注意 \\
            connectionString = connectionString.Replace("${currentdir}", AppDomain.CurrentDomain.BaseDirectory);


            services.AddSingleton<ISqlSugarClient>(s =>
            {
                SqlSugarClient = new SqlSugarScope(new ConnectionConfig()
                {
                    DbType = dataType,
                    ConnectionString = connectionString,
                    IsAutoCloseConnection = true
                });
                return SqlSugarClient;
            });
        }

        public static string HashValue(string value)
        {
             return BCrypt.Net.BCrypt.HashPassword(value);
        }

        public static bool VerifyHash(string rawValue, string hashedValue)
        {
            return BCrypt.Net.BCrypt.Verify(rawValue, hashedValue);
        }
    }
}
