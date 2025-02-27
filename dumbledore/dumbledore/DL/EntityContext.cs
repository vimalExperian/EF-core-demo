using dumbledore.DL.Entity;
using Microsoft.EntityFrameworkCore;

namespace dumbledore.DL
{
    public class MovieContext: DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<MovieEntity> Movie => Set<MovieEntity>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<MovieEntity>()
            .HasMany(x => x.Crew)
            .WithOne(x => x.Movie)
            .HasForeignKey(x => x.MovieId);
        }
    }

    public class CrewContext: DbContext
    {
        public CrewContext(DbContextOptions<CrewContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<CrewEntity> Crew => Set<CrewEntity>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }


    public class ReviewContext: DbContext
    {
        public ReviewContext(DbContextOptions<ReviewContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<ReviewEntity> Review => Set<ReviewEntity>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReviewEntity>()
                .HasOne(x => x.Movie)
                .WithMany(x => x.Review)
                .HasForeignKey(x => x.MovieId);
        }

    }

  
}
