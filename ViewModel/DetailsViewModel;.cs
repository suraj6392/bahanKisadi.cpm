using BahanKiSadi_backend.Model;

namespace BahanKiSadi_backend.ViewModel
{
    public class DetailsViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public long MobileNo { get; set; }
        public string Password { get; set; }
    }
}
