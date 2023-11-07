using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BLL.Abstract;
using SignalR.Dto.Product;
using SignalR.EntityLayer.Concrete;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _Productservice;
        private readonly IMapper _mapper;

        public ProductController(IProductService service, IMapper mapper)
        {
            _Productservice = service;
            _mapper = mapper;
        }
        [HttpGet("ProductList")]
        public async Task<IActionResult> ProductList()
        {
            var values = await _Productservice.GetAllAsync();
            return Ok(values);
        }
        [HttpGet("GetProduct")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var value = await _Productservice.GetAsync(x => x.Id == id);
            return Ok(value);
        }
        [HttpGet("GetProductsWithCategory")]
        public async Task<IActionResult> GetProductWithCategory()
        {
            var result = _mapper.Map<List<ResultProductWithCategoryDto>>(await _Productservice.GetProductsWithCategoryAsync());
            return Ok(result);
        }
        [HttpPost("CreateProduct")]
        public IActionResult CreateProduct(CreateProductDto dto)
        {
            var value = _mapper.Map<Product>(dto);
            _Productservice.Add(value);
            return Ok($"{value.ProductName} başarılı bir şekilde eklendi.");
        }
        [HttpPut("UpdateProduct")]
        public IActionResult UpdateProduct(UpdateProductDto dto)
        {
            var value = _mapper.Map<Product>(dto);
            _Productservice.Update(value);
            return Ok("Güncelleme Başarılı.");
        }
        [HttpDelete("DeleteProduct")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var value = await _Productservice.GetAsync(c => c.Id == id);
            _Productservice.Delete(value);
            return Ok("Silme Başarılı.");
        }
    }
}
