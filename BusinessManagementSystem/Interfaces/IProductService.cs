using BusinessManagementSystem.Dtios;
using BusinessManagementSystem.Models.Product;

namespace BusinessManagementSystem.Interfaces
{
    public interface IProductService
    {
        public IQueryable<Product> GetAll();
        public Product GetById(Guid id);
        public Product Create(Product item, CreateProductDtio createProductDtio);
        public bool Update(Guid id, UpdateProductDtio updateProductDtio);
        public bool Delete(Guid id);
    }
}
