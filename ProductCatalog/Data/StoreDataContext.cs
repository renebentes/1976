using ProductCatalog.Data.Mappings;

namespace ProductCatalog.Data;

public class StoreDataContext(DbContextOptions options)
    : DbContext(options)
{
    public DbSet<Category> Categories { get; set; }

    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CategoryMap());
        modelBuilder.ApplyConfiguration(new ProductMap());
    }
}
