using Application.Features.Dtos.User;
using Application.Requests;
using Application.Services.Interfaces;
using AutoMapper;
using Common.BaseController;
using Common.Dtos;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Persistence.Paging;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : CustomBaseController
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers([FromQuery] PageRequest request)
        {
            try
            {
                var response = await _userService.GetListAsync(x => x.IsActive && !x.IsDelete, null, null, request.Page,
                    request.PageSize);

                return CreateActionResult(Response<IPaginate<User>>.Success(response, 200));
            }
            catch (Exception e)
            {
                return CreateActionResult(Response<NoContent>.Fail(e.Message, 500));
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] CreateUserDto createUserDto)
        {
            try
            {
                var user = _mapper.Map<User>(createUserDto);
                var response = await _userService.AddAsync(user);
                var addedUser = _mapper.Map<UserDto>(response);
                return CreateActionResult(Response<UserDto>.Success(addedUser, 200));
            }
            catch (Exception e)
            {
                return CreateActionResult(Response<NoContent>.Fail(e.Message, 500));
            }
        }
    }
}
