using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidlyy.ViewModels;
using vidlyy.Models;
using System.Data.Entity;

namespace vidlyy.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationDbContext _context;
        public MovieController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Movie
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(g => g.Genre).ToList();
            return View(movies);
        }

        public ActionResult Info(int id)
        {
            var movie = _context.Movies.Include(g=>g.Genre).FirstOrDefault(i => i.Id == id);

            if (movie == null)
                return HttpNotFound();


            return View(movie);
        }
    }
}