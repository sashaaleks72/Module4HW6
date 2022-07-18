using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkingWithDB.Models;

namespace WorkingWithDB.Configs.DBConfigs
{
    public class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.Property(s => s.Title).HasMaxLength(100);
            builder.Property(s => s.ReleasedDate).HasColumnType("date");
            builder.Property(s => s.Duration).HasColumnType("time");

            builder.HasData(
                new Song
                {
                    Id = 1,
                    Duration = new TimeSpan(3, 47, 45),
                    Title = "Dance music",
                    ReleasedDate = new DateTime(1966, 2, 16),
                    GenreId = 4
                },
                new Song
                {
                    Id = 2,
                    Duration = new TimeSpan(2, 59, 37),
                    Title = "Pop music",
                    ReleasedDate = new DateTime(2018, 5, 1),
                    GenreId = 1
                },
                new Song
                {
                    Id = 3,
                    Duration = new TimeSpan(4, 49, 12),
                    Title = "Club music",
                    ReleasedDate = new DateTime(2022, 4, 28),
                    GenreId = 3
                });
        }
    }
}
