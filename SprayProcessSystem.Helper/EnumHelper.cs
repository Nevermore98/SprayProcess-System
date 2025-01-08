using System.ComponentModel;
using System.Reflection;

namespace SprayProcessSystem.Helper
{
    public class EnumHelper
    {
        // 根据 Description 找到对应的枚举值
        public static T GetEnumFromDescription<T>(string description) where T : Enum
        {
            foreach (var field in typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                var attribute = field.GetCustomAttribute<DescriptionAttribute>();
                if (attribute != null && attribute.Description == description)
                {
                    return (T)field.GetValue(null);
                }
            }
            throw new ArgumentException($"无效的描述信息: {description}", nameof(description));
        }

        // 获取枚举值的 Description 特性内容
        public static string GetEnumDescription(Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            if (fieldInfo != null)
            {
                var descriptionAttributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
                return descriptionAttributes.Length > 0 ? descriptionAttributes[0].Description : value.ToString();
            }
            return value.ToString();
        }

        // 获取枚举类型的所有字段和描述组成的对象数组
        public static (T Value, string Description)[] GetAllEnumDescriptionArray<T>() where T : Enum
        {
            return typeof(T)
                .GetFields(BindingFlags.Public | BindingFlags.Static)
                .Select(field => (
                    Value: (T)field.GetValue(null),
                    Description: field.GetCustomAttribute<DescriptionAttribute>()?.Description ?? field.Name
                ))
                .ToArray();
        }
    }
}
