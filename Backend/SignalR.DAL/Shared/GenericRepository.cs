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

        public async Task AddAsync(T entity)
        {
            await _context.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Remove(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<bool, T>> filter = null)
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> filter)
        {
            return await _context.Set<T>().SingleOrDefaultAsync(filter);
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Update(entity);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
