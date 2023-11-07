using AutoMapper;
using SignalR.Dto.Product;
using SignalR.EntityLayer.Concrete;

namespace SignalR.API.Mapping
{
    public class ProductMapping : Profile, IMapperProfile
    {
        public ProductMapping()
        {
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
        }
    }
}
