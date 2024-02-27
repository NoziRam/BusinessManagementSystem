using BusinessManagementSystem.Infrastructure;
using BusinessManagementSystem.Interfaces;
using BusinessManagementSystem.Models.FinancialTransaction;
using Microsoft.EntityFrameworkCore;

namespace BusinessManagementSystem.Services
{
    public class BalanceService : IBalanceService
    {
        private readonly BusinessDbContext _context;

        public BalanceService(BusinessDbContext context)
        {
            _context = context;
           
        }

        public IQueryable<Balance> GetBalance()
        {
            return _context.Balances;
        }
    }
}
