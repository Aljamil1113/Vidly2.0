using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Web.UI.WebControls;
using Vidly2_0.Models;
using Vidly2_0.ViewModels;

namespace Vidly2_0.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();   
        }
        // GET: Movies
        public ActionResult Index()
        {
            var viewModel = _context.Movies.Include(g => g.GenreType).ToList();

            return View(viewModel);
        }

        public ActionResult Detail(int id)
        {
            var movie = _context.Movies.Include(g => g.GenreType).SingleOrDefault(i => i.Id == id);

            if (movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);
        }

        public ActionResult New()
        {
            var genres = _context.Genres.ToList();

            var viewModel = new MovieGenreViewModel()
            {
                Movie = new Movie(),
                Genres = genres
            };
            ViewBag.Page = "New Movie";
            return View("MovieForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if(!ModelState.IsValid)
            {
                var viewModel = new MovieGenreViewModel()
                {
                    Movie = new Movie(),
                    Genres = _context.Genres.ToList()
                };

                return View("MovieForm", viewModel);
            }
            if(movie.Id == 0)
            {
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.ReleasedDate = movie.ReleasedDate;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.Stocks = movie.Stocks;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            var viewModel = new MovieGenreViewModel()
            {
                Movie = movie,
                Genres = _context.Genres.ToList()
            };

            ViewBag.Page = "Edit Movie";

            return View("MovieForm", viewModel);
        }

    }
}