// Models/Event.cs
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace TigerTix.Web.Models
{
    public class Event
    {
        public int Id { get; set; }             // Event ID
        public string Name { get; set; }        // Event Name
        public string Description { get; set; } // Event Description
        public DateTime Date { get; set; }      // Event Date
        public string Location { get; set; }    // Event Location
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }      // Ticket Price
        public string ImageUrl { get; set; }    // Image URL for the event
        public IFormFile UploadImage {get; set;} //IForm File 
        public decimal Capacity {get; set;}     //Capacity of the event
    }
}