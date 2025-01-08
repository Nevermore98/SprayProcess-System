using SqlSugar;

namespace SprayProcessSystem.Model.Entities
{
    [SugarTable("user")]
    public class UserEntity : BaseEntity
    {
        public string UserName { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public bool IsEnabled { get; set; } = true;

    }
}
