using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkingWithDB.Models;

namespace WorkingWithDB.Configs.DBConfigs
{
    internal class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.Property(g => g.Title).HasMaxLength(50);

            builder.HasData(
                new Genre
                {
                    Id = 1,
                    Title = "Pop"
                },
                new Genre
                {
                    Id = 2,
                    Title = "Rock"
                },
                new Genre
                {
                    Id = 3,
                    Title = "Club",
                },
                new Genre
                {
                    Id = 4,
                    Title = "Dance",
                });
        }
    }
}
