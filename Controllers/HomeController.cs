using main1234.Data;
using main1234.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace main1234.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly DataDbContext _ContactModel;
        private readonly DataDbContext _PostModel;

        public HomeController(ILogger<HomeController> logger, DataDbContext ContactModel, DataDbContext PostModel)
        {
            _logger = logger;
            _ContactModel = ContactModel;
            _PostModel = PostModel;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Post()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Post(PostModel Data, IFormFile picture)
        {
            if (picture != null)
            {
                // Save the uploaded file to the server
                var fileName = Guid.NewGuid().ToString() + "_" + picture.FileName;
                var filePath = Path.Combine("wwwroot/images", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await picture.CopyToAsync(stream);
                }

                // Store the file path in the database
                Data.picture = "/images/" + fileName;
            }

            _PostModel.Add(Data);
            await _PostModel.SaveChangesAsync();

            return RedirectToAction("Post");
        }

        public IActionResult Contact()
        {
           
            return View();
        }


        [HttpPost]
        public IActionResult Contact(ContactModel Data)
        {
            _ContactModel.Add(Data);
            _ContactModel.SaveChanges();

            return View();
        }
        // POST method to delete an event
        [HttpPost]
        public IActionResult Delete(int id)
        {
            // Find the event by ID
            var eventToDelete = _PostModel.PostModel.FirstOrDefault(p => p.Id == id);

            // If the event exists, remove it from the database
            if (eventToDelete != null)
            {
                _PostModel.PostModel.Remove(eventToDelete); // Remove event from DbContext
                _PostModel.SaveChanges(); // Save the changes to the database
            }

            return RedirectToAction("Music"); // Redirect to the music events list after deletion
        }


        public IActionResult Music()
        {
            var musicEvents = _PostModel.PostModel.Where(p => p.category == "Music").ToList();
            return View(musicEvents);
        }


        public IActionResult Sports()
        {
            var events = _PostModel.PostModel.Where(p => p.category == "Sports").ToList();
            return View(events);
        }

        public IActionResult Conference()
        {
            var events = _PostModel.PostModel.Where(p => p.category == "Conference").ToList();
            return View(events);
        }

        public IActionResult Culture()
        {
            var events = _PostModel.PostModel.Where(p => p.category == "Culture").ToList();
            return View(events);
        }

        public IActionResult Other()
        {
            var events = _PostModel.PostModel.Where(p => p.category == "Other").ToList();
            return View(events);
        }


    }
}
