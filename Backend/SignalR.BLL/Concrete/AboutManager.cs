using SignalR.BLL.Abstract;
using SignalR.DAL.Abstract;
using SignalR.EntityLayer.Concrete;
using System.Linq.Expressions;

namespace SignalR.BLL.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            this.aboutDal = aboutDal;
        }

        public async Task AddAsync(About entity)
        {
            await aboutDal.AddAsync(entity);
        }

        public async Task DeleteAsync(About entity)
        {
            await aboutDal.DeleteAsync(entity);
        }

        public async Task<List<About>> GetAllAsync(Expression<Func<About, bool>> filter = null)
        {
            return await aboutDal.GetAllAsync();
        }

        public async Task<About> GetAsync(Expression<Func<About, bool>> filter)
        {
            return await aboutDal.GetAsync(filter);
        }

        public async Task UpdateAsync(About entity)
        {
            await aboutDal.UpdateAsync(entity);
        }
    }
}
