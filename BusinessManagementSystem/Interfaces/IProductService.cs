using BusinessManagementSystem.Dtios;
using BusinessManagementSystem.Models.Product;

namespace BusinessManagementSystem.Interfaces
{
    public interface IProductService
    {
        public IQueryable<Product> GetAll();
        public Product GetById(Guid id);
        public Product Create(CreateProductDTO createProductDtio);
        public bool Update(Guid id, UpdateProductDTO updateProductDtio);
        public bool Delete(Guid id);
    }
}
