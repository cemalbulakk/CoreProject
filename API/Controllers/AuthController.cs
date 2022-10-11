using Application.Features.Dtos.Auth;
using Application.Services.Interfaces;
using Common.BaseController;
using Domain.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : CustomBaseController
    {
        private readonly IAuthService _authService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IApplicationUserService _userService;

        public AuthController(IAuthService authService, UserManager<ApplicationUser> userManager, IApplicationUserService userService)
        {
            _authService = authService;
            _userManager = userManager;
            _userService = userService;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Auth(AuthDto auth)
        {
            var response = await _authService.Auth(auth);
            return CreateActionResult(response);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            var response = await _authService.Register(registerDto);
            return CreateActionResult(response);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            //var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var user = await _userManager.FindByEmailAsync(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            var response = await _authService.Logout(user);
            await HttpContext.SignOutAsync();
            return CreateActionResult(response);
        }
    }
}
