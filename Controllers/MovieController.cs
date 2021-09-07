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

        public ActionResult New()
        {
            var createMovieViewModel = new CreateMovieViewModel() {
                Genres = _context.Genres.ToList()
            };
            return View(createMovieViewModel);
        }
        public ActionResult Create(Movie movie)
        {
            if(movie.Id==0)
            {
                _context.Movies.Add(movie);
            }
            else
            {
                var m = _context.Movies.Find(movie.Id);
                m.Name = movie.Name;
                m.NumberInStock = movie.NumberInStock;
                m.GenreId = movie.GenreId;
                m.DateAdd = movie.DateAdd;
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
       public ActionResult Edit(int id)
        {
            var movie = _context.Movies.Find(id);
            if (movie == null)
                return HttpNotFound();
            var creatMovieViewModel = new CreateMovieViewModel() 
            {
                movie = movie,
                Genres =_context.Genres.ToList()
            };

            return View("New", creatMovieViewModel);
        }
        
    }
}