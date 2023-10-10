namespace ProductCatalog.Data;

public class StoreDataContext(DbContextOptions options)
    : DbContext(options)
{
    public DbSet<Category> Categories { get; set; }

    public DbSet<Product> Products { get; set; }
}
