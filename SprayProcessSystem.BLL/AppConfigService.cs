using SprayProcessSystem.Model;
using System.Linq.Expressions;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace SprayProcessSystem.BLL
{
    public class AppConfigService : IAppConfigService
    {
        private readonly string _configPath;
        private readonly JsonSerializerOptions _jsonOptions;
        public AppConfig CurrentConfig { get; private set; }

        public AppConfigService(string configPath)
        {
            _configPath = configPath;
            _jsonOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNameCaseInsensitive = true,
                // 加上这行避免中文被转成 unicode
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            };
            CurrentConfig = Load();
        }

        public AppConfig Load()
        {
            try
            {
                if (!File.Exists(_configPath))
                {
                    var newConfig = new AppConfig();
                    Save(newConfig);
                    return newConfig;
                }

                string jsonString = File.ReadAllText(_configPath);
                return JsonSerializer.Deserialize<AppConfig>(jsonString, _jsonOptions) ?? new AppConfig();
            }
            catch (Exception ex)
            {
                throw new Exception($"从 {_configPath} 加载配置文件失败", ex);
            }
        }

        public void Save(AppConfig config)
        {
            try
            {
                File.WriteAllText(_configPath, JsonSerializer.Serialize(config, _jsonOptions));
            }
            catch (Exception ex)
            {
                throw new Exception($"保存配置文件到 {_configPath} 失败", ex);
            }
        }


        public T GetValue<T>(Expression<Func<AppConfig, T>> expression)
        {
            var func = expression.Compile();
            return func(CurrentConfig);
        }

        public void SetValue<T>(Expression<Func<AppConfig, T>> expression, T value)
        {
            if (expression.Body is not MemberExpression memberExpression)
            {
                throw new ArgumentException("表达式必须指向一个属性");
            }

            var propertyInfo = (System.Reflection.PropertyInfo)memberExpression.Member;
            var targetObject = GetTargetObject(memberExpression);
            propertyInfo.SetValue(targetObject, value);
            Save(CurrentConfig);
        }

        private object GetTargetObject(MemberExpression memberExpression)
        {
            if (memberExpression.Expression is MemberExpression parentExpression)
            {
                var parent = GetTargetObject(parentExpression);
                var parentProperty = (System.Reflection.PropertyInfo)parentExpression.Member;
                var target = parentProperty.GetValue(parent);
                if (target == null)
                {
                    target = Activator.CreateInstance(parentProperty.PropertyType);
                    parentProperty.SetValue(parent, target);
                }
                return target;
            }

            return CurrentConfig;
        }



    }
}
