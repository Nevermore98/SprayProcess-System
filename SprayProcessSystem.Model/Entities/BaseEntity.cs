using MiniExcelLibs.Attributes;
using SqlSugar;

namespace SprayProcessSystem.Model.Entities
{
    public class BaseEntity
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        [ExcelIgnore]
        public int Id { get; set; }

        [ExcelFormat("yyyy-MM-dd HH:mm:ss")]
        [ExcelColumn(Name = "创建时间", Width = 18)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [ExcelFormat("yyyy-MM-dd HH:mm:ss")]
        [ExcelColumn(Name = "更新时间", Width = 18)]
        public DateTime UpdatedAt { get; set; }

        [SugarColumn(IsIgnore = true)]
        [ExcelIgnore]
        public int Index { get; set; }
    }
}
