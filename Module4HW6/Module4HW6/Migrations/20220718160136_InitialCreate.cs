using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Module4HW6.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    InstagramUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false),
                    ReleasedDate = table.Column<DateTime>(type: "date", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Songs_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtistSongs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    SongId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistSongs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArtistSongs_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistSongs_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "DateOfBirth", "Email", "InstagramUrl", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(1979, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "luke_pheophan12@yahoo.com", "https://www.instagram.com/artist1/", "Luke Pheophan", "+380505671276" },
                    { 2, new DateTime(1968, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "bill_rolins_1968@yahoo.com", "https://www.instagram.com/artist2/", "Bill Rolins", "+380984561276" },
                    { 3, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "daniel_blond1245@yahoo.com", "https://www.instagram.com/artist3/", "Daniel Blond", "+380689861345" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Pop" },
                    { 2, "Rock" },
                    { 3, "Club" },
                    { 4, "Dance" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Duration", "GenreId", "ReleasedDate", "Title" },
                values: new object[] { 1, new TimeSpan(0, 3, 47, 45, 0), 4, new DateTime(2015, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dance music" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Duration", "GenreId", "ReleasedDate", "Title" },
                values: new object[] { 2, new TimeSpan(0, 2, 59, 37, 0), 1, new DateTime(2018, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pop music" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Duration", "GenreId", "ReleasedDate", "Title" },
                values: new object[] { 3, new TimeSpan(0, 4, 49, 12, 0), 3, new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Club music" });

            migrationBuilder.InsertData(
                table: "ArtistSongs",
                columns: new[] { "Id", "ArtistId", "SongId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "ArtistSongs",
                columns: new[] { "Id", "ArtistId", "SongId" },
                values: new object[] { 2, 2, 2 });

            migrationBuilder.InsertData(
                table: "ArtistSongs",
                columns: new[] { "Id", "ArtistId", "SongId" },
                values: new object[] { 3, 3, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_ArtistSongs_ArtistId",
                table: "ArtistSongs",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistSongs_SongId",
                table: "ArtistSongs",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_GenreId",
                table: "Songs",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtistSongs");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
