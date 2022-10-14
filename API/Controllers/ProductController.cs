using API.Filters;
using Application.Features.Dtos.Products;
using Application.Requests;
using Application.Services.Interfaces;
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

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        [Role(RoleEnums.RoleGroup.Product, (long)RoleEnums.ProductRoles.CreateProduct)]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductDto createProductDto)
        {
            var response = await _productService.CreateProduct(createProductDto);
            return CreateActionResult(response);
        }

        [HttpPut]
        [Role(RoleEnums.RoleGroup.Product, (long)RoleEnums.ProductRoles.CreateProduct)]
        public async Task<IActionResult> UpdateProduct([FromBody] UpdateProductDto updateProductDto)
        {
            var response = await _productService.UpdateProduct(updateProductDto);
            return CreateActionResult(response);
        }

        [HttpDelete]
        [Role(RoleEnums.RoleGroup.Product, (long)RoleEnums.ProductRoles.CreateProduct)]
        public async Task<IActionResult> DeleteProduct(string productId)
        {
            return CreateActionResult(await _productService.DeleteProduct(productId));
        }

        [HttpGet]
        [Role(RoleEnums.RoleGroup.Product, (long)RoleEnums.ProductRoles.GetProduct)]
        public async Task<IActionResult> GetProduct(string productId)
        {
            return CreateActionResult(await _productService.GetProduct(productId));
        }

        [HttpPost]
        [Role(RoleEnums.RoleGroup.Product, (long)RoleEnums.ProductRoles.GetProduct)]
        public async Task<IActionResult> GetProductList([FromBody] PageRequest request)
        {
            var response = await _productService.GetProducts(request);
            return CreateActionResult(response);
        }
    }
}
