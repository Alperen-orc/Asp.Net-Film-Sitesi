using Kod_1.Data;
using Kod_1.Entity;
using Kod_1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kod_1.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MovieContext _context;
        public MoviesController(MovieContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
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
            var movies = _context.Movies.Find(id);
            if (id != null)
            {
                comments = comments
                    .Include(m => m.Movies)
                    .Where(m => m.Movies.MovieId == id);
            }

            var model = new MovieComment
            {
                Comments = comments.ToList(),
                Movies = movies
                
            };
            return View(model);

            //MovieComment mc = new MovieComment();
            //mc.Comments = _context.Comments.ToList();
            //mc.Movies = _context.Movies.Find(id);
            //return View(mc);
        }
        

        public IActionResult CommentList(int id)
        {
            return View(_context.Comments.Find(id));
        }




    }
}

