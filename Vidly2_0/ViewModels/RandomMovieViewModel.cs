using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly2_0.Models;

namespace Vidly2_0.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie movie { get; set; }
        public List<Customer> customers { get; set; }
    }
}