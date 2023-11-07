using SignalR.BLL.Abstract;
using SignalR.DAL.Abstract;
using SignalR.EntityLayer.Concrete;
using System.Linq.Expressions;

namespace SignalR.BLL.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal BookingDal;
        public BookingManager(IBookingDal BookingDal)
        {
            this.BookingDal = BookingDal;
        }

        public async Task AddAsync(Booking entity)
        {
            BookingDal.Add(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var value = BookingDal.GetById(id);
            BookingDal.Delete(value);
        }

        public async Task<List<Booking>> GetAllAsync(Expression<Func<Booking, bool>> filter = null)
        {
            return await BookingDal.GetAllAsync();
        }

        public async Task<Booking> GetAsync(Expression<Func<Booking, bool>> filter)
        {
            return await BookingDal.GetAsync(filter);
        }

        public async Task UpdateAsync(Booking entity)
        {
            BookingDal.Update(entity);
        }
    }
}
