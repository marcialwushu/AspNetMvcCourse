using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {

        public IEnumerable<Genre> Genres { get; set; }
        public int? Id { get; set; }
        public string Name { get; set; }
        public byte? GenreId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public byte? NumberInStock { get; set; }

        public MovieFormViewModel()
        {
            Id = 0;
        }


        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }

    

}