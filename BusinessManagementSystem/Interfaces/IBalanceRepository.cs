using BusinessManagementSystem.Models.FinancialTransaction;

namespace BusinessManagementSystem.Interfaces
{
    public interface IBalanceRepository
    {
        public IQueryable<Balance> GetBalanceByDateTime();

    }
}
