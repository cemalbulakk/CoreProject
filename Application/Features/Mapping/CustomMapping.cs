﻿using Application.Features.Dtos.User;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Mapping;

public class CustomMapping : Profile
{
    public CustomMapping()
    {
        CreateMap<ApplicationUser, CreateUserDto>().ReverseMap();
        CreateMap<ApplicationUser, UserDto>().ReverseMap();
    }
}