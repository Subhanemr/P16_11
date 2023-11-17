using _16_11.DAL;
using _16_11.Models;
using _16_11.ViewModelds;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace _16_11.Controllers
{
	public class HomeController : Controller
	{
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
		{

            List<Product> products = _context.Products.ToList();
            List<Department> departments = _context.Departments.ToList();
            List<Blog> blogs = _context.Blogs.ToList();


            HomeVM vm = new HomeVM { Blogs = blogs, Products = products, Departments = departments};
            return View(vm);
		}
	}
}
