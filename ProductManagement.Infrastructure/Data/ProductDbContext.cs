using Microsoft.EntityFrameworkCore;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Infrastructure.Data;

public class ProductDbContext(DbContextOptions<ProductDbContext> options) : DbContext(options)
{
    
    public DbSet<Category> Categories => Set<Category>();
    
    public DbSet<Product> Products => Set<Product>();
}

