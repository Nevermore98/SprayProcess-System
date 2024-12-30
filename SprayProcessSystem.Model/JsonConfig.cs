using System.Text.Encodings.Web;
using System.Text.Json;

namespace SprayProcessSystem.Model
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class ConfigFileAttribute : Attribute
    {
        public string FilePath { get; }
        public ConfigFileAttribute(string filePath)
        {
            FilePath = filePath;
        }
    }

    public abstract class JsonConfig<T> where T : JsonConfig<T>, new()
    {
        private static readonly Lazy<T> _current = new Lazy<T>(() => new T());
        public static T Current => _current.Value;

        private static string GetConfigFilePath()
        {
            var attribute = typeof(T).GetCustomAttributes(typeof(ConfigFileAttribute), false);
            if (attribute.Length > 0 && attribute[0] is ConfigFileAttribute configFileAttribute)
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, configFileAttribute.FilePath);
                Directory.CreateDirectory(Path.GetDirectoryName(filePath)!);
                return filePath;
            }
            throw new InvalidOperationException("配置类未指定配置文件路径！");
        }

        public virtual void Load()
        {
            string filePath = GetConfigFilePath();
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };
                var loaded = JsonSerializer.Deserialize<T>(json, options);
                if (loaded != null)
                {
                    foreach (var prop in typeof(T).GetProperties())
                    {
                        prop.SetValue(this, prop.GetValue(loaded));
                    }
                }
            }
            else
            {
                SetDefault();
                Save();
            }
        }

        public virtual void Save()
        {
            string filePath = GetConfigFilePath();
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            string json = JsonSerializer.Serialize(this, typeof(T), options);
            File.WriteAllText(filePath, json);
        }

        public abstract void SetDefault();
    }

}
