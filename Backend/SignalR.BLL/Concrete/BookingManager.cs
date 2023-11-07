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

        public void Add(Booking entity)
        {
            BookingDal.Add(entity);
        }

        public void Delete(Booking entity)
        {
            BookingDal.Delete(entity);
        }

        public async Task<List<Booking>> GetAllAsync(Expression<Func<Booking, bool>> filter = null)
        {
            return await BookingDal.GetAllAsync();
        }

        public async Task<Booking> GetAsync(Expression<Func<Booking, bool>> filter)
        {
            return await BookingDal.GetAsync(filter);
        }

        public void Update(Booking entity)
        {
            BookingDal.Update(entity);
        }
    }
}
