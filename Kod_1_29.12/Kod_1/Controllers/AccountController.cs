using Kod_1.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Kod_1.Controllers
{
    
    public class AccountController : Controller
    {
        private readonly MovieContext _context;
        public AccountController(MovieContext context)
        {
            _context = context;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(string email, string pass)
        {
            var user = _context.Kullanıcılar.FirstOrDefault(w => w.Email.Equals(email) && w.Password.Equals(pass));
            if(user!=null&&user.UserId==1)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,user.Email)
                };
                var useridentity = new ClaimsIdentity(claims, "a","admin","admin");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                
                

                return Redirect("/movies/list");
            }
            else
            {
                return Redirect("/Account/Index");
            }

        }
    }
}

//var user = _context.Users.FirstOrDefault(w => w.Email.Equals(email) && w.Password.Equals(pass));
//if (user != null)
//{

//    HttpContext.Session.SetString("username", user.Email);
//    return Redirect("/Rol/Index");
//}
//else
//{
//    return Redirect("/Account/Index");
//}
