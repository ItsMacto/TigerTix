using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TigerTix.Web.Migrations
{
    /// <inheritdoc />
    public partial class addedMoreEvents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "AvailableTickets", "Category", "Date", "Description", "ImageUrl", "Location", "Name", "Organizer", "Price" },
                values: new object[,]
                {
                    { 3, 1000, "Sports", new DateTime(2024, 11, 18, 20, 36, 8, 592, DateTimeKind.Local).AddTicks(4880), "The most anticipated match of the year!", "https://images.unsplash.com/photo-1594853108080-e9043c5ab3b9?q=80&w=2748&auto=format&fit=crop", "Old Trafford Stadium", "Soccer League Finals", "Premier League", 150.00m },
                    { 4, 750, "Concert", new DateTime(2024, 11, 28, 20, 36, 8, 592, DateTimeKind.Local).AddTicks(4880), "Join legendary bands for an unforgettable night of rock.", "https://images.unsplash.com/photo-1519750157634-baefa305b64e?q=80&w=2748&auto=format&fit=crop", "Madison Square Garden", "Rock & Roll All Night", "Live Nation", 100.00m },
                    { 5, 1200, "Sports", new DateTime(2024, 11, 8, 20, 36, 8, 592, DateTimeKind.Local).AddTicks(4880), "Don't miss the most thrilling game of the season.", "https://images.unsplash.com/photo-1571019613454-1cb2f3d58a00?q=80&w=2748&auto=format&fit=crop", "Levi's Stadium", "Football Championship", "NFL", 200.00m },
                    { 6, 400, "Concert", new DateTime(2024, 12, 3, 20, 36, 8, 592, DateTimeKind.Local).AddTicks(4880), "A soulful evening with the best jazz and blues musicians.", "https://images.unsplash.com/photo-1601285377181-9f2165fb4cd7?q=80&w=2748&auto=format&fit=crop", "New Orleans Jazz Hall", "Jazz & Blues Night", "Jazz Fest", 60.00m },
                    { 7, 1300, "Sports", new DateTime(2024, 11, 11, 20, 36, 8, 592, DateTimeKind.Local).AddTicks(4890), "Witness history in the making at the Baseball World Series.", "https://images.unsplash.com/photo-1581046931477-4a1cb97202c4?q=80&w=2748&auto=format&fit=crop", "Yankee Stadium", "Baseball World Series", "MLB", 250.00m },
                    { 8, 350, "Concert", new DateTime(2024, 11, 21, 20, 36, 8, 592, DateTimeKind.Local).AddTicks(4890), "A night of elegance with world-renowned classical musicians.", "https://images.unsplash.com/photo-1561016444-1ac4435a0ee4?q=80&w=2748&auto=format&fit=crop", "Carnegie Hall", "Classical Music Gala", "Classical Society", 75.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvailableTickets", "Category", "Date", "Description", "ImageUrl", "Location", "Name", "Organizer", "Price" },
                values: new object[] { 150, "Music", new DateTime(2024, 11, 18, 20, 10, 45, 202, DateTimeKind.Local).AddTicks(3665), "Experience an electrifying night with top rock bands.", "https://images.unsplash.com/photo-1712763113004-e375adb253c3?q=80&w=2748&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Madison Square Garden", "Rock Concert", "Live Nation", 75.00m });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvailableTickets", "Category", "Date", "Description", "ImageUrl", "Location", "Name", "Organizer", "Price" },
                values: new object[] { 300, "Exhibition", new DateTime(2024, 12, 3, 20, 10, 45, 202, DateTimeKind.Local).AddTicks(3719), "Discover contemporary art from around the world.", "https://images.unsplash.com/photo-1627818032590-6fab3d942af9?q=80&w=2670&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Art Gallery of Ontario", "Art Expo", "Art World", 20.00m });
        }
    }
}
