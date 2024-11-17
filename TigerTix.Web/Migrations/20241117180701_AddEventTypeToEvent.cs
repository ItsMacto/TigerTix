using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TigerTix.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddEventTypeToEvent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "EventType" },
                values: new object[] { new DateTime(2024, 12, 17, 13, 7, 1, 463, DateTimeKind.Local).AddTicks(4614), "Concert" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "EventType" },
                values: new object[] { new DateTime(2024, 12, 2, 13, 7, 1, 463, DateTimeKind.Local).AddTicks(4664), "Sports" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "EventType" },
                values: new object[] { new DateTime(2024, 12, 27, 13, 7, 1, 463, DateTimeKind.Local).AddTicks(4667), "Concert" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "EventType" },
                values: new object[] { new DateTime(2024, 12, 12, 13, 7, 1, 463, DateTimeKind.Local).AddTicks(4670), "Sports" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "EventType" },
                values: new object[] { new DateTime(2024, 12, 7, 13, 7, 1, 463, DateTimeKind.Local).AddTicks(4672), "Concert" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "EventType" },
                values: new object[] { new DateTime(2024, 11, 27, 13, 7, 1, 463, DateTimeKind.Local).AddTicks(4674), "Sports" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "EventType" },
                values: new object[] { new DateTime(2024, 12, 22, 13, 7, 1, 463, DateTimeKind.Local).AddTicks(4677), "Concert" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "EventType" },
                values: new object[] { new DateTime(2024, 12, 9, 13, 7, 1, 463, DateTimeKind.Local).AddTicks(4679), "Sports" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "EventType" },
                values: new object[] { new DateTime(2024, 12, 3, 20, 45, 14, 371, DateTimeKind.Local).AddTicks(7590), null });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "EventType" },
                values: new object[] { new DateTime(2024, 11, 18, 20, 45, 14, 371, DateTimeKind.Local).AddTicks(7620), null });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "EventType" },
                values: new object[] { new DateTime(2024, 12, 13, 20, 45, 14, 371, DateTimeKind.Local).AddTicks(7620), null });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "EventType" },
                values: new object[] { new DateTime(2024, 11, 28, 20, 45, 14, 371, DateTimeKind.Local).AddTicks(7630), null });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "EventType" },
                values: new object[] { new DateTime(2024, 11, 23, 20, 45, 14, 371, DateTimeKind.Local).AddTicks(7630), null });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "EventType" },
                values: new object[] { new DateTime(2024, 11, 13, 20, 45, 14, 371, DateTimeKind.Local).AddTicks(7630), null });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "EventType" },
                values: new object[] { new DateTime(2024, 12, 8, 20, 45, 14, 371, DateTimeKind.Local).AddTicks(7640), null });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "EventType" },
                values: new object[] { new DateTime(2024, 11, 25, 20, 45, 14, 371, DateTimeKind.Local).AddTicks(7640), null });
        }
    }
}
