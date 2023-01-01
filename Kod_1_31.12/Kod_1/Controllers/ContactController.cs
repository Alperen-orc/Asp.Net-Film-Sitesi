using Kod_1.Data;
using Kod_1.Entity;
using Kod_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Kod_1.Controllers
{
	public class ContactController : Controller
	{
		private readonly MovieContext _context;
		public ContactController(MovieContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			return View();
		}

        public IActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
		public IActionResult CreateContact(ContactViewModel model)
		{


			if (ModelState.IsValid)
			{
				var entity = new Contact
				{
					Email=model.Email,
					Message=model.Message,
					Name=model.Name,
					Subject = model.Subject
					

				};
				
				_context.Contacts.Add(entity);
				_context.SaveChanges();
				return RedirectToAction("List", "Movies");
			}
			
			return View(model);
		}
	}
}
