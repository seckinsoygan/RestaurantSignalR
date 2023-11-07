using SignalR.EntityLayer.Abstract;
using System.Linq.Expressions;

namespace SignalR.DAL.Shared
{
    public interface IGenericDal<T> where T : class, IEntity
    {
        Task<List<T>> GetAllAsync(Expression<Func<bool, T>> filter = null);
        Task<T> GetAsync(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
