using Microsoft.AspNetCore.Mvc;

namespace DoAnCN_WebsiteKDTD.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Account()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Implement your login logic here
            // Example: Check username and password against the database
            if (username == "test" && password == "password")
            {
                // Login successful
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Login failed
                ViewBag.ErrorMessage = "Invalid username or password";
                return View("Account");
            }
        }

        [HttpPost]
        public IActionResult Register(string username, string email, string password)
        {
            // Implement your registration logic here
            // Example: Save the user to the database
            // Return the account view after registration
            ViewBag.Message = "Registration successful";
            return View("Account");
        }
    }
}
