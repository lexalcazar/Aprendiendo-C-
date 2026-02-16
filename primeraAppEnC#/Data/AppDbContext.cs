using Microsoft.EntityFrameworkCore;
using primeraAppEnC_.Models;

namespace primeraAppEnC_.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Persona> Personas { get; set; }
    }
}

