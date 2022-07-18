using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkingWithDB.Models;

namespace WorkingWithDB.Configs.DBConfigs
{
    public class ArtistSongConfiguration : IEntityTypeConfiguration<ArtistSong>
    {
        public void Configure(EntityTypeBuilder<ArtistSong> builder)
        {
            builder.HasData(
                new ArtistSong
                {
                    Id = 1,
                    ArtistId = 1,
                    SongId = 1
                },
                new ArtistSong
                {
                    Id = 2,
                    ArtistId = 2,
                    SongId = 2
                },
                new ArtistSong
                {
                    Id = 3,
                    ArtistId = 3,
                    SongId = 3
                });
        }
    }
}
