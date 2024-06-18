using DoAnCN_WebsiteKDTD.Models;
using DoAnCN_WebsiteKDTD.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DoAnCN_WebsiteKDTD.Controllers
{
    public class AdminController : Controller
    {
        private readonly MyShopDBContext _context;

        public AdminController(MyShopDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            var users = _context.Users.ToList();
            var orders = _context.Orders.ToList();

            var model = new AdminDashboardViewModel
            {
                Products = products,
                Users = users,
                Orders = orders
            };

            return View(model);
        }
    }
}
