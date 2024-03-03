using BusinessManagementSystem.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusinessManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BalanceController : ControllerBase
    {
        private readonly IBalanceRepository _repository;
        

        public BalanceController(IBalanceRepository repository)
        {
            _repository=repository;

        }
        [HttpGet]
        public IActionResult Get() 
        { 
        return Ok(_repository.GetBalanceByDateTime());
        }
    }
}
