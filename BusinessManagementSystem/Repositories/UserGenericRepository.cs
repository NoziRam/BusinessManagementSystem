using BusinessManagementSystem.Infrastructure;
using BusinessManagementSystem.Interfaces;
using BusinessManagementSystem.Models.BaseEntityModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;

namespace BusinessManagementSystem.Repositories
{
    public class UserGenericRepository <T> :IUserGenericRepository<T> where T : BaseEntity
    {
        readonly BusinessDbContext _context;
        public UserGenericRepository(BusinessDbContext context)
        {
            _context = context;
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public async Task<T> GetById(Guid id)
        {
          var item = await _context.Set<T>().FirstOrDefaultAsync(w => w.Id == id);
            if (item is null)
            {
                throw new Exception($"Not id {id}");
            }
            return item;
        }

        public bool Create(T item)
        {
            try
            {
                _context.Add(item);
               
                var result = _context.SaveChanges();
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(T item)
        {
            try
            {
                _context.Update(item);
                var result = _context.SaveChanges();
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(Guid id)
        {
            try
            {
                var _item = _context.Set<T>().SingleOrDefault(w => w.Id == id);
                if (_item !=null)
                {
                    _context.Remove(_item);
                    var result = _context.SaveChanges();
                    return result > 0;
                }
            }
            catch
            { }

            return false;
        }
    }
    
}
