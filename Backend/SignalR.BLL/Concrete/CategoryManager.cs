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

        public void Add(Category entity)
        {
            CategoryDal.Add(entity);
        }

        public void Delete(Category entity)
        {
            CategoryDal.Delete(entity);
        }

        public async Task<List<Category>> GetAllAsync(Expression<Func<Category, bool>> filter = null)
        {
            return await CategoryDal.GetAllAsync();
        }

        public async Task<Category> GetAsync(Expression<Func<Category, bool>> filter)
        {
            return await CategoryDal.GetAsync(filter);
        }

        public void Update(Category entity)
        {
            CategoryDal.Update(entity);
        }
    }
}
