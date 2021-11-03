using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime Published { get; set; }
        public decimal Price { get; set; }
        public Genre GenreType { get; set; }
    }

    public enum Genre { Action, Thriller, Comedy, Drama, Horror, Documentary, Subject }
}
