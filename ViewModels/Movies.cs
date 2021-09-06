using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidlyy.Models;

namespace vidlyy.ViewModels
{
    public class Movies
    {
        public List<Movie> movies { get; set; }
        public Movies()
        {
            movies = new List<Movie>()
            {
                new Movie{Id= 1, Name = "sherk !"},
                new Movie{Id = 2,Name = "Your Name"}
            };

        }
    }
}