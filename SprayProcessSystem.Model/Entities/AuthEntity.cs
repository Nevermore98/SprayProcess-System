using SqlSugar;

namespace SprayProcessSystem.Model.Entities
{
    [SugarTable("auth")]
    public class AuthEntity : BaseEntity
    {
        [SugarColumn(ColumnDataType = "Nvarchar(255)", IsNullable = false)]
        public string Role { get; set; } = "管理员";
        public bool ControlModule { get; set; }
        public bool MonitorModule { get; set; }
        public bool RecipeModule { get; set; }
        public bool LogModule { get; set; }
        public bool ReportModule { get; set; }
        public bool ChartModule { get; set; }
        public bool ParamModule { get; set; }
        //管理员特有
        //public bool AuthModule { get; set; }
        public bool UserModule { get; set; }
    }
}
