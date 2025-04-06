using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StockManagement.Server.Models;

namespace StockManagement.Server.Data;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<OrderProduct> OrderProducts { get; set; }
    public DbSet<User> Users { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<IdentityRole>().Property(r => r.ConcurrencyStamp).HasColumnType("TEXT");
        builder.Entity<IdentityUser>().Property(u => u.ConcurrencyStamp).HasColumnType("TEXT");
        
        // Relations
        builder.Entity<Customer>()
            .HasOne(c => c.Address);

        builder.Entity<User>()
            .HasOne(u => u.Company);

        builder.Entity<Order>()
            .HasMany(o => o.Products)
            .WithMany(p => p.Orders)
            .UsingEntity<OrderProduct>();
    }
}