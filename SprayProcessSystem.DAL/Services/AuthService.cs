using SprayProcessSystem.Model;
using SprayProcessSystem.Model.Entities;

namespace SprayProcessSystem.DAL.Services
{
    public class AuthService : BaseService<AuthEntity>
    {
        //public async Task<BaseResult<AuthEntity>> GetAuthByRoleAsync(string role)
        //{
        //    var result = new BaseResult<AuthEntity>();
        //    var sqlResult = await Database.SqlSugarClient.Queryable<AuthEntity>().Where(x => x.Role == role).FirstAsync();
        //    if (sqlResult != null)
        //    {
        //        result.Data = new List<AuthEntity>() { sqlResult };
        //        result.Result = Constants.Result.Success;
        //        result.Message = "获取权限成功";
        //    }
        //    else
        //    {
        //        result.Message = $"获取 {role} 权限失败";
        //    }
        //    return result;
        //}

        //// 更新
        //public async Task<BaseResult<AuthEntity>> UpdateAuthAsync(AuthEntity entity)
        //{
        //    var result = new BaseResult<AuthEntity>();
        //    var sqlResult = await Database.SqlSugarClient.Updateable(entity).ExecuteCommandAsync();
        //    if (sqlResult > 0)
        //    {
        //        result.Result = Constants.Result.Success;
        //        result.Message = "更新权限成功";
        //    }
        //    else
        //    {
        //        result.Message = "更新权限失败";
        //    }
        //    return result;
        //}

    }
}
