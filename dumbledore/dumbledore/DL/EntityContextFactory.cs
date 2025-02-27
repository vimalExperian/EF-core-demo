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

    public class ReviewContextFactory : IDesignTimeDbContextFactory<ReviewContext>
    {

        public ReviewContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ReviewContext>();
            optionsBuilder.UseSqlite("Data Source=main.db");

            return new ReviewContext(optionsBuilder.Options);
        }
    }

    public class CreewContextFactory : IDesignTimeDbContextFactory<CrewContext>
    {

        public CrewContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CrewContext>();
            optionsBuilder.UseSqlite("Data Source=main.db");

            return new CrewContext(optionsBuilder.Options);
        }
    }
}
