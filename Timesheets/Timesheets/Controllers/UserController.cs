using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TS.Data.Model;
using TS.Services;
using TS.Validation;

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
            UserValidationService userValidationService = new UserValidationService();
            Users userV = new Users();
            userV.login = user;
            userV.passwd = password;
            ValidationResult result = userValidationService.Validate(userV);
            if (result.IsValid)
            {
                string token = _userService.Authenticate(user, password);
                if (string.IsNullOrWhiteSpace(token))
                {
                    return BadRequest(new {message = "Username or password is incorrect"});
                }
                return Ok(token);
            }

            foreach (ValidationFailure failure in result.Errors)
            {
                return Problem($"{failure.ErrorCode} = {failure.PropertyName} {failure.ErrorMessage}");
            }
            return Problem("Вообще все сломалось....");
        }
    }
}