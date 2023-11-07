using SignalR.DAL.Abstract;
using SignalR.DAL.Shared;
using SignalR.DAL.UnitOfWorks;
using SignalR.EntityLayer.Concrete;

namespace SignalR.DAL.EntityFramework
{
    public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
    {
        public EfTestimonialDal(AppDbContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
        }
    }
}
