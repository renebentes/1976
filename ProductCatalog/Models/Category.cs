namespace ProductCatalog.Models;

public class Category
{
    public int Id { get; set; }

    public IEnumerable<Product> Products { get; set; }

    public string Title { get; set; }
}
