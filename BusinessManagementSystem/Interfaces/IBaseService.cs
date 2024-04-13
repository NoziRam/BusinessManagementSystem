using BusinessManagementSystem.Dtios;
using BusinessManagementSystem.Models.BaseEntityModels;
using BusinessManagementSystem.Models.Users;

namespace BusinessManagementSystem.Interfaces
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll();

        /// <summary>
        /// This is for getting item by Id
        /// </summary>
        /// <param name="id">Id of item</param>
        /// <returns>retruns item if found otherwase null</returns>
       public Task<TEntity> GetById(Guid id);

       public Task<TEntity> Create(UserDto user);

       public bool Update(Guid id, UserDto user);

       public bool Delete(Guid id );
    }
}
