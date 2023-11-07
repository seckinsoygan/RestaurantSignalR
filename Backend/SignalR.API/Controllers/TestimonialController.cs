using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BLL.Abstract;
using SignalR.Dto.Testimonial;
using SignalR.EntityLayer.Concrete;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _Testimonialservice;
        private readonly IMapper _mapper;

        public TestimonialController(ITestimonialService service, IMapper mapper)
        {
            _Testimonialservice = service;
            _mapper = mapper;
        }
        [HttpGet("TestimonialList")]
        public async Task<IActionResult> TestimonialList()
        {
            var values = await _Testimonialservice.GetAllAsync();
            return Ok(values);
        }
        [HttpGet("GetTestimonial")]
        public async Task<IActionResult> GetTestimonial(int id)
        {
            var value = await _Testimonialservice.GetAsync(x => x.Id == id);
            return Ok(value);
        }
        [HttpPost("CreateTestimonial")]
        public IActionResult CreateTestimonial(CreateTestimonialDto dto)
        {
            var value = _mapper.Map<Testimonial>(dto);
            _Testimonialservice.Add(value);
            return Ok($"{value.Title} başarılı bir şekilde eklendi.");
        }
        [HttpPut("UpdateTestimonial")]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto dto)
        {
            var value = _mapper.Map<Testimonial>(dto);
            _Testimonialservice.Update(value);
            return Ok("Güncelleme Başarılı.");
        }
        [HttpDelete("DeleteTestimonial")]
        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            var value = await _Testimonialservice.GetAsync(c => c.Id == id);
            _Testimonialservice.Delete(value);
            return Ok("Silme Başarılı.");
        }
    }
}
