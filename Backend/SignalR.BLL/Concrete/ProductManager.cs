using SignalR.BLL.Abstract;
using SignalR.DAL.Abstract;
using SignalR.EntityLayer.Concrete;
using System.Linq.Expressions;

namespace SignalR.BLL.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal ProductDal;
        public ProductManager(IProductDal ProductDal)
        {
            this.ProductDal = ProductDal;
        }

        public async Task AddAsync(Product entity)
        {
            ProductDal.Add(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var value = ProductDal.GetById(id);
            ProductDal.Delete(value);
        }

        public async Task<List<Product>> GetAllAsync(Expression<Func<Product, bool>> filter = null)
        {
            return await ProductDal.GetAllAsync();
        }

        public async Task<Product> GetAsync(Expression<Func<Product, bool>> filter)
        {
            return await ProductDal.GetAsync(filter);
        }

        public async Task UpdateAsync(Product entity)
        {
            ProductDal.Update(entity);
        }
    }
}
