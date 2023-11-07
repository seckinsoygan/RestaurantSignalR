using AutoMapper;
using SignalR.Dto.SocialMedia;
using SignalR.EntityLayer.Concrete;

namespace SignalR.API.Mapping
{
    public class SocialMediaMapping : Profile, IMapperProfile
    {
        public SocialMediaMapping()
        {
            CreateMap<SocialMedia, CreateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, ResultSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, UpdateSocialMediaDto>().ReverseMap();
        }
    }
}
