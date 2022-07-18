#nullable disable

using System.ComponentModel.DataAnnotations;

namespace WorkingWithDB.Models
{
    public class Song
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public TimeSpan Duration { get; set; }

        public DateTime ReleasedDate { get; set; }

        public virtual Genre Genre { get; set; }
        public int GenreId { get; set; }

        public virtual List<ArtistSong> ArtistSongs { get; set; }
    }
}
