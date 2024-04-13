using BusinessManagementSystem.Dtios;
using BusinessManagementSystem.Models.Product;

namespace BusinessManagementSystem.Interfaces
{
    public interface IProductRepository
    {
        public IQueryable<Product> GetAll();
        public Product GetById(Guid id);
        public Product Creat(Product item);
        public bool Update(Guid id);
        public bool Delete(Guid id);
        
    }
}