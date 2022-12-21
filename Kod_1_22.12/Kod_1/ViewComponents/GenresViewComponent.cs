using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kod_1.Data;
using Kod_1.Models;
using Microsoft.AspNetCore.Mvc;


namespace Kod_1.ViewComponents
{
    public class GenresViewComponent : ViewComponent
    {
        private readonly MovieContext _context;
        public GenresViewComponent(MovieContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedGenre = RouteData.Values["id"];
            return View(_context.Genres.ToList());
        }
    }
      
}
