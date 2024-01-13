using Microsoft.AspNetCore.Mvc;

namespace BahanKiSadi_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost(Name = "Register")]
        public IActionResult Register()
        {
            return null;
        }
    }
}
