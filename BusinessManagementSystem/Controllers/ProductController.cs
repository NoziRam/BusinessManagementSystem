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
        private readonly IProductService _productRopository;
       

        public ProductController(IProductService productRepository)
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
        public IActionResult Create([FromBody] CreateProductDTO createProductDtio)
        {
            return Ok(_productRopository.Create(createProductDtio));
        }
        [HttpPut("Update")]
        public IActionResult Update([FromQuery] Guid id, [FromBody] UpdateProductDTO updateProductDtio) 
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
