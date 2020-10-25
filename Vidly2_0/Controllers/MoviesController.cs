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

        
    }
}