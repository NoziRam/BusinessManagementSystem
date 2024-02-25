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
        public IQueryable<Product> GetAll()
        {
           return _productRepository.GetAll();
        }
        public Product GetById(Guid id)
        {
            return _productRepository.GetById(id);
        }
        public string Creat(Product item)
        {
           _productRepository.Creat(item);
            return "";
           
        }
        public bool Update(Guid id, Product item)
        {
            var _item = _productRepository.GetById(id);
            if (_item != null)
            { 
                _item.Price = item.Price;   
                _item.Quantity = item.Quantity;
                _item.Description = item.Description;
                _item.Category = item.Category; 
                _item.Name= item.Name;
              
            }
            return true;
        }

        public bool Delete(Guid id)
        {
            var item = GetById(id);
            if (item != null)
                _productRepository.Delete(id);
          return true;
        }



    }
}
