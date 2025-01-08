using SprayProcessSystem.Model.Entities;
using SqlSugar;
using System.Linq.Expressions;

namespace SprayProcessSystem.DAL.Services
{
    public class BaseService<T> where T : BaseEntity, new()
    {

        public async virtual Task<int> InsertAsync(T model)
        {
            var res = Database.SqlSugarClient.Insertable(model);
            return await res.ExecuteCommandAsync();
        }

        public async virtual Task<bool> UpdateAsync(T model)
        {
            //var sql = Database.SqlSugarClient.Updateable(model);
            //var rows = await sql.ExecuteCommandAsync();
            //return rows > 0;

            var sql = Database.SqlSugarClient.Updateable(model)
                        .IgnoreColumns(ignoreAllNullColumns: true);
            var rows = await sql.ExecuteCommandAsync();
            return rows > 0;
        }

        public async virtual Task<bool> UpdateAsync(T model, Expression<Func<T, bool>> whereExpression, Expression<Func<T, object>> updateColumns)
        {
            var sql = Database.SqlSugarClient.Updateable(model)
                .Where(whereExpression)
                .UpdateColumns(updateColumns);
            var rows = await sql.ExecuteCommandAsync();
            return rows > 0;
        }

        public async virtual Task<bool> DeleteAsync(T model)
        {
            var sql = Database.SqlSugarClient.Deleteable(model);
            var rows = await sql.ExecuteCommandAsync();
            return rows > 0;
        }

        public async virtual Task<T> QueryOneAsync(Expression<Func<T, bool>> where)
        {
            var sql = Database.SqlSugarClient.Queryable<T>().Where(where);
            return await sql.FirstAsync();
        }

        public async virtual Task<List<T>> QueryAllAsync()
        {
            var sql = Database.SqlSugarClient.Queryable<T>();
            return await sql.ToListAsync();
        }


        // 根据条件判断一条记录是否存在
        public async virtual Task<bool> IsExistAsync(Expression<Func<T, bool>> where)
        {
            return await Database.SqlSugarClient.Queryable<T>()
                .Where(where)
                .AnyAsync();
        }
    }


    // TODO0 修改 BaseService
    public class BaseService2<T> where T : class, new()
    {
        #region 增加
        public async Task<bool> AddAsync(T entity)
        {
            return await Database.SqlSugarClient.Insertable(entity).ExecuteCommandAsync() > 0;
        }

        public async Task<bool> AddRangeAsync(List<T> entities)
        {
            return await Database.SqlSugarClient.Insertable(entities).ExecuteCommandAsync() > 0;
        }
        #endregion

        #region 删除
        public async Task<bool> DeleteAsync(object id)
        {
            return await Database.SqlSugarClient.Deleteable<T>().In(id).ExecuteCommandAsync() > 0;
        }

        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> whereExpression)
        {
            return await Database.SqlSugarClient.Deleteable<T>().Where(whereExpression).ExecuteCommandAsync() > 0;
        }
        #endregion

        #region 修改
        public async Task<bool> UpdateAsync(T entity)
        {
            return await Database.SqlSugarClient.Updateable(entity).IgnoreColumns(ignoreAllNullColumns: true).ExecuteCommandAsync() > 0;
        }

        public async Task<bool> UpdateAsync(T entity, Expression<Func<T, bool>> whereExpression)
        {
            return await Database.SqlSugarClient.Updateable(entity).Where(whereExpression).ExecuteCommandAsync() > 0;
        }
        #endregion

        #region 查询
        public async Task<T> GetByIdAsync(object id)
        {
            return await Database.SqlSugarClient.Queryable<T>().InSingleAsync(id);
        }

        public async Task<List<T>> GetListAsync(Expression<Func<T, bool>> whereExpression)
        {
            return await Database.SqlSugarClient.Queryable<T>().Where(whereExpression).ToListAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await Database.SqlSugarClient.Queryable<T>().ToListAsync();
        }

        public async Task<List<T>> GetPageListAsync(Expression<Func<T, bool>> whereExpression, int pageIndex, int pageSize, RefAsync<int> totalCount)
        {
            return await Database.SqlSugarClient.Queryable<T>()
                .Where(whereExpression)
                .ToPageListAsync(pageIndex, pageSize, totalCount);
        }
        #endregion
    }

}


