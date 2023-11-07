using SignalR.EntityLayer.Abstract;
using System.Linq.Expressions;

namespace SignalR.BLL.Shared
{
    public interface IGenericService<T> where T : class, IEntity
    {
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null);
        Task<T> GetAsync(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
