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
            return View(new CommentsViewModel());
        }
        [HttpPost]
        public IActionResult CreateComment(CommentsViewModel model)
        {


            if (ModelState.IsValid)
            {
                var entity = new Comment
                {
                    comment = model.comment,
                    Name = model.Name,

                };

                _context.Comments.Add(entity);
                _context.SaveChanges();
                return RedirectToAction("MovieList", "Admin");
            }
            ViewBag.Movies = _context.Movies.ToList();
            return View(model);
        }

        public IActionResult CommentList()
        {
            return View(new CommentListModel
            {
                Comments = _context.Comments
                .Include(m => m.Movies)
                .Select(m => new CommentLisModel
                {

                    CommentId = m.CommentId,
                    Name = m.Name,
                    comment = m.comment,
                    Movies = m.Movies.ToList()
                })
                .ToList()
            });
        }
    }
}
