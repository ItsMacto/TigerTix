using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TigerTix.Web.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Date", "Description", "ImageUrl", "Location", "Name", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 19, 1, 0, 28, 54, DateTimeKind.Local).AddTicks(5630), "An amazing concert.", "/images/event1.jpg", "Venue A", "Concert A", 50.00m },
                    { 2, new DateTime(2024, 10, 29, 1, 0, 28, 54, DateTimeKind.Local).AddTicks(5680), "A fun festival.", "/images/event2.jpg", "Venue B", "Festival B", 30.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
