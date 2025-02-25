using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectJwtAndIdentity.Entities;

namespace ProjectJwtAndIdentity.Context
{
    public class MovieContext:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-32Q9FH5;initial catalog=IdentityMovieDb;integrated security=true;TrustServerCertificate=true");
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
