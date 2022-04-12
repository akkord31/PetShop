using Microsoft.EntityFrameworkCore;
using PetShop.Models;

namespace PetShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options) {

        }

        public DbSet<Category> Category { get; set; }  //tables in DB
        public DbSet<Pet> Pet { get; set; }
    }
}
