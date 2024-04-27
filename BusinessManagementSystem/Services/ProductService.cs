using BusinessManagementSystem.Dtios;
using BusinessManagementSystem.Infrastructure;
using BusinessManagementSystem.Interfaces;
using BusinessManagementSystem.Models.FinancialTransaction;
using BusinessManagementSystem.Models.Product;
using Microsoft.EntityFrameworkCore;

namespace BusinessManagementSystem.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
       

        public ProductService(IProductRepository repository)
        {
            _repository=repository;
        }
        public Product Create(CreateProductDTO createProductDtio)
        {

            var _item= new Product {   
            
                Id = Guid.NewGuid(),
                Price = createProductDtio.Price,
                CostPrice = createProductDtio.CostPrice,
                Name = createProductDtio.Name,
                Quantity = createProductDtio.Quantity,
                Description = createProductDtio.Description,
                Availability = true, 
                DateTime = DateTime.Now,
               
            };
            return _repository.Creat(_item);       
        }

        public bool Delete(Guid id)
        {
            var item = GetById(id);
            if (item == null) 
            {
                throw new Exception($"Not{id}");
            }
            _repository.Delete(item.Id);
            return true;

        }

        public IQueryable<Product> GetAll()
        {
          return  _repository.GetAll();
        }

        public Product GetById(Guid id)
        {
          return _repository.GetById(id);
        }

        public bool Update(Guid id, UpdateProductDTO updateProductDtio)
        {
            var item = GetById(id);
            if (item == null)
            {
                throw new Exception($" not {item}");
            }
            else
            {
                item.Price = updateProductDtio.Price;
                item.Quantity = updateProductDtio.Quantity;
                item.Name = updateProductDtio.Name;
                item.Description = updateProductDtio.Description;
                
            }
            _repository.Update(item.Id);
            return true;
        }
    }
}
