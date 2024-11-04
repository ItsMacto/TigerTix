using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TigerTix.Web.Migrations
{
    /// <inheritdoc />
    public partial class addedMoreEvents2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvailableTickets", "Category", "Date", "Description", "ImageUrl", "Location", "Name", "Organizer", "Price" },
                values: new object[] { 500, "Concert", new DateTime(2024, 12, 3, 20, 45, 14, 371, DateTimeKind.Local).AddTicks(7590), "Experience an unforgettable night with Taylor Swift's iconic hits from all her eras.", "https://media.newyorker.com/photos/652d4cfca2dd76a04bfbc885/3:4/w_1281,h_1708,c_limit/Brody-Eras-Tour.jpg", "SoFi Stadium, Los Angeles, CA", "Taylor Swift - The Eras Tour", "Live Nation", 150.00m });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvailableTickets", "Category", "Date", "Description", "ImageUrl", "Location", "Name", "Organizer", "Price" },
                values: new object[] { 300, "Sports", new DateTime(2024, 11, 18, 20, 45, 14, 371, DateTimeKind.Local).AddTicks(7620), "Catch the action as two legendary NBA teams go head-to-head.", "https://s.yimg.com/ny/api/res/1.2/ntZ3XGuHy7vENfP_QzxHKg--/YXBwaWQ9aGlnaGxhbmRlcjt3PTY0MDtoPTQ1MA--/https://media.zenfs.com/en/hoops_hype_usa_today_sports_articles_974/fe1e67ea89571d4532c900e622786b6f", "Crypto.com Arena, Los Angeles, CA", "Los Angeles Lakers vs. Boston Celtics", "NBA", 120.00m });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvailableTickets", "Category", "Date", "Description", "ImageUrl", "Location", "Name", "Organizer", "Price" },
                values: new object[] { 450, "Concert", new DateTime(2024, 12, 13, 20, 45, 14, 371, DateTimeKind.Local).AddTicks(7620), "Join Coldplay for an incredible evening of music and visual spectacle.", "https://plsn.com/site/wp-content/uploads/1_COLDPLAY-12-©-Steve-Jennings.jpg", "MetLife Stadium, East Rutherford, NJ", "Coldplay - Music of the Spheres World Tour", "Live Nation", 180.00m });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvailableTickets", "Category", "Date", "Description", "ImageUrl", "Location", "Name", "Organizer", "Price" },
                values: new object[] { 350, "Sports", new DateTime(2024, 11, 28, 20, 45, 14, 371, DateTimeKind.Local).AddTicks(7630), "Historic NFL rivalry game between the Packers and the Bears.", "https://packerswire.usatoday.com/wp-content/uploads/sites/57/2019/09/gettyimages-1172622091-e1568073746100.jpg?w=1000&h=600&crop=1", "Lambeau Field, Green Bay, WI", "Green Bay Packers vs. Chicago Bears", "NFL", 95.00m });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvailableTickets", "Category", "Date", "Description", "ImageUrl", "Location", "Name", "Organizer", "Price" },
                values: new object[] { 400, "Concert", new DateTime(2024, 11, 23, 20, 45, 14, 371, DateTimeKind.Local).AddTicks(7630), "Ed Sheeran brings his latest hits and fan favorites to a city near you.", "https://surgfm.com/wp-content/uploads/2023/03/ed-sheeran-1.webp", "Allegiant Stadium, Las Vegas, NV", "Ed Sheeran - Mathematics Tour", "Live Nation", 130.00m });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvailableTickets", "Category", "Date", "Description", "ImageUrl", "Location", "Name", "Organizer", "Price" },
                values: new object[] { 250, "Sports", new DateTime(2024, 11, 13, 20, 45, 14, 371, DateTimeKind.Local).AddTicks(7630), "MLB showdown between the Yankees and the Red Sox at the iconic Yankee Stadium.", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fseatgeek.com%2Fyankees-red-sox-tickets&psig=AOvVaw3CNpQQifM862SFlYfhF76O&ust=1730771043013000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCLj2k9vGwYkDFQAAAAAdAAAAABAE", "Yankee Stadium, Bronx, NY", "New York Yankees vs. Boston Red Sox", "MLB", 85.00m });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvailableTickets", "Category", "Date", "Description", "ImageUrl", "Location", "Name", "Organizer", "Price" },
                values: new object[] { 550, "Concert", new DateTime(2024, 12, 8, 20, 45, 14, 371, DateTimeKind.Local).AddTicks(7640), "Join BTS for a groundbreaking concert experience filled with energy and fan-favorite tracks.", "https://static.wikia.nocookie.net/the-bangtan-boys/images/4/43/BTS_Map_of_the_Soul_Tour.jpeg/revision/latest?cb=20200122062646", "Wembley Stadium, London, UK", "BTS - Map of the Soul Tour", "Big Hit Music", 175.00m });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvailableTickets", "Category", "Date", "Description", "ImageUrl", "Location", "Name", "Organizer", "Price" },
                values: new object[] { 400, "Sports", new DateTime(2024, 11, 25, 20, 45, 14, 371, DateTimeKind.Local).AddTicks(7640), "NFC East rivals face off in an intense game at AT&T Stadium.", "https://static.clubs.nfl.com/image/upload/t_editorial_landscape_12_desktop/cowboys/qrozabo6cfsguc3bexop", "AT&T Stadium, Arlington, TX", "Dallas Cowboys vs. Philadelphia Eagles", "NFL", 100.00m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvailableTickets", "Category", "Date", "Description", "ImageUrl", "Location", "Name", "Organizer", "Price" },
                values: new object[] { 250, "Sports", new DateTime(2024, 11, 13, 20, 36, 8, 592, DateTimeKind.Local).AddTicks(4830), "Watch the top teams battle for the championship!", "https://images.unsplash.com/photo-1517649763962-0c623066013b?q=80&w=2748&auto=format&fit=crop", "Staples Center", "Championship Basketball Game", "NBA", 120.00m });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvailableTickets", "Category", "Date", "Description", "ImageUrl", "Location", "Name", "Organizer", "Price" },
                values: new object[] { 500, "Concert", new DateTime(2024, 11, 23, 20, 36, 8, 592, DateTimeKind.Local).AddTicks(4870), "Experience live performances by the best country artists.", "https://images.unsplash.com/photo-1534230299580-8d82f20a72bc?q=80&w=2748&auto=format&fit=crop", "Nashville Fairgrounds", "Country Music Festival", "Country Fest Inc.", 85.00m });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvailableTickets", "Category", "Date", "Description", "ImageUrl", "Location", "Name", "Organizer", "Price" },
                values: new object[] { 1000, "Sports", new DateTime(2024, 11, 18, 20, 36, 8, 592, DateTimeKind.Local).AddTicks(4880), "The most anticipated match of the year!", "https://images.unsplash.com/photo-1594853108080-e9043c5ab3b9?q=80&w=2748&auto=format&fit=crop", "Old Trafford Stadium", "Soccer League Finals", "Premier League", 150.00m });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvailableTickets", "Category", "Date", "Description", "ImageUrl", "Location", "Name", "Organizer", "Price" },
                values: new object[] { 750, "Concert", new DateTime(2024, 11, 28, 20, 36, 8, 592, DateTimeKind.Local).AddTicks(4880), "Join legendary bands for an unforgettable night of rock.", "https://images.unsplash.com/photo-1519750157634-baefa305b64e?q=80&w=2748&auto=format&fit=crop", "Madison Square Garden", "Rock & Roll All Night", "Live Nation", 100.00m });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvailableTickets", "Category", "Date", "Description", "ImageUrl", "Location", "Name", "Organizer", "Price" },
                values: new object[] { 1200, "Sports", new DateTime(2024, 11, 8, 20, 36, 8, 592, DateTimeKind.Local).AddTicks(4880), "Don't miss the most thrilling game of the season.", "https://images.unsplash.com/photo-1571019613454-1cb2f3d58a00?q=80&w=2748&auto=format&fit=crop", "Levi's Stadium", "Football Championship", "NFL", 200.00m });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvailableTickets", "Category", "Date", "Description", "ImageUrl", "Location", "Name", "Organizer", "Price" },
                values: new object[] { 400, "Concert", new DateTime(2024, 12, 3, 20, 36, 8, 592, DateTimeKind.Local).AddTicks(4880), "A soulful evening with the best jazz and blues musicians.", "https://images.unsplash.com/photo-1601285377181-9f2165fb4cd7?q=80&w=2748&auto=format&fit=crop", "New Orleans Jazz Hall", "Jazz & Blues Night", "Jazz Fest", 60.00m });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvailableTickets", "Category", "Date", "Description", "ImageUrl", "Location", "Name", "Organizer", "Price" },
                values: new object[] { 1300, "Sports", new DateTime(2024, 11, 11, 20, 36, 8, 592, DateTimeKind.Local).AddTicks(4890), "Witness history in the making at the Baseball World Series.", "https://images.unsplash.com/photo-1581046931477-4a1cb97202c4?q=80&w=2748&auto=format&fit=crop", "Yankee Stadium", "Baseball World Series", "MLB", 250.00m });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvailableTickets", "Category", "Date", "Description", "ImageUrl", "Location", "Name", "Organizer", "Price" },
                values: new object[] { 350, "Concert", new DateTime(2024, 11, 21, 20, 36, 8, 592, DateTimeKind.Local).AddTicks(4890), "A night of elegance with world-renowned classical musicians.", "https://images.unsplash.com/photo-1561016444-1ac4435a0ee4?q=80&w=2748&auto=format&fit=crop", "Carnegie Hall", "Classical Music Gala", "Classical Society", 75.00m });
        }
    }
}
