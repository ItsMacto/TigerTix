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

        public required DbSet<Event> Events { get; set; }
        public required DbSet<User> Users { get; set; }

        // Override the OnModelCreating method to seed data

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    Id = 1,
                    Name = "Taylor Swift - The Eras Tour",
                    Description = "Experience an unforgettable night with Taylor Swift's iconic hits from all her eras.",
                    Date = DateTime.Now.AddDays(30),
                    Location = "SoFi Stadium, Los Angeles, CA",
                    Price = 150.00m,
                    ImageUrl = "https://media.newyorker.com/photos/652d4cfca2dd76a04bfbc885/3:4/w_1281,h_1708,c_limit/Brody-Eras-Tour.jpg",
                    Category = "Concert",
                    Organizer = "Live Nation",
                    AvailableTickets = 500,
                    EventType = "Concert"
                },
                new Event
                {
                    Id = 2,
                    Name = "Los Angeles Lakers vs. Boston Celtics",
                    Description = "Catch the action as two legendary NBA teams go head-to-head.",
                    Date = DateTime.Now.AddDays(15),
                    Location = "Crypto.com Arena, Los Angeles, CA",
                    Price = 120.00m,
                    ImageUrl = "https://s.yimg.com/ny/api/res/1.2/ntZ3XGuHy7vENfP_QzxHKg--/YXBwaWQ9aGlnaGxhbmRlcjt3PTY0MDtoPTQ1MA--/https://media.zenfs.com/en/hoops_hype_usa_today_sports_articles_974/fe1e67ea89571d4532c900e622786b6f",
                    Category = "Sports",
                    Organizer = "NBA",
                    AvailableTickets = 300,
                    EventType = "Sports"
                },
                new Event
                {
                    Id = 3,
                    Name = "Coldplay - Music of the Spheres World Tour",
                    Description = "Join Coldplay for an incredible evening of music and visual spectacle.",
                    Date = DateTime.Now.AddDays(40),
                    Location = "MetLife Stadium, East Rutherford, NJ",
                    Price = 180.00m,
                    ImageUrl = "https://plsn.com/site/wp-content/uploads/1_COLDPLAY-12-©-Steve-Jennings.jpg",
                    Category = "Concert",
                    Organizer = "Live Nation",
                    AvailableTickets = 450,
                    EventType = "Concert"
                },
                new Event
                {
                    Id = 4,
                    Name = "Green Bay Packers vs. Chicago Bears",
                    Description = "Historic NFL rivalry game between the Packers and the Bears.",
                    Date = DateTime.Now.AddDays(25),
                    Location = "Lambeau Field, Green Bay, WI",
                    Price = 95.00m,
                    ImageUrl = "https://packerswire.usatoday.com/wp-content/uploads/sites/57/2019/09/gettyimages-1172622091-e1568073746100.jpg?w=1000&h=600&crop=1",
                    Category = "Sports",
                    Organizer = "NFL",
                    AvailableTickets = 350,
                    EventType = "Sports"
                },
                new Event
                {
                    Id = 5,
                    Name = "Ed Sheeran - Mathematics Tour",
                    Description = "Ed Sheeran brings his latest hits and fan favorites to a city near you.",
                    Date = DateTime.Now.AddDays(20),
                    Location = "Allegiant Stadium, Las Vegas, NV",
                    Price = 130.00m,
                    ImageUrl = "https://surgfm.com/wp-content/uploads/2023/03/ed-sheeran-1.webp",
                    Category = "Concert",
                    Organizer = "Live Nation",
                    AvailableTickets = 400,
                    EventType = "Concert"
                },
                new Event
                {
                    Id = 6,
                    Name = "New York Yankees vs. Boston Red Sox",
                    Description = "MLB showdown between the Yankees and the Red Sox at the iconic Yankee Stadium.",
                    Date = DateTime.Now.AddDays(10),
                    Location = "Yankee Stadium, Bronx, NY",
                    Price = 85.00m,
                    ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fseatgeek.com%2Fyankees-red-sox-tickets&psig=AOvVaw3CNpQQifM862SFlYfhF76O&ust=1730771043013000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCLj2k9vGwYkDFQAAAAAdAAAAABAE",
                    Category = "Sports",
                    Organizer = "MLB",
                    AvailableTickets = 250,
                    EventType = "Sports"
                },
                new Event
                {
                    Id = 7,
                    Name = "BTS - Map of the Soul Tour",
                    Description = "Join BTS for a groundbreaking concert experience filled with energy and fan-favorite tracks.",
                    Date = DateTime.Now.AddDays(35),
                    Location = "Wembley Stadium, London, UK",
                    Price = 175.00m,
                    ImageUrl = "https://static.wikia.nocookie.net/the-bangtan-boys/images/4/43/BTS_Map_of_the_Soul_Tour.jpeg/revision/latest?cb=20200122062646",
                    Category = "Concert",
                    Organizer = "Big Hit Music",
                    AvailableTickets = 550,
                    EventType = "Concert"
                },
                new Event
                {
                    Id = 8,
                    Name = "Dallas Cowboys vs. Philadelphia Eagles",
                    Description = "NFC East rivals face off in an intense game at AT&T Stadium.",
                    Date = DateTime.Now.AddDays(22),
                    Location = "AT&T Stadium, Arlington, TX",
                    Price = 100.00m,
                    ImageUrl = "https://static.clubs.nfl.com/image/upload/t_editorial_landscape_12_desktop/cowboys/qrozabo6cfsguc3bexop",
                    Category = "Sports",
                    Organizer = "NFL",
                    AvailableTickets = 400,
                    EventType = "Sports"
                }
            );
        }
    }
}