using BusinessManagementSystem.Models.Product;

namespace BusinessManagementSystem.Interfaces
{
    public interface IProductService
    {
        public IQueryable<Product> GetAll();
        public Product GetById(int id);
        public bool Creat(Product item);
        public bool Update(Guid id, Product item);
        public bool Delete(Guid id);
    }
}
