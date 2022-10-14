using Application.Features.Dtos.Products;
using Application.Requests;
using Common.Dtos;
using Domain.Entities;
using Persistence.Paging;
using Persistence.Repositories;

namespace Application.Services.Interfaces;

public interface IProductService : IAsyncRepository<Product>, IRepository<Product>
{
    Task<Response<ProductDto>> CreateProduct(CreateProductDto createProductDto);
    Task<Response<ProductDto>> UpdateProduct(UpdateProductDto updateProductDto);
    Task<Response<NoContent>> DeleteProduct(string id);
    Task<Response<ProductDto>> GetProduct(string id);
    Task<Response<IPaginate<Product>>> GetProducts(PageRequest request);
}