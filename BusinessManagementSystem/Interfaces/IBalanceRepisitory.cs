using BusinessManagementSystem.Models.FinancialTransaction;

namespace BusinessManagementSystem.Interfaces
{
    public interface IBalanceRepisitory
    {
        public IQueryable<Balance> Get();
    }
}
