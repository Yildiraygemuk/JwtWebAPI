using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JwtWebAPI.Models;
using JwtWebAPI.Services;

namespace JwtWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(UserDto request)
        {
            var result = _authService.Register(request);
            return Ok(result);
        }
        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(UserDto request)
        {
            var token = _authService.Login(request);
            return Ok(token);
        }
    }
}
