using System.ComponentModel.DataAnnotations;

namespace CO550_ASP_Razor_Pages_Movies.Models
{
    public enum Genres
    {
        Action, Comedy, Drama, Horror, Romance
    }
    public class Movie
    {
        [Key]
        public int ID { get; set; }

        [StringLength(60), Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public Genres Genre { get; set; }
        public decimal Price { get; set; }
    }
}
