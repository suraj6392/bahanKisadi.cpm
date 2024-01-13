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
            RegistrationDetails registrationDetails = new RegistrationDetails()
            {
                Id = Guid.NewGuid(),
                Name = detailsViewModel.Name,
                MiddileName = detailsViewModel.MiddileName,
                SurName = detailsViewModel.SurName,
                Address = detailsViewModel.Address,
                MobileNo = detailsViewModel.MobileNo,
            };
            var result = _dataContext.Add(registrationDetails);
            _dataContext.SaveChanges();
            return Ok(result);
        }
    }
}
