using SignalR.BLL.Abstract;
using SignalR.DAL.Abstract;
using SignalR.EntityLayer.Concrete;
using System.Linq.Expressions;

namespace SignalR.BLL.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal TestimonialDal;
        public TestimonialManager(ITestimonialDal TestimonialDal)
        {
            this.TestimonialDal = TestimonialDal;
        }

        public async Task AddAsync(Testimonial entity)
        {
            await TestimonialDal.AddAsync(entity);
        }

        public async Task DeleteAsync(Testimonial entity)
        {
            await TestimonialDal.DeleteAsync(entity);
        }

        public async Task<List<Testimonial>> GetAllAsync(Expression<Func<Testimonial, bool>> filter = null)
        {
            return await TestimonialDal.GetAllAsync();
        }

        public async Task<Testimonial> GetAsync(Expression<Func<Testimonial, bool>> filter)
        {
            return await TestimonialDal.GetAsync(filter);
        }

        public async Task UpdateAsync(Testimonial entity)
        {
            await TestimonialDal.UpdateAsync(entity);
        }
    }
}
