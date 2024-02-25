using BusinessManagementSystem.Models.BaseEntityModels;

namespace BusinessManagementSystem.Models.Users
{
    public abstract class User:BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string UserStatus { get; set; } = string.Empty;
        public bool Functionality { get; set; }
    }
}
