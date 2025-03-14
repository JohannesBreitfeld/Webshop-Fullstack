using Fullstack.Domain.Entities;
using Fullstack.Persistance.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Fullstack.Persistance.Data;

public class AppContext : DbContext
{
    public AppContext(DbContextOptions<AppContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderProduct> OrderProducts { get; set; }
    public DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new OrderProductConfiguration());
        modelBuilder.ApplyConfiguration(new CustomerConfiguration());

        base.OnModelCreating(modelBuilder);
      
    }
}