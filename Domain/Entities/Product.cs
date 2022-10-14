namespace Domain.Entities;

public class Product : BaseEntity
{
    public string ProductTitle { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }

    public decimal Price { get; set; }
}