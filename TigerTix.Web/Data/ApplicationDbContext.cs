// Data/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using TigerTix.Web.Models;

namespace TigerTix.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<User> Users { get; set; }

        // Override the OnModelCreating method to seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed initial data for the Events table
            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    Id = 1,
                    Name = "Concert A",
                    Description = "An amazing concert.",
                    Date = DateTime.Now.AddDays(10),
                    Location = "Venue A",
                    Price = 50.00m,
                    ImageUrl = "/images/event1.jpg"
                },
                new Event
                {
                    Id = 2,
                    Name = "Festival B",
                    Description = "A fun festival.",
                    Date = DateTime.Now.AddDays(20),
                    Location = "Venue B",
                    Price = 30.00m,
                    ImageUrl = "/images/event2.jpg"
                }
                // more events here
            );
        }
    }
}