using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;

namespace Vidly2.Controllers
{
    public class MoviesController : Controller
    {
        //kayıtlı filmleri listeleme
        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        //kayıtlı filmler
        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" },
                new Movie { Id = 3, Name = "Recep İvedik" },
                new Movie { Id = 4, Name = "Deneme filmi" }
            };
        }


        //kayıtlı filmlerin detay sayfaları
        public ActionResult Details(int id)
        {
            var movieDepo = GetMovies().SingleOrDefault(m => m.Id == id);

            if (movieDepo == null)
                return HttpNotFound();

            return View(movieDepo);
        }




        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }


    }
}
