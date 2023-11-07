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
            TestimonialDal.Add(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var value = TestimonialDal.GetById(id);
            TestimonialDal.Delete(value);
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
            TestimonialDal.Update(entity);
        }
    }
}
