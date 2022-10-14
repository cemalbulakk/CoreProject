using Application.Features.Dtos.Products;
using Application.Requests;
using Application.Services.Interfaces;
using AutoMapper;
using Common.Dtos;
using Domain.Contexts.Ef;
using Domain.Entities;
using Persistence.Paging;
using Persistence.Repositories;

namespace Infrastructure.Services.Concrete;

public class ProductService : EfRepositoryBase<Product, AppDbContext>, IProductService
{
    private readonly IMapper _mapper;

    public ProductService(AppDbContext context, IMapper mapper) : base(context)
    {
        _mapper = mapper;
    }

    public async Task<Response<ProductDto>> CreateProduct(CreateProductDto createProductDto)
    {
        var product = _mapper.Map<Product>(createProductDto);
        var result = await AddAsync(product);
        var response = _mapper.Map<ProductDto>(result);
        return response is not null
            ? Response<ProductDto>.Success(response, 200)
            : Response<ProductDto>.Fail("The product could not be added.", 400);
    }

    public async Task<Response<ProductDto>> UpdateProduct(UpdateProductDto updateProductDto)
    {
        var product = _mapper.Map<Product>(updateProductDto);
        var result = await UpdateAsync(product);
        var response = _mapper.Map<ProductDto>(result);
        return response is not null
            ? Response<ProductDto>.Success(response, 200)
            : Response<ProductDto>.Fail("The product could not be updated.", 400);
    }

    public async Task<Response<NoContent>> DeleteProduct(string id)
    {
        var product = await GetAsync(x => x.Id.Equals(id));
        if (product is null)
        {
            return Response<NoContent>.Fail("Product not found.", 404);
        }
        var result = await DeleteAsync(product);
        var response = _mapper.Map<ProductDto>(result);
        return response is not null
            ? Response<NoContent>.Success(200, "The product has been successfully deleted.")
            : Response<NoContent>.Fail("The product could not be deleted.", 400);
    }

    public async Task<Response<ProductDto>> GetProduct(string id)
    {
        var product = await GetAsync(x => x.Id.Equals(id));
        var response = _mapper.Map<ProductDto>(product);
        return response is not null
            ? Response<ProductDto>.Success(response, 200)
            : Response<ProductDto>.Fail("Product not found.", 404);
    }

    public async Task<Response<IPaginate<Product>>> GetProducts(PageRequest request)
    {
        var paginate = await GetListAsync(size: request.PageSize, index: request.Page);
        return Response<IPaginate<Product>>.Success(paginate, 200);
    }
}