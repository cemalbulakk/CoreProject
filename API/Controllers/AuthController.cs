using Application.Features.Dtos.Auth;
using Application.Services.Interfaces;
using Common.BaseController;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : CustomBaseController
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(AuthDto authDto)
        {
            var response = await _authService.Auth(authDto);
            return CreateActionResult(response);
        }

        [HttpPost]
        public async Task<IActionResult> Refresh(TokenApiModel tokenApiModel)
        {
            var response = await _authService.RefreshToken(tokenApiModel);
            return CreateActionResult(response);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _authService.Revoke(User.Identity?.Name ?? throw new InvalidOperationException());
            await HttpContext.SignOutAsync();
            return Ok();
        }
    }
}
