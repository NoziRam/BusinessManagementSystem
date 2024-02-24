namespace BusinessManagementSystem.Models.BaseEntityModels
{
    public abstract class BaseEntity
    {
        public Guid Id { get; }

        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}
