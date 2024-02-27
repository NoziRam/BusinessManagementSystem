using BusinessManagementSystem.Models.FinancialTransaction;

namespace BusinessManagementSystem.Interfaces
{
    public interface IBalanceService
    {
        public IQueryable<Balance> GetBalance();
    }
}
