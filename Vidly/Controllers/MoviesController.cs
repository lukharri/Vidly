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

        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id = 1, Name = "Braveheart" },
                new Movie {Id = 2, Name = "Dirty Dancing" },
                new Movie {Id = 3, Name = "Top Gun" },
                new Movie {Id = 4, Name = "Superman" }
            };
        }

    }
}