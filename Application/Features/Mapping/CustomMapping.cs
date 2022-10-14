using Application.Features.Dtos.Category;
using Application.Features.Dtos.Products;
using Application.Features.Dtos.Role;
using Application.Features.Dtos.RoleGroup;
using Application.Features.Dtos.User;
using Application.Features.Dtos.UserRole;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Mapping;

public class CustomMapping : Profile
{
    public CustomMapping()
    {
        CreateMap<UserCreateDto, User>().ReverseMap();
        CreateMap<RoleCreateDto, Role>().ReverseMap();
        CreateMap<UserRoleCreateDto, UserRole>().ReverseMap();
        CreateMap<RoleGroupCreateDto, RoleGroup>().ReverseMap();

        #region Product

        CreateMap<Product, ProductDto>().ReverseMap();
        CreateMap<CreateProductDto, Product>().ReverseMap();
        CreateMap<UpdateProductDto, Product>().ReverseMap();

        #endregion

        #region Category

        CreateMap<Category, CategoryDto>().ReverseMap();
        CreateMap<CreateCategoryDto, Category>().ReverseMap();
        CreateMap<UpdateCategoryDto, Category>().ReverseMap();

        #endregion

        #region Role

        CreateMap<RoleCreateDto, Role>().ReverseMap();

        #endregion
    }
}