using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly JwtTokenHelper _jwtTokenHelper;

        public AuthenticationController(JwtTokenHelper jwtTokenHelper)
        {
            _jwtTokenHelper = jwtTokenHelper;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest loginRequest)
        {
            // Verify user credentials
            var token = _jwtTokenHelper.GenerateJwtToken(user.Id.ToString(), user.Role);
            return Ok(new { token });
        }
    }

}
