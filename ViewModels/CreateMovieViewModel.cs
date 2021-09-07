using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidlyy.Models;

namespace vidlyy.ViewModels
{
    public class CreateMovieViewModel
    {
        public Movie  movie { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}