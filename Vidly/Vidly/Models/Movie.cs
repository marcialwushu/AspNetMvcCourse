﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime ReleaseDate { get; internal set; }
        public byte? NumberInStock { get; internal set; }
        public byte? GenreId { get; internal set; }
    }
}