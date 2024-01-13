using BahanKiSadi_backend.Context;
using BahanKiSadi_backend.Model;
using BahanKiSadi_backend.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BahanKiSadi_backend.Controllers
{
    [Route("v1")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public AccountController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        [HttpPost("Register")]
        public IActionResult Register([FromBody] DetailsViewModel detailsViewModel)
        {
            try
            {
                RegistrationDetails registrationDetails = new RegistrationDetails()
                {
                    Id = Guid.NewGuid(),
                    Name = detailsViewModel.Name,
                    SurName = detailsViewModel.SurName,
                    Address = detailsViewModel.Address,
                    MobileNo = detailsViewModel.MobileNo,
                    Email = detailsViewModel.Email,
                    Password = detailsViewModel.Password,

                };
                var result = _dataContext.Add(registrationDetails);
                _dataContext.SaveChanges();
                return Ok("Registered Succesfully..");
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = "Error registering user", Error = ex.Message });
            }
        }
    }
}
