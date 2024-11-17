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


        // GET: Events
        public async Task<IActionResult> Index(string searchString, string eventType)
        {
            var events = from e in _context.Events
                         select e;

            if (!string.IsNullOrEmpty(searchString))
            {
                events = events.Where(s => s.Name.Contains(searchString) || s.Category.Contains(searchString));
            }

            // Filter by event type if provided
            if (!string.IsNullOrEmpty(eventType))
            {
                events = events.Where(e => e.EventType == eventType);
            }

            return View(await events.ToListAsync());
        }

        // GET: Events/Details/5
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
