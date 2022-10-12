using Application.Features.Dtos.UserRole;
using Application.Services.Interfaces;
using Common.Dtos;
using Domain.Contexts.Ef;
using Domain.Entities;
using Persistence.Repositories;

namespace Infrastructure.Services.Concrete;

public class UserRoleService : EfRepositoryBase<UserRole, AppDbContext>, IUserRoleService
{
    public UserRoleService(AppDbContext context) : base(context)
    {
    }

    public async Task<Response<UserRole>> AssignRoleToUser(UserRoleCreateDto userRoleCreateDto)
    {
        var role = Context.Roles.FirstOrDefault(x => x.Id.Equals(userRoleCreateDto.RoleId));
        if (role == null)
        {
            return Response<UserRole>.Fail("Role not found.", 404);
        }
        var userRole = Context.UserRoles.FirstOrDefault(x =>
            x.UserId.Equals(userRoleCreateDto.UserId) && x.RoleGroupId.Equals(role.RoleGroupId));
        if (userRole == null)
        {
            var newUserRole = new UserRole()
            {
                Roles = role.BitwiseId,
                UserId = userRoleCreateDto.UserId,
                RoleGroupId = role.RoleGroupId,
            };
            var result = await base.AddAsync(newUserRole);
            return Response<UserRole>.Success(result, 200);
        }

        userRole.Roles += role.BitwiseId;
        var updateResult = await base.UpdateAsync(userRole);
        return Response<UserRole>.Success(updateResult, 200);
    }

    
}