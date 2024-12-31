using Microsoft.AspNetCore.Mvc;

namespace main1234.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Post()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            ViewBag.Message = "Please fill out the contact form.";
            return View();
        }

        [HttpPost]
        public IActionResult Contact(string name, string email, string message)
        {
            if (name == "zain" && email == "zainfarooq520@gmail.com")
            {
                ViewData["Response"] = "You have successfully logged into the system!";
                TempData["FormSubmitted"] = true; // Hides the form after submission
            }
            else
            {
                TempData["Alert"] = "Your email or username may not be correct!";
                ViewData["Response"] = "Please try again.";
            }

            return View();
        }

        public IActionResult Music()
        {
            return View();
        }

        public IActionResult Sports()
        {
            return View();
        }

        public IActionResult Conference()
        {
            return View();
        }

        public IActionResult Culture()
        {
            return View();
        }

        public IActionResult Other()
        {
            return View();
        }
    }
}
