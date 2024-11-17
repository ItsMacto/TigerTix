using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TigerTix.Web.Migrations
{
    /// <inheritdoc />
    public partial class EventTypeToEvent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 12, 2, 11, 11, 35, 84, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 12, 17, 11, 11, 35, 84, DateTimeKind.Local).AddTicks(8468));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 12, 2, 11, 2, 31, 549, DateTimeKind.Local).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 12, 17, 11, 2, 31, 549, DateTimeKind.Local).AddTicks(1720));
        }
    }
}
