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
    public class UserController : Controller
    {
        private readonly MovieContext _context;
        public UserController(MovieContext context)
        {
            _context = context;
        }

        public IActionResult CreateUser()
        {
            return View(new UserModel());
        }
        [HttpPost]
        public IActionResult CreateUser(UserModel model)
        {
            

            if (ModelState.IsValid)
            {
                var entity = new User
                {
                    UserId = model.UserId,
                    UserName = model.UserName,
                    Email=model.Email,
                    Name = model.Name,
                    Password = model.Password,
                    BirthDate = model.BirthDate
                };

                _context.Kullanıcılar.Add(entity);
                _context.SaveChanges();
                return RedirectToAction("MovieList", "Admin");
            }
            ViewBag.Genres = _context.Genres.ToList();
            return View(model);
        }
    }
}
