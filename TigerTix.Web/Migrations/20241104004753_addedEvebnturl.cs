using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TigerTix.Web.Migrations
{
    /// <inheritdoc />
    public partial class addedEvebnturl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "ImageUrl" },
                values: new object[] { new DateTime(2024, 11, 18, 19, 47, 53, 359, DateTimeKind.Local).AddTicks(2320), "https://images.unsplash.com/photo-1712763113004-e375adb253c3?q=80&w=2748&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "ImageUrl" },
                values: new object[] { new DateTime(2024, 12, 3, 19, 47, 53, 359, DateTimeKind.Local).AddTicks(2360), "https://images.unsplash.com/photo-1627818032590-6fab3d942af9?q=80&w=2670&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "ImageUrl" },
                values: new object[] { new DateTime(2024, 11, 18, 19, 42, 49, 765, DateTimeKind.Local).AddTicks(6760), "/images/rock-concert.jpg" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "ImageUrl" },
                values: new object[] { new DateTime(2024, 12, 3, 19, 42, 49, 765, DateTimeKind.Local).AddTicks(6790), "/images/art-expo.jpg" });
        }
    }
}
