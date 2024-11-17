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

        // POST: Events/ConfirmPurchase
        [HttpPost]
        public IActionResult ConfirmPurchase(int eventId, int ticketQuantity)
        {
            var eventItem = _context.Events.Find(eventId);
            if (eventItem == null || ticketQuantity <= 0)
            {
                return RedirectToAction("Details", new { id = eventId });
            }

            var isStudent = User.Identity?.IsAuthenticated == true && User.Claims.Any(c => c.Type == "CUID");

            var totalPrice = ticketQuantity * eventItem.Price;
            if (isStudent)
            {
                totalPrice *= 0.9m; // Applying a 10% discount for students
            }

            var viewModel = new ConfirmPurchaseViewModel
            {
                Event = eventItem,
                TicketQuantity = ticketQuantity,
                TotalPrice = totalPrice,
                IsStudent = isStudent
            };

            return View(viewModel);
        }

        // POST: Events/CompletePurchase
        [HttpPost]
        public IActionResult CompletePurchase(int eventId, int ticketQuantity, decimal totalPrice)
        {
            // Here you could add logic to update the database, e.g., deduct tickets, process payment, etc.
            var eventItem = _context.Events.Find(eventId);
            if (eventItem == null || ticketQuantity <= 0 || ticketQuantity > eventItem.AvailableTickets)
            {
                return RedirectToAction("Details", new { id = eventId });
            }

            // Deduct the ticket quantity from the available tickets
            eventItem.AvailableTickets -= ticketQuantity;
            _context.SaveChanges();

            TempData["SuccessMessage"] = "Purchase successful!";
            return RedirectToAction("Details", new { id = eventId });
        }
    }
}
