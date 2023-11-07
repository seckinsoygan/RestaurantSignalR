using AutoMapper;
using SignalR.Dto.Category;
using SignalR.EntityLayer.Concrete;

namespace SignalR.API.Mapping
{
    public class CategoryMapping : Profile, IMapperProfile
    {
        public CategoryMapping()
        {
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
        }
    }
}
