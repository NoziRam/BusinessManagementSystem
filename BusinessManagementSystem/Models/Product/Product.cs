using BusinessManagementSystem.Models.BaseEntityModels;
using BusinessManagementSystem.Models.FinancialTransaction;

namespace BusinessManagementSystem.Models.Product
{
    public class Product 
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; }
        public double CostPrice { get; set; }
        public Category? Category { get; set; }
        public bool Availability { get; set; }
         public  DateTime DateTime { get; set; }
    }
}
