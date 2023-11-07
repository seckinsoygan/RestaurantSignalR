using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BLL.Abstract;
using SignalR.Dto.Booking;
using SignalR.EntityLayer.Concrete;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _Bookingservice;
        private readonly IMapper _mapper;

        public BookingController(IBookingService service, IMapper mapper)
        {
            _Bookingservice = service;
            _mapper = mapper;
        }
        [HttpGet("BookingList")]
        public async Task<IActionResult> BookingList()
        {
            var values = await _Bookingservice.GetAllAsync();
            return Ok(values);
        }
        [HttpGet("GetBooking")]
        public async Task<IActionResult> GetBooking(int id)
        {
            var value = await _Bookingservice.GetAsync(x => x.Id == id);
            return Ok(value);
        }
        [HttpPost("CreateBooking")]
        public IActionResult CreateBooking(CreateBookingDto dto)
        {
            var value = _mapper.Map<Booking>(dto);
            _Bookingservice.Add(value);
            return Ok($"{value.Name} başarılı bir şekilde eklendi.");
        }
        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking(UpdateBookingDto dto)
        {
            var value = _mapper.Map<Booking>(dto);
            _Bookingservice.Update(value);
            return Ok("Güncelleme Başarılı.");
        }
        [HttpDelete("DeleteBooking")]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            var value = await _Bookingservice.GetAsync(c => c.Id == id);
            _Bookingservice.Delete(value);
            return Ok("Silme Başarılı.");
        }
    }
}
