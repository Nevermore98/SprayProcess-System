using Mapster;
using SprayProcessSystem.BLL.Dto.DataDto;
using SprayProcessSystem.DAL.Services;
using SprayProcessSystem.Model;
using SprayProcessSystem.Model.Entities;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprayProcessSystem.BLL.Managers
{
    public class DataManager
    {
        private readonly DataService _dataService;

        public DataManager(DataService dataService)
        {
            _dataService = dataService;
        }

        // 添加数据
        public async Task<BaseResult> AddDataAsync(DataAddDto request)
        {
            var entity = request.Adapt<DataEntity>();
            var res = await _dataService.InsertAsync(entity);
            if (res == 0)
            {
                return new BaseResult() { Result = Constants.Result.Fail, Message = $"新增数据失败" };
            }

            return new BaseResult() { Result = Constants.Result.Success };
        }

        // 查询数据
        public async Task<BaseResult<DataQueryResultDto>> QueryDataAsync(DataQueryDto request)
        {
            var res = await _dataService.QueryListAsync(c => SqlFunc.Between(c.CreatedAt, request.StartTime, request.EndTime));

            // 添加自增序号
            var resultWithIndex = res.Adapt<List<DataQueryResultDto>>()
                .Select((item, index) =>
                {
                    item.Index = index + 1;
                    return item;
                }).ToList();

            return new BaseResult<DataQueryResultDto>() { Result = Constants.Result.Success, Data = resultWithIndex };
        }
    }
}
