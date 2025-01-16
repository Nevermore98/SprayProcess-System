using System.Reflection;

namespace SprayProcessSystem.Helper
{
    public class AttributeHelper
    {
        /// <summary>
        /// 获取指定类的属性的特性信息。
        /// </summary>
        /// <typeparam name="TAttribute">特性类型</typeparam>
        /// <param name="type">类的类型</param>
        /// <param name="propertyName">属性名称</param>
        /// <returns>特性实例，如果不存在则返回 null</returns>
        public static TAttribute? GetPropertyAttribute<TAttribute>(Type type, string propertyName) where TAttribute : Attribute
        {
            var property = type.GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance);
            if (property == null)
            {
                throw new ArgumentException($"Property '{propertyName}' not found in type '{type.FullName}'.");
            }

            return property.GetCustomAttributes(typeof(TAttribute), false).FirstOrDefault() as TAttribute;
        }
    }
}
