using MyVidly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Web.Mvc;
using System.Web.UI.HtmlControls;
using MyVidly.ViewModels;

namespace MyVidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie { Name = "Rambo" };
            // movie will come along with ViewData.Model

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer1"},
                new Customer {Name = "Customer2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        

        public ActionResult Index()
        {
            var movies = _context.Movies?.Include(m => m.Genre).ToList();
            var viewModel = new MovieViewModel
            {
                Movies = movies,
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies?.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);
        }

        [Route("movies/released/{year:range(2000, 2099)}/{month:range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        #region UPDATING DATA

        public ActionResult New()
        {
            var genres = _context.Genres.ToList();
            var viewModel = new MovieFormViewModel
            {
                Genres = genres
            };

            return View("MovieForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var movieInDb = _context.Movies.Single(m => m.Id == id);
            var genres = _context.Genres.ToList();
            var viewModel = new MovieFormViewModel(movieInDb)
            {
                Genres = genres,
            };

            return View("MovieForm", viewModel);
        }

        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.Inventory = movie.Inventory;
                movieInDb.GenreId = movie.GenreId;
            }

            try
            {
                _context.SaveChanges();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return RedirectToAction("Index", "Movie");
        }

        #endregion

    }
}