using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly2_0.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? ReleasedDate { get; set; }
        public DateTime? DateAdded { get; set; }
        public int Stocks { get; set; }
        public Genre GenreType { get; set; }
        public byte GenreId { get; set; }


    }
}