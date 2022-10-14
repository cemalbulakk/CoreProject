using Application.Features.Dtos.Category;

namespace Application.Features.Dtos.Products;

public class ProductDto
{
    public string Id { get; set; }
    public string ProductTitle { get; set; }
    public string Description { get; set; }
    public CategoryDto Category { get; set; }
    public decimal Price { get; set; }
}