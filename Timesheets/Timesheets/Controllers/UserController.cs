using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TS.Services;

namespace Timesheets.Controllers
{
   // [ApiController]
    [AllowAnonymous]
    [Route("api/user")]
    
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromQuery] string user, string password)
        {
            string token = _userService.Authenticate(user, password);
            if (string.IsNullOrWhiteSpace(token))
            {
                return BadRequest(new {message = "Username or password is incorrect"});
            }
            return Ok(token);
        }
    }
}