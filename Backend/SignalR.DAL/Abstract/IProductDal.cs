using SignalR.DAL.Shared;
using SignalR.EntityLayer.Concrete;
using System.Linq.Expressions;

namespace SignalR.DAL.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        Task<List<Product>> GetProductsWithCategoryAsync(Expression<Func<Product, bool>> filter = null);
    }
}
