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
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [ExcelFormat("yyyy-MM-dd HH:mm:ss")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
