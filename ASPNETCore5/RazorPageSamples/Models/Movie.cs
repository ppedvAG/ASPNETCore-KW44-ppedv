using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageSamples.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Bitte tragen Sie den Titel ein:")]
        public string Title { get; set; }

        [MaxLength(100)]
        [Display(Name = "Filmbeschreibung")]
        public string Description { get; set; }
        public Genre Genre { get; set; }

        [Range(0,20)] 
        public decimal Price { get; set; }
    }

    public enum Genre { Action, Thriller, Drama, Comedy, Documentary, Romance }
}
