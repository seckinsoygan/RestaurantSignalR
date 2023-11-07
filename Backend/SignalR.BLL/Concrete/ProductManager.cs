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

        public void Add(Product entity)
        {
            ProductDal.Add(entity);
        }

        public void Delete(Product entity)
        {
            ProductDal.Delete(entity);
        }

        public async Task<List<Product>> GetAllAsync(Expression<Func<Product, bool>> filter = null)
        {
            return await ProductDal.GetAllAsync();
        }

        public async Task<Product> GetAsync(Expression<Func<Product, bool>> filter)
        {
            return await ProductDal.GetAsync(filter);
        }

        public void Update(Product entity)
        {
            ProductDal.Update(entity);
        }
    }
}
