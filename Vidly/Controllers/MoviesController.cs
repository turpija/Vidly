using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer{Name="CustomerUno"},
                new Customer{Name="CustomerDuo"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
                return View(viewModel);
        }

        [Route("movies/releasd/{year}/{month:regex(\\d{4}):range(1,12)}")]

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            var movies = new List<Movie>
            {
                new Movie() { Name = "Shrek!" },
                new Movie() { Name = "Wall-e" }
            };


            var customers = new List<Customer>
            {
                new Customer{Name="CustomerUno"},
                new Customer{Name="CustomerDuo"}
            };

            var viewModel = new MoviesViewModel
            {
                Movies = movies,
            };
            return View(viewModel);


            //return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
    }
}