using Microsoft.AspNetCore.Mvc;

namespace TigerTix.Web.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            // Temp: for now, we'll just pass the id to the view
            ViewData["EventId"] = id;
            return View();
        }
    }
}