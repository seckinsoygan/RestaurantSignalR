using SignalR.BLL.Abstract;
using SignalR.DAL.Abstract;
using SignalR.EntityLayer.Concrete;
using System.Linq.Expressions;

namespace SignalR.BLL.Concrete
{
    public class DiscountManager : IDiscountService
    {
        private readonly IDiscountDal DiscountDal;
        public DiscountManager(IDiscountDal DiscountDal)
        {
            this.DiscountDal = DiscountDal;
        }

        public async Task AddAsync(Discount entity)
        {
            await DiscountDal.AddAsync(entity);
        }

        public async Task DeleteAsync(Discount entity)
        {
            await DiscountDal.DeleteAsync(entity);
        }

        public async Task<List<Discount>> GetAllAsync(Expression<Func<Discount, bool>> filter = null)
        {
            return await DiscountDal.GetAllAsync();
        }

        public async Task<Discount> GetAsync(Expression<Func<Discount, bool>> filter)
        {
            return await DiscountDal.GetAsync(filter);
        }

        public async Task UpdateAsync(Discount entity)
        {
            await DiscountDal.UpdateAsync(entity);
        }
    }
}
