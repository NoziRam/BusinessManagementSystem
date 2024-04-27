using BusinessManagementSystem.Interfaces;
using BusinessManagementSystem.Repositories;

namespace BusinessManagementSystem.Services
{
    public static class ServiceCollectionExtensions
    {
        public static void AddMyServices(this IServiceCollection service)
        {
            service.AddScoped<AuthService>();
            service.AddScoped<IProductRepository, ProductRepository>();
            service.AddScoped<IProductService, ProductService>();
            service.AddScoped<IBalanceRepository, BalanceRepository>();
            service.AddScoped<IBalanceService, BalanceService>();
            service.AddScoped(typeof(IUserGenericRepository<>), typeof(UserGenericRepository<>));
            service.AddScoped<IAdminService, AdminService>();
        }
    }
}
