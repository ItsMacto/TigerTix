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

            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    Id = 1,
                    Name = "Rock Concert",
                    Description = "Experience an electrifying night with top rock bands.",
                    Date = DateTime.Now.AddDays(15),
                    Location = "Madison Square Garden",
                    Price = 75.00m,
                    ImageUrl = "https://images.unsplash.com/photo-1712763113004-e375adb253c3?q=80&w=2748&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    Category = "Music",
                    Organizer = "Live Nation",
                    AvailableTickets = 150
                },
                new Event
                {
                    Id = 2,
                    Name = "Art Expo",
                    Description = "Discover contemporary art from around the world.",
                    Date = DateTime.Now.AddDays(30),
                    Location = "Art Gallery of Ontario",
                    Price = 20.00m,
                    ImageUrl = "https://images.unsplash.com/photo-1627818032590-6fab3d942af9?q=80&w=2670&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    Category = "Exhibition",
                    Organizer = "Art World",
                    AvailableTickets = 300
                }

            );
        }
    }
}