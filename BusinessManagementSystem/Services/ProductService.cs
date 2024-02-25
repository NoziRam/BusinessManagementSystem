using BusinessManagementSystem.Interfaces;
using BusinessManagementSystem.Models.Product;

namespace BusinessManagementSystem.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
                _productRepository = productRepository;
        }
        public bool Creat(Product item)
        {
            if (item != null) 
            _productRepository.Creat(item);
            return true;
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Guid id, Product item)
        {
            throw new NotImplementedException();
        }
    }
}
