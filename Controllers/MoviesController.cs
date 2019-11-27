using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using utproject.Models;
using System.Web.Mvc;

namespace utproject.Controllers
{
    public class MoviesController : Controller
    {
        // GET: movie/random dulu
        public ActionResult random()
        {
            var movie = new Movie() { Name = "shrek!" };
            return View(movie);
        }
    }
}