// Models/Event.cs
using System;

namespace TigerTix.Web.Models
{
    public class Event
    {
        public int Id { get; set; }             // Event ID
        public string Name { get; set; }        // Event Name
        public string Description { get; set; } // Event Description
        public DateTime Date { get; set; }      // Event Date
        public string Location { get; set; }    // Event Location
        public decimal Price { get; set; }      // Ticket Price
        public string ImageUrl { get; set; }    // Image URL for the event
    }
}