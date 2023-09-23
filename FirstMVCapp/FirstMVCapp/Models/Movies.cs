using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

    public class Movies
    {
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Title is required")]
    [StringLength(255, ErrorMessage = "Title must be less than 255 characters")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Language is required")]
    [StringLength(50, ErrorMessage = "Language must be less than 50 characters")]
    public string Language { get; set; }

    [Required(ErrorMessage = "Hero is required")]
    [StringLength(100, ErrorMessage = "Hero must be less than 100 characters")]
    public string Hero { get; set; }

    [Required(ErrorMessage = "Director is required")]
    [StringLength(100, ErrorMessage = "Director must be less than 100 characters")]
    public string Director { get; set; }

    [Required(ErrorMessage = "MusicDirector is required")]
    [StringLength(100, ErrorMessage = "MusicDirector must be less than 100 characters")]
    public string MusicDirector { get; set; }

    [Required(ErrorMessage = "Release Date is required")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime ReleaseDate { get; set; }

    [Required(ErrorMessage = "Cost is required")]
    [Range(0.01, double.MaxValue, ErrorMessage = "Cost must be greater than 0")]
    public decimal Cost { get; set; }

    [Required(ErrorMessage = "Collection is required")]
    [Range(0.01, double.MaxValue, ErrorMessage = "Collection must be greater than 0")]
    public decimal Collection { get; set; }

    [Required(ErrorMessage = "Review is required")]
    [Range(0.0, 10.0, ErrorMessage = "Review must be between 0.0 and 10.0")]
    public decimal Review { get; set; }
}



