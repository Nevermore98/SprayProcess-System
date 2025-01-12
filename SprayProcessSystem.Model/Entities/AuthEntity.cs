using SqlSugar;

namespace SprayProcessSystem.Model.Entities
{
    [SugarTable("auth")]
    public class AuthEntity : BaseEntity
    {
        [SugarColumn(ColumnDataType = "Nvarchar(255)", IsNullable = false)]
        public string Role { get; set; } = "管理员";

        [SugarColumn(ColumnDataType = "Nvarchar(500)")]
        public string Auths { get; set; }
    }
}
