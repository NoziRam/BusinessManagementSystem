﻿using BusinessManagementSystem.Interfaces;
using BusinessManagementSystem.Models.Product;

namespace BusinessManagementSystem.Repositories
{
    public class ProductRepository : IProductRepository
    {

        public ProductRepository() 
        {
        
        }
        public bool Creat(Product item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Guid id, Product item)
        {
            throw new NotImplementedException();
        }
    }
}
