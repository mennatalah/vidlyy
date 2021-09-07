using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace vidlyy.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public DateTime? DataRelase { get; set; }
        [Display(Name = "Date of Added")]
        public DateTime DateAdd { get; set; }
        [Display (Name ="Number in to stock")]
        public int NumberInStock { get; set; }
        public Genre Genre { get; set; }
        [Required]
        public int GenreId { get; set; }
    }
}