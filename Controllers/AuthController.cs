using BahanKiSadi_backend.Context;
using BahanKiSadi_backend.Helper;
using BahanKiSadi_backend.Model;
using Microsoft.AspNetCore.Mvc;

namespace BahanKiSadi_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly DataContext _dataContext;
        private readonly IConfiguration _configuration;
        public AuthController(DataContext dataContext, IConfiguration configuration)
        {
            _dataContext = dataContext;
            _configuration = configuration;
        }
        [HttpPost]
        public IActionResult Login([FromBody] User user)
        {
            var result = _dataContext.RegistrationDetails
                .Where(c => c.Email == user.UserEmail && c.Password == user.Password)
                .FirstOrDefault();
            if (result == null)
            {
                return BadRequest("User Does't Exist Please Register First..");
            }
            var details = _dataContext.RegistrationDetails
             .FirstOrDefault(c => c.Email == user.UserEmail && c.Password == user.Password);
            var gettoken = TokenHelper.GenerateToken(_configuration);
            return Ok(new { detail = details, token = gettoken, message = "User Login Successfully..." });
        }
    }
}
