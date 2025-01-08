using SqlSugar;

namespace SprayProcessSystem.Model.Entities
{
    public class BaseEntity
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; }
    }
}
