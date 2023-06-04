using Microsoft.EntityFrameworkCore;

namespace ProductsAPI.data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    public DbSet<Products> Products { get; set; }
    public DbSet<ProductTypes> ProductTypes { get; set; }

}