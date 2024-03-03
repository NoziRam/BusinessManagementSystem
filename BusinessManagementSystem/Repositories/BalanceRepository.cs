using BusinessManagementSystem.Interfaces;
using BusinessManagementSystem.Models.FinancialTransaction;

namespace BusinessManagementSystem.Repositories
{
    public class BalanceRepository : IBalanceRepository
    {
        private readonly IBalanceService _service;

        public BalanceRepository(IBalanceService service)
        {
            _service=service;
        }
        public IQueryable<Balance> GetBalanceByDateTime()
        {
           return _service.GetBalanceByDateTime();
        }
    }
}
