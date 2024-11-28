using Microsoft.EntityFrameworkCore;
using Movies4UFree.Models; // Include models here.

namespace Movies4UFree.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; } // Add your entities here.
    }
}