using BusinessManagementSystem.Dtios;
using BusinessManagementSystem.Interfaces;
using BusinessManagementSystem.Models.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusinessManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        IAdminService _service;
        public AdminController(IAdminService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAll());

        [HttpGet("ById")]
        public IActionResult GetById(Guid id)
        {
           var item = _service.GetById(id);
            return Ok(item);
        }
        [HttpPost]
        public IActionResult CreateAdmin(UserDto dto)
        {
           var admin= _service.Create(dto);
            return Ok(admin);
        }
        [HttpPut]
        public IActionResult UpdateAdmin(Guid id, UserDto adminUdate)
        {
            var admin= _service.Update(id, adminUdate);
            return Ok(admin);
        }

        [HttpDelete]
        public IActionResult DeleteAdmin(Guid id)
        {
            return Ok(_service.Delete(id));
        }
    }
}
