using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetClinicApp.Models;

namespace PetClinicApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Owner> Owner { get; set; }
        public DbSet<Pet> Pet { get; set; }
        public DbSet<Vaccine> Vaccine { get; set; }
    }
}
