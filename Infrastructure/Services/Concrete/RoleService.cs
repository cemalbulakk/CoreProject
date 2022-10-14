using Application.Features.Dtos.Role;
using Application.Services.Interfaces;
using AutoMapper;
using Common.Dtos;
using Domain.Contexts.Ef;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Repositories;

namespace Infrastructure.Services.Concrete;

public class RoleService : EfRepositoryBase<Role, AppDbContext>, IRoleService
{
    private readonly IMapper _mapper;
    public RoleService(AppDbContext context, IMapper mapper) : base(context)
    {
        _mapper = mapper;
    }

    public Response<RoleModel> GetRoleById(string userId, string roleGroupId, long bitwiseId)
    {
        var userRole = Context.UserRoles.Include(x => x.RoleGroup)
            .FirstOrDefault(ur => ur.UserId.Equals(userId) && ur.RoleGroupId.Equals(roleGroupId));

        if (userRole is null) return Response<RoleModel>.Fail("User role not found.", 404);
        {
            if (bitwiseId != (userRole.Roles & bitwiseId)) return Response<RoleModel>.Fail("role not found.", 404);
            var role = Context.Roles.FirstOrDefault(x => x.BitwiseId == bitwiseId);
            if (role is null) return Response<RoleModel>.Fail("role not found.", 404);
            var model = new RoleModel()
            {
                RoleId = role.Id,
                RoleName = role.Name,
                RoleGroupId = userRole.RoleGroupId,
                BitwiseId = bitwiseId,
                UserId = userId,
                RoleGroupName = userRole.RoleGroup.RoleGroupName
            };
            return Response<RoleModel>.Success(model, 200);
        }

    }

    public Response<List<RoleModel>> GetRoleListByGroupId(string userId, string roleGroupId)
    {
        var model = new List<RoleModel>();
        var userRole = Context.UserRoles.FirstOrDefault(ur => ur.UserId == userId && ur.RoleGroupId == roleGroupId);
        if (userRole == null) return Response<List<RoleModel>>.Success(model, 200);
        var allRoles = Context.Roles
            .Include(r => r.RoleGroup)
            .Where(r => r.RoleGroupId == roleGroupId).ToList();
        model.AddRange(from role in allRoles
                       where role.BitwiseId == (userRole.Roles & role.BitwiseId)
                       select new RoleModel()
                       {
                           RoleId = role.Id,
                           RoleName = role.Name,
                           RoleGroupId = role.RoleGroupId,
                           BitwiseId = role.BitwiseId,
                           UserId = userId,
                           RoleGroupName = role.RoleGroup.RoleGroupName
                       });

        return Response<List<RoleModel>>.Success(model, 200);
    }

    public async Task<Response<Role>> CreateRole(RoleCreateDto roleCreateDto)
    {
        try
        {
            var allRolesFromGroup = await Context.Roles.Where(x => x.RoleGroupId.Equals(roleCreateDto.RoleGroupId)).ToListAsync();
            if (!allRolesFromGroup.Any())
            {
                var newRole = new Role()
                {
                    BitwiseId = 1,
                    Name = roleCreateDto.Name,
                    RoleGroupId = roleCreateDto.RoleGroupId,
                    NormalizedName = roleCreateDto.Name.ToUpper()
                };
                var newRoleResult = await base.AddAsync(newRole);
                return Response<Role>.Success(newRoleResult, 200);
            }

            var lastRoleInGroup = allRolesFromGroup.OrderBy(x => x.BitwiseId).Last();

            var newRoleInGroup = new Role()
            {
                BitwiseId = lastRoleInGroup.BitwiseId * 2,
                Name = roleCreateDto.Name,
                RoleGroupId = roleCreateDto.RoleGroupId,
                NormalizedName = roleCreateDto.Name.ToUpper()
            };
            var newRoleInGroupResult = await base.AddAsync(newRoleInGroup);
            return Response<Role>.Success(newRoleInGroupResult, 200);
        }
        catch (Exception e)
        {
            return Response<Role>.Fail($"{e.Message} ..::.. {e.InnerException?.Message}", 500);
        }
    }
}