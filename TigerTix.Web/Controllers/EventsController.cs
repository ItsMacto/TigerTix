// Controllers/EventsController.cs
using Microsoft.AspNetCore.Mvc;
using TigerTix.Web.Data;
using TigerTix.Web.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
// using System.Collections.Generic;
// using System.Linq;

namespace TigerTix.Web.Controllers
{
    public class EventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var events = await _context.Events.ToListAsync();
            return View(events);
        }

        public async Task<IActionResult> Details(int id)
        {
            var eventItem = await _context.Events.FindAsync(id);
            if (eventItem == null)
            {
                return NotFound();
            }
            return View(eventItem);
        }
    }
}


// namespace TigerTix.Web.Controllers
// {
//     public class EventsController : Controller
//     {
//         // Mock data for events
//         private static List<Event> events = new List<Event>
//         {
//             new Event
//             {
//                 Id = 1,
//                 Name = "Concert A",
//                 Description = "An amazing concert.",
//                 Date = System.DateTime.Now.AddDays(10),
//                 Location = "Venue A",
//                 Price = 50.00m,
//                 ImageUrl = "/images/event1.jpg"
//             },
//             new Event
//             {
//                 Id = 2,
//                 Name = "Festival B",
//                 Description = "A fun festival.",
//                 Date = System.DateTime.Now.AddDays(20),
//                 Location = "Venue B",
//                 Price = 30.00m,
//                 ImageUrl = "/images/event2.jpg"
//             },
//         };

//         public IActionResult Index()
//         {
//             return View(events);
//         }

//         public IActionResult Details(int id)
//         {
//             var eventItem = events.FirstOrDefault(e => e.Id == id);
//             if (eventItem == null)
//             {
//                 return NotFound();
//             }
//             return View(eventItem);
//         }
//     }
// }