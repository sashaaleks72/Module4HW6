using System.ComponentModel.DataAnnotations;

namespace WorkingWithDB.Models
{
    public class Artist
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public string? InstagramUrl { get; set; }

        public virtual List<ArtistSong>? ArtistSongs { get; set; }
    }
}
