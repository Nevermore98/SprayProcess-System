using SprayProcessSystem.Model;
using System.Linq.Expressions;

namespace SprayProcessSystem.BLL
{
    public interface IAppConfigService
    {
        AppConfig CurrentConfig { get; }
        void Save(AppConfig config);
        AppConfig Load();

        T GetValue<T>(Expression<Func<AppConfig, T>> expression);
        void SetValue<T>(Expression<Func<AppConfig, T>> expression, T value);
    }
}
