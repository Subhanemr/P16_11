﻿using _16_11.DAL;
using _16_11.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _16_11.Areas.OrganiAdmin.Controllers
{
    [Area("OrganiAdmin")]

    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Product> products = await _context.Products.Include(p => p.Category).Include(p => p.Department).ToListAsync();

            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            if (!ModelState.IsValid) return View();

            bool result = _context.Products.Any(c => c.Name.ToLower().Trim() == product.Name.ToLower().Trim());

            if (result)
            {
                ModelState.AddModelError("Name", "A Category is available");
                return View();
            }

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
