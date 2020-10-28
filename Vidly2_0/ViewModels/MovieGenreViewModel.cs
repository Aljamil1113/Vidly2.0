using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly2_0.Models;

namespace Vidly2_0.ViewModels
{
    public class MovieGenreViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
    }
}