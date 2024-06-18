using DoAnCN_WebsiteKDTD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoAnCN_WebsiteKDTD.Controllers
{
    public class ProductController : Controller
    {
        private readonly MyShopDBContext _context;

        public ProductController(MyShopDBContext context)
        {
            _context = context;
        }

        public IActionResult ShowProduct()
        {
            var products = _context.Products.ToList();
            return View(products);
        }
    }
}
