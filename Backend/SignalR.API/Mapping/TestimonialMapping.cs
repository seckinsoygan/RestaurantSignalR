using AutoMapper;
using SignalR.Dto.Testimonial;
using SignalR.EntityLayer.Concrete;

namespace SignalR.API.Mapping
{
    public class TestimonialMapping : Profile, IMapperProfile
    {
        public TestimonialMapping()
        {
            CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
        }
    }
}
