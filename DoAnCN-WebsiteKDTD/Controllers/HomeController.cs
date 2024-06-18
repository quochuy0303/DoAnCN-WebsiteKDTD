using DoAnCN_WebsiteKDTD.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DoAnCN_WebsiteKDTD.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyShopDBContext _context;

        public HomeController(MyShopDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
