using AutoMapper;
using SignalR.Dto.Feature;
using SignalR.EntityLayer.Concrete;

namespace SignalR.API.Mapping
{
    public class FeatureMapping : Profile, IMapperProfile
    {
        public FeatureMapping()
        {
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
        }
    }
}
