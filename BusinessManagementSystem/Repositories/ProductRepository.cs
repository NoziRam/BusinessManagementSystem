using BusinessManagementSystem.Infrastructure;
using BusinessManagementSystem.Interfaces;
using BusinessManagementSystem.Models.Product;

namespace BusinessManagementSystem.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly BusinessDbContext _context;

        public ProductRepository(BusinessDbContext context) 
        {
                _context = context;
        }
        public IQueryable<Product> GetAll()
        {
            return _context.Products;
        }
        public Product GetById(Guid id)
        {
            var item = _context.Products.Find(id);
            if (item == null)
            {
                throw new Exception($"not {id} ");
            }
            return item;
        }
        public bool Creat(Product item)
        {
            try
            {
           
              _context.Add(item);
                var _item = _context.SaveChanges();
            return _item>0;

            }
            catch (Exception)
            {

                return false;
            } 
        }
        public bool Update(Guid id, Product item)
        {
            var _item = _context.Products.Find(id);
            if (_item == null)
            {
                throw new Exception($"not {id} ");
            }
             _context.Update(item);
            _context.SaveChanges();
            return true;
        }
        public bool Delete(Guid id)
        {
            var item = _context.Products.Find(id);
            if (item == null)
            {
                throw new Exception($"not {id} ");
            }
            _context.Products.Remove(item);
            _context.SaveChanges();
            return true;
        }




    }
}
