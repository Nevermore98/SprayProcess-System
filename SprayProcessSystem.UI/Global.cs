using Microsoft.Extensions.DependencyInjection;


namespace SprayProcessSystem.UI
{
    public class Global
    {
        public static Dictionary<string, ServiceLifetime> ViewToLifetimeDict = new();
    }
}
