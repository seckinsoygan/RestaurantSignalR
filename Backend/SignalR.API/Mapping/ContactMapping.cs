using AutoMapper;
using SignalR.Dto.Contact;
using SignalR.EntityLayer.Concrete;

namespace SignalR.API.Mapping
{
    public class ContactMapping : Profile, IMapperProfile
    {
        public ContactMapping()
        {
            CreateMap<Contact, CreateContactDto>().ReverseMap();
            CreateMap<Contact, ResultContactDto>().ReverseMap();
            CreateMap<Contact, UpdateContactDto>().ReverseMap();
        }
    }
}
