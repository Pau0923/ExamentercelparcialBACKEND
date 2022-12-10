using Microsoft.EntityFrameworkCore;

namespace Examen_Tercer_Parcial.models
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }

        public DbSet < datos > Datos { get; set; } 

    }
}
