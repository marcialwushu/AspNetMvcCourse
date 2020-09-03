using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId { get; internal set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; internal set; }

        [Display(Name = "Number In Stock")]
        [Range(1, 20)]
        public byte? NumberInStock { get; internal set; }
        
        public DateTime DateAdded { get; set; }
        public byte NumberAvailable { get; set; }
    }
}