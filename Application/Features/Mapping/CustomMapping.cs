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
    }
}