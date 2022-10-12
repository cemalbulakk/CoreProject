using API.Filters;
using Application.Features.Dtos.User;
using Application.Requests;
using Application.Services.Interfaces;
using AutoMapper;
using Common.Attributes;
using Common.BaseController;
using Common.Dtos;
using Common.Enums;
using Common.Helpers;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Persistence.Paging;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [ServiceFilter(typeof(PermissionFilter))]
    public class UserController : CustomBaseController
    {
        private readonly UserManager<User> _userManager;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(UserManager<User> userManager, IMapper mapper, IUserService userService)
        {
            _userManager = userManager;
            _mapper = mapper;
            _userService = userService;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateUser([FromBody] UserCreateDto userCreateDto)
        {
            var user = _mapper.Map<User>(userCreateDto);
            var hashPassword = Helper.HashSha256(userCreateDto.Password);
            user.PasswordHash = hashPassword;
            var response = await _userManager.CreateAsync(user);
            return response.Succeeded
                ? CreateActionResult(Response<IdentityResult>.Success(response, 200))
                : CreateActionResult(Response<IdentityResult>.Fail(response.Errors.Select(x => x.Description).ToList(),
                    400));
        }

        [HttpGet]
        [RoleAttribute((int)RoleEnums.RoleGroup.User, (Int64)RoleEnums.UserRoles.Admin)]
        public async Task<IActionResult> GetUsers([FromQuery] PageRequest request)
        {
            var users = await _userService.GetListAsync(size: request.PageSize, index: request.Page);
            return CreateActionResult(Response<IPaginate<User>>.Success(users, 200));
        }
    }
}
