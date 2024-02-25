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

        [HttpPost]
        public IActionResult Create([FromBody] Product product)
        {
            try
            {
                if (product == null)
                {
                    return BadRequest("Invalid product data.");
                }

                var createdProduct = _productService.Creat(product);
                return Ok(createdProduct);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        [HttpPut("Update")]
        public IActionResult Update([FromBody] Product product, [FromQuery] Guid id) 
        {
           return Ok(_productService.Update(id,product));
        }

        [HttpDelete("Delete")]
        public IActionResult DeleteById([FromQuery]Guid id) 
        {
            return Ok(_productService.Delete(id));
        }
    }
}
