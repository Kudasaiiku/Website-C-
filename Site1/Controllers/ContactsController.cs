using Microsoft.AspNetCore.Mvc;
using Site1.Models;

namespace Site1.Controllers
{
	public class ContactsController : Controller
	{
		public IActionResult Index() // Contacts
		{
			return View();
		}

		[HttpPost]
        public IActionResult Check(Contacts contact) // Check
        {
            if(ModelState.IsValid)
			{
				return Redirect("/");
            }
			else
			{
                return View("Index");
            }	
        }
    }
}
