using BusinessManagementSystem.Dtios;
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
        private readonly IProductRepository _productRopository;

        public ProductController(IProductRepository productRepository)
        {
            _productRopository = productRepository;
        }
        [HttpGet]
        public IActionResult Get() => Ok(_productRopository.GetAll());

        [HttpGet("GetItemById")]
        public IActionResult GetById(Guid id)
        {
            return Ok(_productRopository.GetById(id));
        }

        [HttpPost]
        public IActionResult Create([FromRoute]Product product, [FromBody] CreateProductDtio createProductDtio )
        {
            return Ok(_productRopository.Creat(product,createProductDtio));
        }
        [HttpPut("Update")]
        public IActionResult Update([FromQuery] Guid id, [FromBody] UpdateProductDtio updateProductDtio) 
        {
           return Ok(_productRopository.Update(id,updateProductDtio));
        }

        [HttpDelete("Delete")]
        public IActionResult DeleteById([FromQuery]Guid id) 
        {
            return Ok(_productRopository.Delete(id));
        }
    }
}
