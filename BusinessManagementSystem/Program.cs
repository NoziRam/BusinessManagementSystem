
using BusinessManagementSystem.Auth;
using BusinessManagementSystem.Infrastructure;
using BusinessManagementSystem.Interfaces;
using BusinessManagementSystem.Models.BaseEntityModels;
using BusinessManagementSystem.Repositories;
using BusinessManagementSystem.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;

namespace BusinessManagementSystem
{
    public class Program
    {
        public const string AppKey = "TestKey";
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            //Adding custom Auth
            builder.Services.AddMyAuth();
           
            // Add services to the container.
            builder.Services.AddDbContext<BusinessDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("connectionSringsSQL"))
            .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
            builder.Services.AddLogging();
            builder.Services.AddControllers()
                .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
            builder.Services.AddEndpointsApiExplorer();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Business application APIs", Version = "v1" });

                // Add the JWT Bearer authentication scheme
                var securityScheme = new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Description = "JWT Authorization header using the Bearer scheme.",
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer" }
                };
                c.AddSecurityDefinition("Bearer", securityScheme);

                // Use the JWT Bearer authentication scheme globally
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                {
                        securityScheme, new List<string>() }
                });
            });
            
            builder.Services.AddMyServices();

            var app = builder.Build();

            app.UseAuthentication();
            app.UseAuthorization();

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
