
namespace SprayProcessSystem.Model
{
    public static class Constants
    {
        public enum NavigationType
        {
            [EnumDescription("生产看板")]
            ProductionBoard,
            [EnumDescription("产线总控")]
            TotalControl,
            [EnumDescription("配方管理")]
            RecipeManage,
           
            [EnumDescription("图表管理")]
            ChartManage,
            [EnumDescription("报表管理")]
            ReportManage,
            [EnumDescription("日志管理")]

            LogManage,
            [EnumDescription("用户配置")]
            UserManage,
            [EnumDescription("权限配置")]
            AuthManage,
            [EnumDescription("系统参数")]
            Settings,
        }
    }
}
