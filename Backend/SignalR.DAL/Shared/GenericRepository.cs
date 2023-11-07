using Microsoft.EntityFrameworkCore;
using SignalR.DAL.UnitOfWorks;
using SignalR.EntityLayer.Abstract;
using System.Linq.Expressions;

namespace SignalR.DAL.Shared
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, IEntity
    {
        private readonly AppDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public GenericRepository(AppDbContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }

        public void Add(T entity)
        {
            _context.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
            _unitOfWork.SaveChanges();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<bool, T>> filter = null)
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> filter)
        {
            return await _context.Set<T>().FindAsync(filter);
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
