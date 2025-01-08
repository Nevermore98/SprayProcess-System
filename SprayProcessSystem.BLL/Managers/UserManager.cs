using Mapster;
using SprayProcessSystem.BLL.Dto.UserDto;
using SprayProcessSystem.DAL.Services;
using SprayProcessSystem.Model;
using SprayProcessSystem.Model.Entities;

namespace SprayProcessSystem.BLL.Managers
{
    public class UserManager
    {
        private readonly UserService _userService;

        public UserManager(UserService userService)
        {
            _userService = userService;
        }

        public async Task<BaseResult<UserEntity>> LoginAsync(UserLoginDto request)
        {
            var entity = request.Adapt<UserEntity>();
            // 等价于
            // var entity = new UserEntity()
            // {
            //     UserName = request.UserName,
            //     Password = request.Password
            // };

            var res = await _userService.LoginAsync(entity);

            if (res.Result == Constants.Result.Fail)
            {
                return new BaseResult<UserEntity>() { Result = Constants.Result.Fail, Message = res.Message };
            }

            return res;
        }

        public async Task<BaseResult> IsUserExistAsync(UserIsExistDto request)
        {
            var entity = request.Adapt<UserEntity>();

            var isExist = await _userService.IsExistAsync(e => e.UserName.ToLower() == request.UserName.ToLower());

            if (isExist)
            {
                return new BaseResult() { Result = Constants.Result.Fail, Message = "用户已存在" };
            }

            return new BaseResult() { Result = Constants.Result.Success };
        }

        public async Task<BaseResult> AddUserAsync(UserAddUpdateDto request)
        {
            var isExist = await _userService.IsExistAsync(e => e.UserName.ToLower() == request.UserName.ToLower());
            if (isExist)
            {
                return new BaseResult() { Result = Constants.Result.Fail, Message = "用户已存在" };
            }
            
            var entity = request.Adapt<UserEntity>();

            var res = await _userService.InsertAsync(entity);

            if (res == 0)
            {
                return new BaseResult() { Result = Constants.Result.Fail, Message = $"新增用户 {entity.UserName} 失败" };
            }

            return new BaseResult() { Result = Constants.Result.Success, Message = $"新增用户 {entity.UserName} 成功" };
        }

        public async Task<BaseResult> UpdateUserAsync(UserAddUpdateDto request)
        {
            var isExist = await _userService.IsExistAsync(x => x.UserName.ToLower() == request.UserName.ToLower() && x.Id != request.Id);
            if (isExist)
            {
                return new BaseResult() { Result = Constants.Result.Fail, Message = $"账号名 {request.UserName} 已存在，请设置不同的账号名" };
            }

            var entity = request.Adapt<UserEntity>();

            var res = await _userService.UpdateAsync(entity);

            if (!res)
            {
                return new BaseResult() { Result = Constants.Result.Fail, Message = $"更新用户 {entity.UserName} 失败" };
            }

            return new BaseResult() { Result = Constants.Result.Success, Message = $"更新用户 {entity.UserName} 成功" };
        }

        public async Task<BaseResult> DeleteUserAsync(UserDeleteDto request)
        {
            var entity = request.Adapt<UserEntity>();

            var res = await _userService.DeleteAsync(entity);

            if (!res)
            {
                return new BaseResult() { Result = Constants.Result.Fail, Message = $"删除用户 {entity.UserName} 失败" };
            }

            return new BaseResult() { Result = Constants.Result.Success, Message = $"删除用户 {entity.UserName} 成功" };
        }


        public async Task<BaseResult<ResultUserQueryDto>> QueryAllUserAsync()
        {
            var res = await _userService.QueryAllAsync();

            var dtos = res.Adapt<List<ResultUserQueryDto>>();

            return new BaseResult<ResultUserQueryDto>() { Data = dtos, Result = Constants.Result.Success };
        }


        public async Task<BaseResult<ResultUserQueryDto>> QueryUserByUserNameAsync(UserQueryByUserName request)
        {
            var entity = request.Adapt<UserEntity>();

            var res = await _userService.QueryOneAsync(e => e.UserName.ToLower() == entity.UserName.ToLower());

            if (res == null)
            {
                return new BaseResult<ResultUserQueryDto>() { Result = Constants.Result.Fail, Message = "用户不存在" };
            }

            var dto = res.Adapt<ResultUserQueryDto>();

            return new BaseResult<ResultUserQueryDto>() { Data = new() { dto }, Result = Constants.Result.Success };
        }


        //public async Task<BaseResult<UserQueryAuthDto>> QueryUserAuth(UserQueryAuthDto request)
        //{

        //    var entity = request.Adapt<UserEntity>();

        //    var res = await _userService.QueryOneAsync(e => e.UserName == entity.UserName);

        //    if (res == null)
        //    {
        //        return new BaseResult<UserQueryAuthDto>() { Result = Constants.Result.Fail, Message = "用户不存在" };
        //    }

        //    var dto = res.Adapt<UserQueryAuthDto>();

        //    return new BaseResult<UserQueryAuthDto>() { Data = dto, Result = Constants.Result.Success };


        //}
    }
}
