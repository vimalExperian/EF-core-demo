using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace dumbledore.DL
{
    public class MovieContextFactory: IDesignTimeDbContextFactory<MovieContext>
    {
     
        public MovieContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MovieContext>();
            optionsBuilder.UseSqlite("Data Source=main.db");

            return new MovieContext(optionsBuilder.Options);
        }
    }
}
