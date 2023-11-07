using AutoMapper;
using SignalR.Dto.Discount;
using SignalR.EntityLayer.Concrete;

namespace SignalR.API.Mapping
{
    public class DiscountMapping : Profile, IMapperProfile
    {
        public DiscountMapping()
        {
            CreateMap<Discount, CreateDiscountDto>().ReverseMap();
            CreateMap<Discount, ResultDiscountDto>().ReverseMap();
            CreateMap<Discount, UpdateDiscountDto>().ReverseMap();
        }
    }
}
