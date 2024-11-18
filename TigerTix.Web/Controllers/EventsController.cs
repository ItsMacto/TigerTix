using Microsoft.AspNetCore.Mvc;
using TigerTix.Web.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace TigerTix.Web.Controllers
{
    public class EventsController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public EventsController(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor)
        {
            _httpClient = httpClientFactory.CreateClient("ApiClient");
            _httpContextAccessor = httpContextAccessor;

            // Set the BaseAddress to the current request's base URL
            var request = _httpContextAccessor.HttpContext.Request;
            _httpClient.BaseAddress = new Uri($"{request.Scheme}://{request.Host}");
        }

        // GET: Events
        public async Task<IActionResult> Index(string searchString, string eventType)
        {
            var events = await _httpClient.GetFromJsonAsync<IEnumerable<Event>>("api/EventsApi");

            if (!string.IsNullOrEmpty(searchString))
            {
                events = events.Where(e => e.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase)
                                           || e.Category.Contains(searchString, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrEmpty(eventType))
            {
                events = events.Where(e => e.EventType == eventType);
            }

            return View(events);
        }

        // GET: Events/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var eventItem = await _httpClient.GetFromJsonAsync<Event>($"api/EventsApi/{id}");
            if (eventItem == null)
            {
                return NotFound();
            }

            return View(eventItem);
        }

        // POST: Events/ConfirmPurchase
        [HttpPost]
        public async Task<IActionResult> ConfirmPurchase(int eventId, int ticketQuantity)
        {
            var eventItem = await _httpClient.GetFromJsonAsync<Event>($"api/EventsApi/{eventId}");
            if (eventItem == null || ticketQuantity <= 0)
            {
                return RedirectToAction("Details", new { id = eventId });
            }

            var isStudent = User.Identity?.IsAuthenticated == true && User.Claims.Any(c => c.Type == "CUID");

            var totalPrice = ticketQuantity * eventItem.Price;
            if (isStudent)
            {
                totalPrice *= 0.9m; // Apply 10% discount for students
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
        public async Task<IActionResult> CompletePurchase(int eventId, int ticketQuantity)
        {
            var eventItem = await _httpClient.GetFromJsonAsync<Event>($"api/EventsApi/{eventId}");
            if (eventItem == null || ticketQuantity <= 0 || ticketQuantity > eventItem.AvailableTickets)
            {
                TempData["ErrorMessage"] = "Invalid purchase request.";
                return RedirectToAction("Details", new { id = eventId });
            }

            // Update ticket availability
            eventItem.AvailableTickets -= ticketQuantity;

            var response = await _httpClient.PutAsJsonAsync($"api/EventsApi/{eventId}", eventItem);
            if (!response.IsSuccessStatusCode)
            {
                TempData["ErrorMessage"] = "Purchase failed. Please try again.";
                return RedirectToAction("Details", new { id = eventId });
            }

            TempData["SuccessMessage"] = "Purchase successful!";
            return RedirectToAction("Details", new { id = eventId });
        }
    }
}