using Kod_1.Data;
using Kod_1.Entity;
using Kod_1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kod_1.Controllers
{
    public class StarController : Controller
    {
        private readonly MovieContext _context;
        public StarController(MovieContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Stars);
        }
        public IActionResult CreateStar()
        {

            return View(new MovieComment());
        }
        [HttpPost]
        public IActionResult CreateStar(MovieComment model, int input1)
        {
            if (ModelState.IsValid)
            {
                
                var entity = new Star
                {
                    StarValue = input1,
                    MovieId = model.MovieId,
                    
                };


                _context.Stars.Add(entity);
                _context.SaveChanges();
                return RedirectToAction("List", "Movies");
            }
            return View(model);
        }


    }
}