using Microsoft.EntityFrameworkCore;

namespace Movies.Api.Data
{
    public class MoviesApiContext : DbContext
    {
        public MoviesApiContext (DbContextOptions<MoviesApiContext> options) : base(options)
        {
        }

        public DbSet<Movies.Api.Entities.Movie> Movie { get; set; }
    }
}
