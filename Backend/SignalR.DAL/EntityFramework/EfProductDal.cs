using Microsoft.EntityFrameworkCore;
using SignalR.DAL.Abstract;
using SignalR.DAL.Shared;
using SignalR.DAL.UnitOfWorks;
using SignalR.EntityLayer.Concrete;
using System.Linq.Expressions;

namespace SignalR.DAL.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        private readonly AppDbContext _context;
        public EfProductDal(AppDbContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
            _context = context;
        }

        public async Task<List<Product>> GetProductsWithCategoryAsync(Expression<Func<Product, bool>> filter = null)
        {
            var values = await _context.Products.Include(x => x.Category).ToListAsync();
            return values;
        }
    }
}
