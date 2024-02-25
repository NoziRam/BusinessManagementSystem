using BusinessManagementSystem.Interfaces;
using BusinessManagementSystem.Models.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusinessManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult Get() => Ok(_productService.GetAll());

        [HttpGet("GetItemById")]
        public IActionResult GetById(Guid id)
        {
            return Ok(_productService.GetById(id));
        }

        [HttpPost("Create")]
        public IActionResult Post([FromBody] Product product) 
        {
          return Ok(_productService.Creat(product));
        }

        [HttpPut("Update")]
        public IActionResult Update([FromBody] Product product, [FromBody] Guid id) 
        {
           return Ok(_productService.Update(id,product));
        }

        [HttpDelete("Delete")]
        public IActionResult DeleteById([FromBody]Guid id) 
        {
            return Ok(_productService.Delete(id));
        }
    }
}
