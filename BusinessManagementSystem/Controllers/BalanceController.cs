using BusinessManagementSystem.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusinessManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BalanceController : ControllerBase
    {
        private readonly IBalanceRepisitory _balanceRepository;

        public BalanceController(IBalanceRepisitory balanceRepisitory)
        {
            _balanceRepository = balanceRepisitory; 
        }
        [HttpGet]
        public IActionResult Get()
        {
          return Ok(_balanceRepository.Get());
        }

    }
}
