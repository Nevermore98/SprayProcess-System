using Mapster;
using SprayProcessSystem.BLL.Dto.RecipeDto;
using SprayProcessSystem.DAL.Services;
using SprayProcessSystem.Model;
using SprayProcessSystem.Model.Entities;


namespace SprayProcessSystem.BLL.Managers
{
    public class RecipeManager
    {
        private readonly RecipeService _recipeService;

        public RecipeManager(RecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        // 新增
        public async Task<BaseResult> AddRecipeAsync(RecipeAddDto request)
        {
            var isExist = await _recipeService.IsExistAsync(e => e.ProductType == request.ProductType);
            if (isExist)
            {
                return new BaseResult() { Result = Constants.Result.Fail, Message = "产品类型已存在" };
            }

            var entity = request.Adapt<RecipeEntity>();
            var res = await _recipeService.InsertAsync(entity);
            if (res == 0)
            {
                return new BaseResult() { Result = Constants.Result.Fail, Message = $"新增配方{entity.ProductType}失败" };
            }

            return new BaseResult() { Result = Constants.Result.Success };
        }

        // 修改
        public async Task<BaseResult> UpdateRecipeAsync(RecipeUpdateDto request)
        {
            var entity = request.Adapt<RecipeEntity>();
            var res = await _recipeService.UpdateAsync(entity);
            if (!res)
            {
                return new BaseResult() { Result = Constants.Result.Fail, Message = $"修改配方{entity.ProductType}失败" };
            }

            return new BaseResult() { Result = Constants.Result.Success };
        }

        // 删除
        public async Task<BaseResult> DeleteRecipeAsync(RecipeDeleteDto request)
        {
            var entity = request.Adapt<RecipeEntity>();
            var res = await _recipeService.DeleteAsync(entity);
            if (!res)
            {
                return new BaseResult() { Result = Constants.Result.Fail, Message = $"删除配方{entity.ProductType}失败" };
            }

            return new BaseResult() { Result = Constants.Result.Success };
        }

        // 查询所有
        public async Task<BaseResult<ResultRecipeQueryDto>> QueryAllRecipeAsync()
        {
            var res = await _recipeService.QueryAllAsync();
            var dtos = res.Adapt<List<ResultRecipeQueryDto>>();
            return new BaseResult<ResultRecipeQueryDto>() { Result = Constants.Result.Success, Data = dtos };
        }

        // 查询一个
        public async Task<BaseResult<ResultRecipeQueryDto>> QueryRecipeByIdAsync(RecipeQueryById request)
        {
            var res = await _recipeService.QueryOneAsync(x => x.Id == request.Id);
            var dto = res.Adapt<ResultRecipeQueryDto>();
            return new BaseResult<ResultRecipeQueryDto>() { Result = Constants.Result.Success, Data = new() { dto } };
        }

    }
}
