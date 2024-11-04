// Models/Event.cs
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TigerTix.Web.Models
{
    public class Event
    {
        public int Id { get; set; }             // Event ID
        public required string Name { get; set; }        // Event Name
        [Required]
        public required string Description { get; set; } // Event Description
        public required DateTime Date { get; set; }      // Event Date
        public required string Location { get; set; }    // Event Location
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }      // Ticket Price
        public required string ImageUrl { get; set; }    // Image URL for the event
        public required string Category { get; set; }       // Event Category
        public required string Organizer { get; set; }      // Event Organizer
        public int AvailableTickets { get; set; }  // Number of Available Tickets
    }
}