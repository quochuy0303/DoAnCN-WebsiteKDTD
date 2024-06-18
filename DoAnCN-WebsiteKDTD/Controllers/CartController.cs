using Microsoft.AspNetCore.Mvc;

namespace DoAnCN_WebsiteKDTD.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Cart()
        {
            return View();
        }
    }
}
