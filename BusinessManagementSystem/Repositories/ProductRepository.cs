using BusinessManagementSystem.Dtios;
using BusinessManagementSystem.Infrastructure;
using BusinessManagementSystem.Interfaces;
using BusinessManagementSystem.Models.Product;

namespace BusinessManagementSystem.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IProductService _productService;

        public ProductRepository(IProductService productService) 
        {
            _productService = productService;
        }

        public Product Creat(Product item, CreateProductDtio createProductDtio)
        {
          return  _productService.Create(item, createProductDtio);
        }

        public bool Delete(Guid id)
        {
            return (_productService.Delete(id));
        }

        public IQueryable<Product> GetAll()
        {
            return _productService.GetAll();
        }

        public Product GetById(Guid id)
        {
            return _productService.GetById(id);
        }

        public bool Update(Guid id, UpdateProductDtio updateProductDtio)
        {
          return  _productService.Update(id,updateProductDtio);

        }
    }
}
