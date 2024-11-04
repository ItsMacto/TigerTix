using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TigerTix.Web.Migrations
{
    /// <inheritdoc />
    public partial class addedEvebnts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AvailableTickets",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Organizer",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvailableTickets", "Category", "Date", "Description", "ImageUrl", "Location", "Name", "Organizer", "Price" },
                values: new object[] { 150, "Music", new DateTime(2024, 11, 18, 19, 42, 49, 765, DateTimeKind.Local).AddTicks(6760), "Experience an electrifying night with top rock bands.", "/images/rock-concert.jpg", "Madison Square Garden", "Rock Concert", "Live Nation", 75.00m });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvailableTickets", "Category", "Date", "Description", "ImageUrl", "Location", "Name", "Organizer", "Price" },
                values: new object[] { 300, "Exhibition", new DateTime(2024, 12, 3, 19, 42, 49, 765, DateTimeKind.Local).AddTicks(6790), "Discover contemporary art from around the world.", "/images/art-expo.jpg", "Art Gallery of Ontario", "Art Expo", "Art World", 20.00m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvailableTickets",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Organizer",
                table: "Events");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Description", "ImageUrl", "Location", "Name", "Price" },
                values: new object[] { new DateTime(2024, 10, 19, 1, 0, 28, 54, DateTimeKind.Local).AddTicks(5630), "An amazing concert.", "/images/event1.jpg", "Venue A", "Concert A", 50.00m });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Description", "ImageUrl", "Location", "Name", "Price" },
                values: new object[] { new DateTime(2024, 10, 29, 1, 0, 28, 54, DateTimeKind.Local).AddTicks(5680), "A fun festival.", "/images/event2.jpg", "Venue B", "Festival B", 30.00m });
        }
    }
}
