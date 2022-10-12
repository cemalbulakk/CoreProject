using Application.Features.Dtos.Role;
using Application.Services.Interfaces;
using Common.Dtos;
using Domain.Contexts.Ef;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Repositories;

namespace Infrastructure.Services.Concrete;

public class RoleService : EfRepositoryBase<Role, AppDbContext>, IRoleService
{
    public RoleService(AppDbContext context) : base(context)
    {
    }

    public Response<RoleModel> GetRoleById(string userId, int roleGroupId, long bitwiseId)
    {
        var userRole = Context.UserRoles.Include(x => x.RoleGroup)
            .FirstOrDefault(ur => ur.UserId.Equals(userId) && ur.RoleGroupId.Equals(roleGroupId));

        if (userRole is null) return Response<RoleModel>.Fail("User role not found.", 404);
        {
            if (bitwiseId != (userRole.Roles & bitwiseId)) return Response<RoleModel>.Fail("role not found.", 404);
            var role = Context.Roles.FirstOrDefault(x => x.BitwiseId == bitwiseId);
            if (role is not null)
            {
                var model = new RoleModel()
                {
                    RoleId = role.Id,
                    RoleName = role.RoleName,
                    RoleGroupId = userRole.RoleGroupId,
                    BitwiseId = bitwiseId,
                    UserId = userId,
                    RoleGroupName = userRole.RoleGroup.RoleGroupName
                };
                return Response<RoleModel>.Success(model, 200);
            }
            else
            {
                return Response<RoleModel>.Fail("role not found.", 404);
            }

        }

    }

    public Response<List<RoleModel>> GetRoleListByGroupId(string userId, int roleGroupId)
    {
        var model = new List<RoleModel>();
        var userRole = Context.UserRoles.FirstOrDefault(ur => ur.UserId == userId && ur.RoleGroupId == roleGroupId);
        if (userRole != null)
        {
            var allRoles = Context.Roles
                .Include(r => r.RoleGroup)
                .Where(r => r.RoleGroupId == roleGroupId).ToList();
            model.AddRange(from role in allRoles
                           where role.BitwiseId == (userRole.Roles & role.BitwiseId)
                           select new RoleModel()
                           {
                               RoleId = role.Id,
                               RoleName = role.RoleName,
                               RoleGroupId = role.RoleGroupId,
                               BitwiseId = role.BitwiseId,
                               UserId = userId,
                               RoleGroupName = role.RoleGroup.RoleGroupName
                           });
        }

        return Response<List<RoleModel>>.Success(model, 200);
    }
}