namespace BusinessManagementSystem.Models.BaseEntityModels
{
    public abstract class BaseEntity
    {
        public Guid Id { get; }
        public DateTime DateTime { get; set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid();
            DateTime = DateTime.Now;
        }
    }
}
