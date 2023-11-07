using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BLL.Abstract;
using SignalR.Dto.Contact;
using SignalR.EntityLayer.Concrete;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _Contactservice;
        private readonly IMapper _mapper;

        public ContactController(IContactService service, IMapper mapper)
        {
            _Contactservice = service;
            _mapper = mapper;
        }
        [HttpGet("ContactList")]
        public async Task<IActionResult> ContactList()
        {
            var values = await _Contactservice.GetAllAsync();
            return Ok(values);
        }
        [HttpGet("GetContact")]
        public async Task<IActionResult> GetContact(int id)
        {
            var value = await _Contactservice.GetAsync(x => x.Id == id);
            return Ok(value);
        }
        [HttpPost("CreateContact")]
        public IActionResult CreateContact(CreateContactDto dto)
        {
            var value = _mapper.Map<Contact>(dto);
            _Contactservice.Add(value);
            return Ok($"{value.Location} başarılı bir şekilde eklendi.");
        }
        [HttpPut("UpdateContact")]
        public IActionResult UpdateContact(UpdateContactDto dto)
        {
            var value = _mapper.Map<Contact>(dto);
            _Contactservice.Update(value);
            return Ok("Güncelleme Başarılı.");
        }
        [HttpDelete("DeleteContact")]
        public async Task<IActionResult> DeleteContact(int id)
        {
            var value = await _Contactservice.GetAsync(c => c.Id == id);
            _Contactservice.Delete(value);
            return Ok("Silme Başarılı.");
        }
    }
}
