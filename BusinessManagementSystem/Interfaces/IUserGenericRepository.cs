using BusinessManagementSystem.Dtios;
using BusinessManagementSystem.Models.BaseEntityModels;
using BusinessManagementSystem.Models.Product;

namespace BusinessManagementSystem.Interfaces
{
    public interface IUserGenericRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        Task<T> GetById(Guid id);
        bool Create(T item);
        bool Update(T item);
        bool Delete(Guid id);
    }
}
