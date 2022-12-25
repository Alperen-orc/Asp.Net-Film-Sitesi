using Kod_1.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kod_1.ViewComponents
{
    public class CommentViewCompanent : ViewComponent
    {
        private readonly MovieContext _context;
        public CommentViewCompanent(MovieContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedComment = RouteData.Values["id"];
            return View(_context.Comments.ToList());
        }
    }
}
