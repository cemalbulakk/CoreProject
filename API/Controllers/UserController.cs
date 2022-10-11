using Application.Requests;
using Application.Services.Interfaces;
using Common.BaseController;
using Common.Dtos;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Persistence.Paging;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : CustomBaseController
    {
        private readonly IApplicationUserService _userService;

        public UserController(IApplicationUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Users([FromQuery] PageRequest request)
        {
            var response = await _userService.GetListAsync(index: request.Page, size: request.PageSize);
            return CreateActionResult(Response<IPaginate<ApplicationUser>>.Success(response, 200));
        }
    }
}
