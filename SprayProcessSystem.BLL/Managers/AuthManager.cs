using Mapster;
using SprayProcessSystem.BLL.Dto.AuthDto;
using SprayProcessSystem.DAL.Services;
using SprayProcessSystem.Model;
using SprayProcessSystem.Model.Entities;

namespace SprayProcessSystem.BLL.Managers
{
    public class AuthManager
    {
        private readonly AuthService _authService;

        public AuthManager(AuthService authService)
        {
            _authService = authService;
        }

        public async Task<BaseResult<AuthQueryResultDto>> QueryAuthByRoleAsync(AuthQueryResultDto request)
        {
            var res = await _authService.QueryOneAsync(x => x.Role == request.Role);
            if (res == null)
            {
                return new BaseResult<AuthQueryResultDto>() { Result = Constants.Result.Fail, Message = $"获取 {request.Role} 权限失败" };
            }

            var dto = res.Adapt<AuthQueryResultDto>();
            return new BaseResult<AuthQueryResultDto>() { Data = new() { dto }, Result = Constants.Result.Success };
        }

        // 更新
        public async Task<BaseResult> UpdateAuthByRoleAsync(AuthUpdateDto request)
        {
            var entity = request.Adapt<AuthEntity>();
            var res = await _authService.UpdateAsync(entity, x=>x.Role == request.Role);
            if (!res)
            {
                return new BaseResult() { Result = Constants.Result.Fail, Message = $"更新 {request.Role} 权限失败" };
            }

            return new BaseResult() { Result = Constants.Result.Success, Message = $"更新 {request.Role} 权限成功" };
        }
    }
}
