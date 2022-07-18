﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorkingWithDB.DBContexts;

#nullable disable

namespace Module4HW6.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WorkingWithDB.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("InstagramUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Phone")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.HasKey("Id");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(1979, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "luke_pheophan12@yahoo.com",
                            InstagramUrl = "https://www.instagram.com/artist1/",
                            Name = "Luke Pheophan",
                            Phone = "+380505671276"
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(1968, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "bill_rolins_1968@yahoo.com",
                            InstagramUrl = "https://www.instagram.com/artist2/",
                            Name = "Bill Rolins",
                            Phone = "+380984561276"
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "daniel_blond1245@yahoo.com",
                            InstagramUrl = "https://www.instagram.com/artist3/",
                            Name = "Daniel Blond",
                            Phone = "+380689861345"
                        });
                });

            modelBuilder.Entity("WorkingWithDB.Models.ArtistSong", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("SongId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("SongId");

                    b.ToTable("ArtistSongs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtistId = 1,
                            SongId = 1
                        },
                        new
                        {
                            Id = 2,
                            ArtistId = 2,
                            SongId = 2
                        },
                        new
                        {
                            Id = 3,
                            ArtistId = 3,
                            SongId = 3
                        });
                });

            modelBuilder.Entity("WorkingWithDB.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Pop"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Rock"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Club"
                        },
                        new
                        {
                            Id = 4,
                            Title = "Dance"
                        });
                });

            modelBuilder.Entity("WorkingWithDB.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleasedDate")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Duration = new TimeSpan(0, 3, 47, 45, 0),
                            GenreId = 4,
                            ReleasedDate = new DateTime(2015, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Dance music"
                        },
                        new
                        {
                            Id = 2,
                            Duration = new TimeSpan(0, 2, 59, 37, 0),
                            GenreId = 1,
                            ReleasedDate = new DateTime(2018, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pop music"
                        },
                        new
                        {
                            Id = 3,
                            Duration = new TimeSpan(0, 4, 49, 12, 0),
                            GenreId = 3,
                            ReleasedDate = new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Club music"
                        });
                });

            modelBuilder.Entity("WorkingWithDB.Models.ArtistSong", b =>
                {
                    b.HasOne("WorkingWithDB.Models.Artist", "Artists")
                        .WithMany("ArtistSongs")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WorkingWithDB.Models.Song", "Songs")
                        .WithMany("ArtistSongs")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artists");

                    b.Navigation("Songs");
                });

            modelBuilder.Entity("WorkingWithDB.Models.Song", b =>
                {
                    b.HasOne("WorkingWithDB.Models.Genre", "Genre")
                        .WithMany("Songs")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("WorkingWithDB.Models.Artist", b =>
                {
                    b.Navigation("ArtistSongs");
                });

            modelBuilder.Entity("WorkingWithDB.Models.Genre", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("WorkingWithDB.Models.Song", b =>
                {
                    b.Navigation("ArtistSongs");
                });
#pragma warning restore 612, 618
        }
    }
}
