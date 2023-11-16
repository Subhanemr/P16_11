using Microsoft.AspNetCore.Mvc;

namespace _16_11.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
