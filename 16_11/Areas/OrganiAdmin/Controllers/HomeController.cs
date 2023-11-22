using _16_11.DAL;
using Microsoft.AspNetCore.Mvc;

namespace _16_11.Areas.Admin.Controllers
{
    [Area("OrganiAdmin")]
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
