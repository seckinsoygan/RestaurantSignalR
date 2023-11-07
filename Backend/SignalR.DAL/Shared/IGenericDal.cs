using SignalR.EntityLayer.Abstract;
using System.Linq.Expressions;

namespace SignalR.DAL.Shared
{
    public interface IGenericDal<T> where T : class, IEntity
    {
        Task<List<T>> GetAllAsync(Expression<Func<bool, T>> filter = null);
        Task<T> GetAsync(Expression<Func<T, bool>> filter);
        T GetById(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
