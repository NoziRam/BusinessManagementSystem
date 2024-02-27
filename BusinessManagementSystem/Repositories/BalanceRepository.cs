using BusinessManagementSystem.Interfaces;
using BusinessManagementSystem.Models.FinancialTransaction;

namespace BusinessManagementSystem.Repositories
{
    public class BalanceRepository : IBalanceRepisitory
    {
        private readonly IBalanceService _balanceService;

        public BalanceRepository(IBalanceService balanceService)
        {
            _balanceService = balanceService;
        }
        public IQueryable<Balance> Get()
        {
          return  _balanceService.GetBalance();
        }
    }
}
