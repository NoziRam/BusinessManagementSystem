using BusinessManagementSystem.Infrastructure;
using BusinessManagementSystem.Interfaces;
using BusinessManagementSystem.Models.FinancialTransaction;
using Microsoft.AspNetCore.Http.HttpResults;

namespace BusinessManagementSystem.Services
{
    public class BalanceService : IBalanceService
    {
        BusinessDbContext _context;
        public BalanceService(BusinessDbContext context)
        {
            _context = context;       
        }
        public IQueryable<Balance> GetBalanceByDateTime()
        {
          return _context.Balances.AsQueryable();
        }
    }
}
