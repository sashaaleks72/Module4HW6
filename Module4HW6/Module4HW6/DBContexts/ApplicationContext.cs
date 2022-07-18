using Microsoft.EntityFrameworkCore;
using WorkingWithDB.Models;
using WorkingWithDB.Configs.DBConfigs;

namespace WorkingWithDB.DBContexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Artist> Artists { get; set; } = null!;

        public DbSet<Song> Songs { get; set; } = null!;

        public DbSet<Genre> Genres { get; set; } = null!;

        public DbSet<ArtistSong> ArtistSongs { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArtistConfiguration());
            modelBuilder.ApplyConfiguration(new SongConfiguration());
            modelBuilder.ApplyConfiguration(new GenreConfiguration());
            modelBuilder.ApplyConfiguration(new ArtistSongConfiguration());
        }
    }
}
