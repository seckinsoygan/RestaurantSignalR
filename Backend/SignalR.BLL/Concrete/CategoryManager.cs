using SignalR.BLL.Abstract;
using SignalR.DAL.Abstract;
using SignalR.EntityLayer.Concrete;
using System.Linq.Expressions;

namespace SignalR.BLL.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal CategoryDal;
        public CategoryManager(ICategoryDal CategoryDal)
        {
            this.CategoryDal = CategoryDal;
        }

        public async Task AddAsync(Category entity)
        {
            await CategoryDal.AddAsync(entity);
        }

        public async Task DeleteAsync(Category entity)
        {
            await CategoryDal.DeleteAsync(entity);
        }

        public async Task<List<Category>> GetAllAsync(Expression<Func<Category, bool>> filter = null)
        {
            return await CategoryDal.GetAllAsync();
        }

        public async Task<Category> GetAsync(Expression<Func<Category, bool>> filter)
        {
            return await CategoryDal.GetAsync(filter);
        }

        public async Task UpdateAsync(Category entity)
        {
            await CategoryDal.UpdateAsync(entity);
        }
    }
}
