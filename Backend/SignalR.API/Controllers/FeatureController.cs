using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BLL.Abstract;
using SignalR.Dto.Feature;
using SignalR.EntityLayer.Concrete;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService _Featureservice;
        private readonly IMapper _mapper;

        public FeatureController(IFeatureService service, IMapper mapper)
        {
            _Featureservice = service;
            _mapper = mapper;
        }
        [HttpGet("FeatureList")]
        public async Task<IActionResult> FeatureList()
        {
            var values = await _Featureservice.GetAllAsync();
            return Ok(values);
        }
        [HttpGet("GetFeature")]
        public async Task<IActionResult> GetFeature(int id)
        {
            var value = await _Featureservice.GetAsync(x => x.Id == id);
            return Ok(value);
        }
        [HttpPost("CreateFeature")]
        public IActionResult CreateFeature(CreateFeatureDto dto)
        {
            var value = _mapper.Map<Feature>(dto);
            _Featureservice.Add(value);
            return Ok($"{value.Title} başarılı bir şekilde eklendi.");
        }
        [HttpPut("UpdateFeature")]
        public IActionResult UpdateFeature(UpdateFeatureDto dto)
        {
            var value = _mapper.Map<Feature>(dto);
            _Featureservice.Update(value);
            return Ok("Güncelleme Başarılı.");
        }
        [HttpDelete("DeleteFeature")]
        public async Task<IActionResult> DeleteFeature(int id)
        {
            var value = await _Featureservice.GetAsync(c => c.Id == id);
            _Featureservice.Delete(value);
            return Ok("Silme Başarılı.");
        }
    }
}
