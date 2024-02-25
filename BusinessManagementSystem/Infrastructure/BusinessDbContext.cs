using BusinessManagementSystem.Models.BaseEntityModels;
using BusinessManagementSystem.Models.FinancialTransaction;
using BusinessManagementSystem.Models.Product;
using BusinessManagementSystem.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace BusinessManagementSystem.Infrastructure
{
    public class BusinessDbContext: DbContext
    {
        public BusinessDbContext(DbContextOptions options): base(options) { }
       
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Balance> Balances { get; set; }
        public DbSet<CashFlow> CashFlows { get; set; }
        public DbSet<FinancialIndicators> FinancialIndicators { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Worker> Workers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<BaseEntity>();
            modelBuilder.Entity<Product>(entity => entity.HasKey(p => p.Id));
            modelBuilder.Entity<Category>(entity => entity.HasKey(cat => cat.Id));
            modelBuilder.Entity<Balance>(entity => entity.HasKey(b => b.Id));
            modelBuilder.Entity<CashFlow>(entity => entity.HasKey(c => c.Id));
            modelBuilder.Entity<FinancialIndicators>(entity => entity.HasKey(f => f.Id));
            modelBuilder.Entity<Admin>(entity => entity.HasKey(a => a.Id));
            modelBuilder.Entity<Owner>(entity => entity.HasKey(o => o.Id));
            modelBuilder.Entity<Worker>(entity => entity.HasKey(w => w.Id));


        }
    }
}
