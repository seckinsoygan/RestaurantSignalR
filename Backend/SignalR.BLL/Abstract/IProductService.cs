using SignalR.BLL.Shared;
using SignalR.EntityLayer.Concrete;
using System.Linq.Expressions;

namespace SignalR.BLL.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        Task<List<Product>> GetProductsWithCategoryAsync(Expression<Func<Product, bool>> filter = null);
    }
}
