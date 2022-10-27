using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CO550_ASP_Razor_Pages_Movies.Models;

namespace CO550_ASP_Razor_Pages_Movies.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CO550_ASP_Razor_Pages_Movies.Models.Movie> Movie { get; set; }
    }
}