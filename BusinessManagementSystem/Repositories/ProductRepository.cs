using BusinessManagementSystem.Dtios;
using BusinessManagementSystem.Infrastructure;
using BusinessManagementSystem.Interfaces;
using BusinessManagementSystem.Models.Product;
using Microsoft.EntityFrameworkCore;

namespace BusinessManagementSystem.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly BusinessDbContext _context;
      

        public ProductRepository(BusinessDbContext context) 
        {
            _context=context;
        }

        public Product Creat(Product item)
        {
           _context.Add(item);
           _context.SaveChanges();
            return item;
        }

        public bool Delete(Guid id)
        {
          var _item= _context.Set<Product>().FirstOrDefault(p => p.Id==id);
            if (_item is null)
            {
                throw new Exception($"Not item{id}");
            }
            _context.Remove(_item);
            _context.SaveChanges();
            return true;
        }

        public IQueryable<Product> GetAll()
        {
          return  _context.Set<Product>()/*.Include(p => p.Availability == true)*/;
        }

        public Product GetById(Guid id)
        {
            var item = _context.Set<Product>().FirstOrDefault(p => p.Id==id);
            if (item is null)
            {
                throw new Exception($"Item not is id {id}");
            }
            return item;
        }

        public bool Update(Guid id)
        {
            var item = GetById(id);
           _context.Update(item);
            _context.SaveChanges();
            return true;
        }
    }
}
