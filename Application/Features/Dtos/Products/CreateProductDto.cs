namespace Application.Features.Dtos.Products;

public class CreateProductDto
{
    public string ProductTitle { get; set; }
    public string Description { get; set; }
    public string CategoryId { get; set; }
    public decimal Price { get; set; }
}