using System.ComponentModel.DataAnnotations;

namespace WebAppBooks.Models
{
    public class BookModel
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Title data is required")]
        [StringLength(50, ErrorMessage = "The title is too long, only 50 characters.", MinimumLength =5)]
        [Display(Name = "Title")]
        public string? title { get; set; }

        [Required(ErrorMessage = "Description data is required")]
        [Display(Name = "Description")]
        public string? description { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime? date { get; set; }

        [Required(ErrorMessage = "Author data is required")]
        [StringLength(100, ErrorMessage = "The Author is too long, only 100 characters", MinimumLength = 3)]
        [Display(Name = "Author")]
        public string? autor { get; set; }

        [Required(ErrorMessage = "Price data is required")]
        [Display(Name = "Price")]
        public Double? precio { get; set; }
    }
}
