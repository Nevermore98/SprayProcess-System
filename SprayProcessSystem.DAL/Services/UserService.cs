using SprayProcessSystem.Model.Entities;
using SprayProcessSystem.Model;

namespace SprayProcessSystem.DAL.Services
{
    public class UserService : BaseService<UserEntity>
    {
        public async Task<BaseResult<UserEntity>> LoginAsync(UserEntity entity)
        {
            var result = new BaseResult<UserEntity>();
            var sqlResult = await Database.SqlSugarClient.Queryable<UserEntity>().Where(x => x.UserName == entity.UserName && x.Password == entity.Password).FirstAsync();

            if (sqlResult != null)
            {
                result.Data = new List<UserEntity>() { sqlResult };
                result.Result = Constants.Result.Success;
            }
            else
            {
                result.Message = "用户名或密码错误";
            }
            return result;
        }

        // 获取所有用户


    }
}
