using BusinessManagementSystem.Dtios;
using BusinessManagementSystem.Models.BaseEntityModels;

namespace BusinessManagementSystem.Models.FinancialTransaction
{
    public class Expenses
    {
        public Guid Id { get; set; }
        public double Сost { get; set; }
        public CreateExpensesDTO Category { get; set; }
       
        public DateTime DateTime { get; set; }
    }
}
