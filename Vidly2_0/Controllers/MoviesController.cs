using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Vidly2_0.Models;

namespace Vidly2_0.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            Movie movie = new Movie()
            {
                Id = 1,
                Name = "James Bond 007"
            }; 
            return View(movie);
        }

        
    }
}