using System.ComponentModel.DataAnnotations;

namespace LibApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter the title of the book")]
        [StringLength(100)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter the Author name")]
        public string Author { get; set; }
        public Genre Genre { get; set; }
        [Required(ErrorMessage = "Please choose the book genre")]
        public int GenreId { get; set; }
        public DateTime DateAdded { get; set; }
        [Required(ErrorMessage ="Please enter release date")]
        public DateTime ReleaseDate { get; set; }
        [Required(ErrorMessage ="Please enter number in stock ")]
        [Range(1, 20, ErrorMessage ="Please enter a number between 1 and 20")]
        public byte NumberInStock { get; set; }
    }
}
