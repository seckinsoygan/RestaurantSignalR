using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BLL.Abstract;
using SignalR.Dto.SocialMedia;
using SignalR.EntityLayer.Concrete;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _SocialMediaservice;
        private readonly IMapper _mapper;

        public SocialMediaController(ISocialMediaService service, IMapper mapper)
        {
            _SocialMediaservice = service;
            _mapper = mapper;
        }
        [HttpGet("SocialMediaList")]
        public async Task<IActionResult> SocialMediaList()
        {
            var values = await _SocialMediaservice.GetAllAsync();
            return Ok(values);
        }
        [HttpGet("GetSocialMedia")]
        public async Task<IActionResult> GetSocialMedia(int id)
        {
            var value = await _SocialMediaservice.GetAsync(x => x.Id == id);
            return Ok(value);
        }
        [HttpPost("CreateSocialMedia")]
        public IActionResult CreateSocialMedia(CreateSocialMediaDto dto)
        {
            var value = _mapper.Map<SocialMedia>(dto);
            _SocialMediaservice.Add(value);
            return Ok($"{value.Title} başarılı bir şekilde eklendi.");
        }
        [HttpPut("UpdateSocialMedia")]
        public IActionResult UpdateSocialMedia(UpdateSocialMediaDto dto)
        {
            var value = _mapper.Map<SocialMedia>(dto);
            _SocialMediaservice.Update(value);
            return Ok("Güncelleme Başarılı.");
        }
        [HttpDelete("DeleteSocialMedia")]
        public async Task<IActionResult> DeleteSocialMedia(int id)
        {
            var value = await _SocialMediaservice.GetAsync(c => c.Id == id);
            _SocialMediaservice.Delete(value);
            return Ok("Silme Başarılı.");
        }
    }
}
