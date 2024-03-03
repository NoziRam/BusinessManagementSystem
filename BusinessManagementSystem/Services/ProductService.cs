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
        private readonly BusinessDbContext _context;
       

        public ProductService(BusinessDbContext context)
        {
            _context=context;
        }
        public Product Create(Product item, CreateProductDtio createProductDtio)
        {

            var product = new Product
            {
                Id = Guid.NewGuid(),
                Price = createProductDtio.Price,
                CostPrice = createProductDtio.CostPrice,
                Name = createProductDtio.Name,
                Quantity = createProductDtio.Quantity,
                Description = createProductDtio.Description,
                Availability = true
            };
           
            _context.Products.Add(product);
           var balance= _context.Balances.FirstOrDefault();
           var cashflow = _context.CashFlows.FirstOrDefault();

            if (cashflow != null)
            {
                cashflow.Sale += product.Price;
            }
            else
            {
                cashflow = new CashFlow
                {
                    Sale = createProductDtio.Price
                };
            }
            if ( balance==null)
            {
               balance= new Balance { };
                
            }
            else 
            {

                balance.StockProducts += product.CostPrice;
                balance.DateTime = DateTime.Now;
                balance.CassacashRegister += product.Price;
                balance.SavingMoney += product.Price;

        
            }
            _context.SaveChanges();
            return product;


        }

        public bool Delete(Guid id)
        {
            var item = GetById(id);
            if (item == null) 
            {
                throw new Exception($"Not{id}");
            }
            _context.Products.Remove(item);
            _context.SaveChanges();
            return true;

        }

        public IQueryable<Product> GetAll()
        {
           return _context.Products;
        }

        public Product GetById(Guid id)
        {
            var item = _context.Products.FirstOrDefault(c=>c.Id==id);
            if (item == null) 
            {
                throw new Exception($"not{id}");
            }
            return item;
        }

        public bool Update(Guid id, UpdateProductDtio updateProductDtio)
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
                _context.SaveChanges();
            }
            return true;
        }
    }
}
