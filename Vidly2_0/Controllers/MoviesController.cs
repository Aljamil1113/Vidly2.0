using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Vidly2_0.Models;
using Vidly2_0.ViewModels;

namespace Vidly2_0.Controllers
{
    public class MoviesController : Controller
    {
        List<Movie> movies = new List<Movie>()
        {
            new Movie {  Id = 1, Name = "James Bond 007"},
            new Movie {  Id = 2, Name = "Batman"},
        };
        // GET: Movies
        public ActionResult Index()
        {


            //List<Customer> customers = new List<Customer>
            //{
            //    new Customer { Id = 1, Name = "Customer 1"},
            //    new Customer {Id = 2, Name = "Customer 2"}
            //};

            //var viewModel = new RandomMovieViewModel()
            //{
            //    movie = movie,
            //    customers = customers
            //};

            var viewModel = movies.ToList();

            return View(viewModel);
        }

        public ActionResult Detail(int id)
        {
            var movie = movies.Where(i => i.Id == id).SingleOrDefault();

            if (movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);
        }

        
    }
}