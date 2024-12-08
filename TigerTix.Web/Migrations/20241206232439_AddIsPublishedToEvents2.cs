using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TigerTix.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddIsPublishedToEvents2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 1, 5, 18, 24, 39, 751, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 12, 21, 18, 24, 39, 751, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2025, 1, 15, 18, 24, 39, 751, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 12, 31, 18, 24, 39, 751, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 12, 26, 18, 24, 39, 751, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 12, 16, 18, 24, 39, 751, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2025, 1, 10, 18, 24, 39, 751, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 12, 28, 18, 24, 39, 751, DateTimeKind.Local).AddTicks(8130));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 1, 5, 18, 21, 21, 540, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 12, 21, 18, 21, 21, 540, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2025, 1, 15, 18, 21, 21, 540, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 12, 31, 18, 21, 21, 540, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 12, 26, 18, 21, 21, 540, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 12, 16, 18, 21, 21, 540, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2025, 1, 10, 18, 21, 21, 540, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 12, 28, 18, 21, 21, 540, DateTimeKind.Local).AddTicks(5870));
        }
    }
}
