namespace WorkingWithDB.Models
{
    public class ArtistSong
    {
        public int Id { get; set; }

        public virtual Artist? Artists { get; set; }
        public int ArtistId { get; set; }

        public virtual Song? Songs { get; set; }
        public int SongId { get; set; }
    }
}
