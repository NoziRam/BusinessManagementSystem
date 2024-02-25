using BusinessManagementSystem.Models.Product;

namespace BusinessManagementSystem.Interfaces
{
    public interface IProductService
    {
        public IQueryable<Product> GetAll();
        public Product GetById(Guid id);
        public string Creat(Product item);
        public bool Update(Guid id, Product item);
        public bool Delete(Guid id);
    }
}
