using Kod_1.Data;
using Kod_1.Entity;
using Kod_1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kod_1.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MovieContext _context;
        private readonly ILogger<MoviesController> _logger;

        public MoviesController(MovieContext context, ILogger<MoviesController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ChangeLanguage(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions() { Expires = DateTimeOffset.UtcNow.AddYears(1) });

            return Redirect(Request.Headers["Referer"].ToString());
        }

        public IActionResult List(int? id,string q)
        {

            //var movies = MovieRepository.Movies;
            var movies = _context.Movies.AsQueryable();

            if(id!=null)
            {
                movies = movies
                    .Include(m=>m.Genres)
                    .Where(m => m.Genres.Any(g=>g.GenreId==id));
            }

            if(!string.IsNullOrEmpty(q))
            {
                movies = movies.Where(i =>
                    i.Title.ToLower().Contains(q.ToLower()) ||
                    i.Description.ToLower().Contains(q.ToLower()));
            }

            var model = new MoviesViewModel
            {

                Movies = movies.ToList()

            };

            return View("Movies",model);
        }



        public IActionResult Details(int? id,string q)
        {
            var comments = _context.Comments.AsQueryable();
            var stars = _context.Stars.AsQueryable();
            var movies = _context.Movies.Find(id);
            if (id != null)
            {
                comments = comments
                    .Include(m => m.Movies)
                    .Where(m => m.Movies.MovieId == id);
                stars = stars
                    .Include(m => m.Movies)
                    .Where(m => m.Movies.MovieId == id);
            }

            var model = new MovieComment
            {
                Comments = comments.ToList(),
                Stars = stars.ToList(),
                Movies = movies
                
            };
            return View(model);

        }
        

        public IActionResult CommentList(int id)
        {
            return View(_context.Comments.Find(id));
        }




    }
}

