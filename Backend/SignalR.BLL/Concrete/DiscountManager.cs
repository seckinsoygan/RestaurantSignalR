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

        public void Add(Discount entity)
        {
            DiscountDal.Add(entity);
        }

        public void Delete(Discount entity)
        {
            DiscountDal.Delete(entity);
        }

        public async Task<List<Discount>> GetAllAsync(Expression<Func<Discount, bool>> filter = null)
        {
            return await DiscountDal.GetAllAsync();
        }

        public async Task<Discount> GetAsync(Expression<Func<Discount, bool>> filter)
        {
            return await DiscountDal.GetAsync(filter);
        }

        public void Update(Discount entity)
        {
            DiscountDal.Update(entity);
        }
    }
}
