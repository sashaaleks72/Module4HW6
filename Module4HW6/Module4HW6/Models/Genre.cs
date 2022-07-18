#nullable disable

using System.ComponentModel.DataAnnotations;

namespace WorkingWithDB.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        
        public virtual List<Song> Songs { get; set; }
    }
}
