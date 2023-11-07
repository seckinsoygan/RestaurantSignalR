using SignalR.EntityLayer.Abstract;
using System.Linq.Expressions;

namespace SignalR.BLL.Shared
{
    public interface IGenericService<T> where T : class, IEntity
    {
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null);
        Task<T> GetAsync(Expression<Func<T, bool>> filter);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}
