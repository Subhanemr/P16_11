using Microsoft.AspNetCore.Mvc;

namespace _16_11.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
