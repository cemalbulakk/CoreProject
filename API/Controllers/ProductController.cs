using API.Filters;
using Application.Features.Dtos.Products;
using Application.Services.Interfaces;
using AutoMapper;
using Common.Attributes;
using Common.BaseController;
using Common.Dtos;
using Common.Enums;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [ServiceFilter(typeof(PermissionFilter))]
    public class ProductController : CustomBaseController
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpPost]
        [Role(RoleEnums.RoleGroup.Product, (long)RoleEnums.ProductRoles.CreateProduct)]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductDto createProductDto)
        {
            var product = _mapper.Map<Product>(createProductDto);
            var result = await _productService.AddAsync(product);
            var response = _mapper.Map<ProductDto>(result);
            return response is not null
                ? CreateActionResult(Response<ProductDto>.Success(response, 200))
                : CreateActionResult(Response<NoContent>.Fail("Not created", 400));
        }

        [HttpPut]
        [Role(RoleEnums.RoleGroup.Product, (long)RoleEnums.ProductRoles.CreateProduct)]
        public async Task<IActionResult> UpdateProduct([FromBody] UpdateProductDto updateProductDto)
        {
            var product = _mapper.Map<Product>(updateProductDto);
            var result = await _productService.UpdateAsync(product);
            var response = _mapper.Map<ProductDto>(result);
            return response is not null
                ? CreateActionResult(Response<ProductDto>.Success(response, 200))
                : CreateActionResult(Response<NoContent>.Fail("Not created", 400));
        }

        [HttpDelete]
        [Role(RoleEnums.RoleGroup.Product, (long)RoleEnums.ProductRoles.CreateProduct)]
        public async Task<IActionResult> DeleteProduct(string productId)
        {
            var product = await _productService.GetAsync(x => x.Id.Equals(productId));
            if (product is null)
            {
                return CreateActionResult(Response<NoContent>.Fail("not found.", 404));
            }
            var result = await _productService.DeleteAsync(product);
            var response = _mapper.Map<ProductDto>(result);
            return response is not null
                ? CreateActionResult(Response<ProductDto>.Success(response, 200))
                : CreateActionResult(Response<NoContent>.Fail("Not deleted", 400));
        }

        [HttpGet]
        [Role(RoleEnums.RoleGroup.Product, (long)RoleEnums.ProductRoles.GetProduct)]
        public async Task<IActionResult> GetProduct(string productId)
        {
            var product = await _productService.GetAsync(x => x.Id.Equals(productId));
            var response = _mapper.Map<ProductDto>(product);
            return response is not null
               ? CreateActionResult(Response<ProductDto>.Success(response, 200))
               : CreateActionResult(Response<NoContent>.Fail("Not Found.", 404));
        }
    }
}
