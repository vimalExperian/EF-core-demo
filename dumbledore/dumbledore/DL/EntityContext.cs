using dumbledore.DL.Entity;
using Microsoft.EntityFrameworkCore;

namespace dumbledore.DL
{
    public class MovieContext: DbContext
    {
        public MovieContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<MovieEntity> Movies => Set<MovieEntity>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieEntity>()
                .HasIndex(x => x.ID)
                .IsUnique();

            modelBuilder.Entity<MovieEntity>()
            .HasMany(x => x.Crew)
            .WithOne(x => x.Movie)
            .HasForeignKey(x => x.MovieId);
        }

    }

  
}
