using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TigerTix.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddIsPublishedToEvents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPublished",
                table: "Events",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "IsPublished" },
                values: new object[] { new DateTime(2025, 1, 5, 18, 21, 21, 540, DateTimeKind.Local).AddTicks(5830), false });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "IsPublished" },
                values: new object[] { new DateTime(2024, 12, 21, 18, 21, 21, 540, DateTimeKind.Local).AddTicks(5860), false });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "IsPublished" },
                values: new object[] { new DateTime(2025, 1, 15, 18, 21, 21, 540, DateTimeKind.Local).AddTicks(5860), false });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "IsPublished" },
                values: new object[] { new DateTime(2024, 12, 31, 18, 21, 21, 540, DateTimeKind.Local).AddTicks(5870), false });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "IsPublished" },
                values: new object[] { new DateTime(2024, 12, 26, 18, 21, 21, 540, DateTimeKind.Local).AddTicks(5870), false });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "IsPublished" },
                values: new object[] { new DateTime(2024, 12, 16, 18, 21, 21, 540, DateTimeKind.Local).AddTicks(5870), false });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "IsPublished" },
                values: new object[] { new DateTime(2025, 1, 10, 18, 21, 21, 540, DateTimeKind.Local).AddTicks(5870), false });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "IsPublished" },
                values: new object[] { new DateTime(2024, 12, 28, 18, 21, 21, 540, DateTimeKind.Local).AddTicks(5870), false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPublished",
                table: "Events");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 12, 17, 13, 7, 1, 463, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 12, 2, 13, 7, 1, 463, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 12, 27, 13, 7, 1, 463, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 12, 12, 13, 7, 1, 463, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 12, 7, 13, 7, 1, 463, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 11, 27, 13, 7, 1, 463, DateTimeKind.Local).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 12, 22, 13, 7, 1, 463, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 12, 9, 13, 7, 1, 463, DateTimeKind.Local).AddTicks(4679));
        }
    }
}
