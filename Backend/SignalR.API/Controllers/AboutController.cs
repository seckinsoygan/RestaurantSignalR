using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BLL.Abstract;
using SignalR.Dto.About;
using SignalR.EntityLayer.Concrete;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutservice;
        private readonly IMapper _mapper;

        public AboutController(IAboutService service, IMapper mapper)
        {
            _aboutservice = service;
            _mapper = mapper;
        }
        [HttpGet("AboutList")]
        public async Task<IActionResult> AboutList()
        {
            var values = await _aboutservice.GetAllAsync();
            return Ok(values);
        }
        [HttpGet("GetAbout")]
        public async Task<IActionResult> GetAbout(int id)
        {
            var value = await _aboutservice.GetAsync(x => x.Id == id);
            return Ok(value);
        }
        [HttpPost("CreateAbout")]
        public IActionResult CreateAbout(CreateAboutDto dto)
        {
            var value = _mapper.Map<About>(dto);
            _aboutservice.Add(value);
            return Ok($"{value.Title} başarılı bir şekilde eklendi.");
        }
        [HttpPut("UpdateAbout")]
        public IActionResult UpdateAbout(UpdateAboutDto dto)
        {
            var value = _mapper.Map<About>(dto);
            _aboutservice.Update(value);
            return Ok("Güncelleme Başarılı.");
        }
        [HttpDelete("DeleteAbout")]
        public async Task<IActionResult> DeleteAbout(int id)
        {
            var value = await _aboutservice.GetAsync(c => c.Id == id);
            _aboutservice.Delete(value);
            return Ok("Silme Başarılı.");
        }
    }
}
