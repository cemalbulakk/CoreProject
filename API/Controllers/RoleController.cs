using Application.Services.Interfaces;
using Common.BaseController;
using Common.Dtos;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Application.Features.Dtos.Role;
using AutoMapper;
using Application.Features.Dtos.RoleGroup;
using Application.Features.Dtos.UserRole;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RoleController : CustomBaseController
    {
        private readonly IRoleService _roleService;
        private readonly IRoleGroupService _roleGroupService;
        private readonly IUserRoleService _userRoleService;
        private readonly IMapper _mapper;

        public RoleController(IRoleService roleService, IRoleGroupService roleGroupService, IUserRoleService userRoleService, IMapper mapper)
        {
            _roleService = roleService;
            _roleGroupService = roleGroupService;
            _userRoleService = userRoleService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleCreateDto roleCreateDto)
        {
            var response = await _roleService.CreateRole(roleCreateDto);
            return CreateActionResult(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoleGroup(RoleGroupCreateDto roleGroupCreateDto)
        {
            var roleGroup = _mapper.Map<RoleGroup>(roleGroupCreateDto);
            var response = await _roleGroupService.AddAsync(roleGroup);
            return CreateActionResult(Response<RoleGroup>.Success(response, 200));
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserRole(UserRoleCreateDto userRoleCreateDto)
        {
            var response = await _userRoleService.AssignRoleToUser(userRoleCreateDto);
            return CreateActionResult(response);
        }
    }
}
