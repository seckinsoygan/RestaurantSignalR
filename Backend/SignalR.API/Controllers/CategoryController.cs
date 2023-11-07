using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BLL.Abstract;
using SignalR.Dto.Category;
using SignalR.EntityLayer.Concrete;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _Categoryservice;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService service, IMapper mapper)
        {
            _Categoryservice = service;
            _mapper = mapper;
        }
        [HttpGet("CategoryList")]
        public async Task<IActionResult> CategoryList()
        {
            var values = await _Categoryservice.GetAllAsync();
            return Ok(values);
        }
        [HttpGet("GetCategory")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var value = await _Categoryservice.GetAsync(x => x.Id == id);
            return Ok(value);
        }
        [HttpPost("CreateCategory")]
        public IActionResult CreateCategory(CreateCategoryDto dto)
        {
            var value = _mapper.Map<Category>(dto);
            _Categoryservice.Add(value);
            return Ok($"{value.CategoryName} başarılı bir şekilde eklendi.");
        }
        [HttpPut("UpdateCategory")]
        public IActionResult UpdateCategory(UpdateCategoryDto dto)
        {
            var value = _mapper.Map<Category>(dto);
            _Categoryservice.Update(value);
            return Ok("Güncelleme Başarılı.");
        }
        [HttpDelete("DeleteCategory")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var value = await _Categoryservice.GetAsync(c => c.Id == id);
            _Categoryservice.Delete(value);
            return Ok("Silme Başarılı.");
        }
    }
}
