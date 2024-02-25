using BusinessManagementSystem.Models.BaseEntityModels;

namespace BusinessManagementSystem.Models.FinancialTransaction
{
    public class CashFlow:BaseEntity
    {
        public double Sale { get; set; }
        public double Purchase { get; set; }
        public double GrossProfit { get; set; }
        public double OperatingExpenses { get; set; }
        public double SalaryForEmployees { get; set; }
        public double RentalCosts { get; set; }
        public double TransportationCosts { get; set; }
        public double UtilityExpenses { get; set; }
        public double Marketing { get; set; }
        public double OtherOperatingCosts { get; set; }
        public double TotalExpenses { get; set; }
        public double Tax { get; set; }
        public double TotalCosts { get; set; }
        public double NetProfit { get; set; }
        public DateTime DateTime { get; set; }
    }
}
