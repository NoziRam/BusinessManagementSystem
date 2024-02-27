
using BusinessManagementSystem.Infrastructure;
using BusinessManagementSystem.Interfaces;
using BusinessManagementSystem.Repositories;
using BusinessManagementSystem.Services;
using Microsoft.EntityFrameworkCore;

namespace BusinessManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<BusinessDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("connectionSringsSQL")));
          
            builder.Services.AddControllers();

            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<IBalanceRepisitory, BalanceRepository>();
            builder.Services.AddScoped<IBalanceService, BalanceService>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
