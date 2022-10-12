using Application.Features.Dtos.UserRole;
using Common.Dtos;
using Domain.Entities;
using Persistence.Repositories;

namespace Application.Services.Interfaces;

public interface IUserRoleService : IAsyncRepository<UserRole>, IRepository<UserRole>
{
    public Task<Response<UserRole>> AssignRoleToUser(UserRoleCreateDto userRoleCreateDto);
}