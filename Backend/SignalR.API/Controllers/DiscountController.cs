using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BLL.Abstract;
using SignalR.Dto.Discount;
using SignalR.EntityLayer.Concrete;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _Discountservice;
        private readonly IMapper _mapper;

        public DiscountController(IDiscountService service, IMapper mapper)
        {
            _Discountservice = service;
            _mapper = mapper;
        }
        [HttpGet("DiscountList")]
        public async Task<IActionResult> DiscountList()
        {
            var values = await _Discountservice.GetAllAsync();
            return Ok(values);
        }
        [HttpGet("GetDiscount")]
        public async Task<IActionResult> GetDiscount(int id)
        {
            var value = await _Discountservice.GetAsync(x => x.Id == id);
            return Ok(value);
        }
        [HttpPost("CreateDiscount")]
        public IActionResult CreateDiscount(CreateDiscountDto dto)
        {
            var value = _mapper.Map<Discount>(dto);
            _Discountservice.Add(value);
            return Ok($"{value.Title} başarılı bir şekilde eklendi.");
        }
        [HttpPut("UpdateDiscount")]
        public IActionResult UpdateDiscount(UpdateDiscountDto dto)
        {
            var value = _mapper.Map<Discount>(dto);
            _Discountservice.Update(value);
            return Ok("Güncelleme Başarılı.");
        }
        [HttpDelete("DeleteDiscount")]
        public async Task<IActionResult> DeleteDiscount(int id)
        {
            var value = await _Discountservice.GetAsync(c => c.Id == id);
            _Discountservice.Delete(value);
            return Ok("Silme Başarılı.");
        }
    }
}
