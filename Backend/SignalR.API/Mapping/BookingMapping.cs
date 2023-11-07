using AutoMapper;
using SignalR.Dto.Booking;
using SignalR.EntityLayer.Concrete;

namespace SignalR.API.Mapping
{
    public class BookingMapping : Profile, IMapperProfile
    {
        public BookingMapping()
        {
            CreateMap<Booking, CreateBookingDto>().ReverseMap();
            CreateMap<Booking, ResultBookingDto>().ReverseMap();
            CreateMap<Booking, UpdateBookingDto>().ReverseMap();
        }
    }
}
