using System.Linq.Expressions;

namespace Core.Generic
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task DeleteAsync(Expression<Func<TEntity, bool>> expression);
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetByExpressionAsync(Expression<Func<TEntity, bool>> expression);
    }
}
