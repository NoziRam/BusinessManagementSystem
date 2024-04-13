using BusinessManagementSystem.Dtios;
using BusinessManagementSystem.Interfaces;
using BusinessManagementSystem.Models.Users;
using Microsoft.AspNetCore.Mvc;

namespace BusinessManagementSystem.Services
{
    public class AdminService : IAdminService
    {
        IUserGenericRepository<Admin> _repository;
        public AdminService(IUserGenericRepository<Admin> repository)
        {
            _repository = repository;
        }

        public async Task<Admin> Create(UserDto user)
        {
            var item = new Admin
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserStatus = user.UserStatus,
                Functionality = user.Functionality,
            };

            _repository.Create(item);
            return item;
        }

        public IQueryable<Admin> GetAll()
        {
            return _repository.GetAll();
        }

        public async Task<Admin> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public bool Update(Guid id, UserDto item)
        {
            var _item = _repository.GetById(id).GetAwaiter().GetResult();

            if (_item is not null)
            {
                _item.LastName = item.LastName;
                _item.UserStatus = item.UserStatus;
                _item.FirstName = item.FirstName;
                _item.Functionality = item.Functionality;
                _repository.Update(_item);
                return true;
            }
            return false;
        }

        public bool Delete(Guid id)
        {
           var item = _repository.GetById(id);
            if (item is not null)
            {
            _repository.Delete(id);
            return true;
            }
            return false;
        }

    }
}
