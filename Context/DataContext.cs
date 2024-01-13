

using BahanKiSadi_backend.Model;
using Microsoft.EntityFrameworkCore;

namespace BahanKiSadi_backend.Context
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {
            
        }

        public DbSet<RegistrationDetails> RegistrationDetails { get; set; }
    }
}
