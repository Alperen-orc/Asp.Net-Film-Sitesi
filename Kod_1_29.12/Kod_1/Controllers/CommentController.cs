using Kod_1.Data;
using Kod_1.Entity;
using Kod_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kod_1.Controllers
{
    public class CommentController : Controller
    {
        private readonly MovieContext _context;
        public CommentController(MovieContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Comments);
        }
        public IActionResult CreateComment()
        {

            return View(new MovieComment());
        }
        [HttpPost]
        public IActionResult CreateComment(MovieComment model)
        {


            if (ModelState.IsValid)
            {
                var entity = new Comment
                {
                    comment = model.comment,
                    Name = model.Name,
                    MovieId=model.MovieId

                };
                if(model.comment==null||model.Name==null)
                {
                    return View();
                }
                

                _context.Comments.Add(entity);
                _context.SaveChanges();
                return RedirectToAction("List", "Movies",model.MovieId);
            }
            ViewBag.Movies = _context.Movies.ToList();
            return View(model);
        }

       
    }
}
