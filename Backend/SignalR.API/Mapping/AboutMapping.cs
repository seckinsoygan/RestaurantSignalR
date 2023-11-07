using AutoMapper;
using SignalR.Dto.About;
using SignalR.EntityLayer.Concrete;

namespace SignalR.API.Mapping
{
    public class AboutMapping : Profile, IMapperProfile
    {
        public AboutMapping()
        {
            CreateMap<About, CreateAboutDto>().ReverseMap();
            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
        }
    }
}
