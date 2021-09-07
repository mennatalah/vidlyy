using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vidlyy.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DataRelase { get; set; }
        public DateTime DateAdd { get; set; }
        public int NumberInStock { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}