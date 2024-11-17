using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TigerTix.Web.Migrations
{
    /// <inheritdoc />
    public partial class EventTypeToEvents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "EventType" },
                values: new object[] { new DateTime(2024, 12, 2, 11, 17, 30, 804, DateTimeKind.Local).AddTicks(290), "Concert" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 12, 17, 11, 17, 30, 804, DateTimeKind.Local).AddTicks(339));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "EventType" },
                values: new object[] { new DateTime(2024, 12, 2, 11, 11, 35, 84, DateTimeKind.Local).AddTicks(8416), null });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 12, 17, 11, 11, 35, 84, DateTimeKind.Local).AddTicks(8468));
        }
    }
}
