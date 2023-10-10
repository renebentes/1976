namespace ProductCatalog.Models;

public class Product
{
    public Category Category { get; set; }

    public int CategoryId { get; set; }

    public DateTime CreateDate { get; set; }

    public string Description { get; set; }

    public int Id { get; set; }

    public string Image { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public string Title { get; set; }
}
