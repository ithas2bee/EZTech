using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace EZTech.Models
{
    public class Movie
    {
        public int MovieID { get; set; }

        [Required(ErrorMessage = "Movie title is required.")]
        [StringLength(200, ErrorMessage = "Movie title cannot exceed 200 characters.")]
        public string Title { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string Description { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Genre")]
        [StringLength(50, ErrorMessage = "Genre cannot exceed 50 characters.")]
        public string Genre { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Price must be a non-negative number.")]
        public decimal Price { get; set; }

        [StringLength(500, ErrorMessage = "Cast members cannot exceed 500 characters.")]
        public string Cast { get; set; }
        public string Rating { get; set; }

    }
}