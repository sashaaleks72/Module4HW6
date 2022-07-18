using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkingWithDB.Models;

namespace WorkingWithDB.Configs.DBConfigs
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.Property(a => a.Email).HasMaxLength(100);
            builder.Property(a => a.Name).HasMaxLength(30);
            builder.Property(a => a.Phone).HasMaxLength(14);
            builder.Property(a => a.DateOfBirth).HasColumnType("date");

            builder.HasData(
                new Artist
                {
                    Id = 1,
                    DateOfBirth = new DateTime(1979, 1, 28),
                    InstagramUrl = "https://www.instagram.com/artist1/",
                    Name = "Luke Pheophan",
                    Email = "luke_pheophan12@yahoo.com",
                    Phone = "+380505671276",
                },
                new Artist
                {
                    Id = 2,
                    DateOfBirth = new DateTime(1968, 5, 19),
                    InstagramUrl = "https://www.instagram.com/artist2/",
                    Name = "Bill Rolins",
                    Email = "bill_rolins_1968@yahoo.com",
                    Phone = "+380984561276",
                },
                new Artist
                {
                    Id = 3,
                    DateOfBirth = new DateTime(1985, 6, 12),
                    InstagramUrl = "https://www.instagram.com/artist3/",
                    Name = "Daniel Blond",
                    Email = "daniel_blond1245@yahoo.com",
                    Phone = "+380689861345",
                });
        }
    }
}
