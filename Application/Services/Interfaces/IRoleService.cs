using Application.Features.Dtos.Role;
using Common.Dtos;
using Domain.Entities;
using Persistence.Repositories;

namespace Application.Services.Interfaces;

public interface IRoleService : IAsyncRepository<Role>, IRepository<Role>
{
    public Response<RoleModel> GetRoleById(string userId, int roleGroupId, long bitwiseId);
    public Response<List<RoleModel>> GetRoleListByGroupId(string userId, int roleGroupId);
    public Task<Response<Role>> CreateRole(RoleCreateDto roleCreateDto);
}