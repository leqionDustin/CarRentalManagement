using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be1bf02a-21ed-4022-baf5-eeaafaa1e16a", "AQAAAAIAAYagAAAAEJr1ErFV/hkZIYkzxopO8GOabEaFh8T/qWGOneUiSxoZNAfXh5gvxl2CvyVV719eMg==", "f450c3e6-d3e4-4ca6-a906-61ea8873c232" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 31, 33, 348, DateTimeKind.Local).AddTicks(8882), new DateTime(2025, 11, 26, 9, 31, 33, 348, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 31, 33, 348, DateTimeKind.Local).AddTicks(8903), new DateTime(2025, 11, 26, 9, 31, 33, 348, DateTimeKind.Local).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 31, 33, 348, DateTimeKind.Local).AddTicks(9081), new DateTime(2025, 11, 26, 9, 31, 33, 348, DateTimeKind.Local).AddTicks(9081) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 31, 33, 348, DateTimeKind.Local).AddTicks(9082), new DateTime(2025, 11, 26, 9, 31, 33, 348, DateTimeKind.Local).AddTicks(9083) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 31, 33, 348, DateTimeKind.Local).AddTicks(9175), new DateTime(2025, 11, 26, 9, 31, 33, 348, DateTimeKind.Local).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 31, 33, 348, DateTimeKind.Local).AddTicks(9176), new DateTime(2025, 11, 26, 9, 31, 33, 348, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 31, 33, 348, DateTimeKind.Local).AddTicks(9177), new DateTime(2025, 11, 26, 9, 31, 33, 348, DateTimeKind.Local).AddTicks(9178) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 31, 33, 348, DateTimeKind.Local).AddTicks(9179), new DateTime(2025, 11, 26, 9, 31, 33, 348, DateTimeKind.Local).AddTicks(9179) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4687305-bb1f-4d48-873d-69a71bca981c", "AQAAAAIAAYagAAAAENdx1VnhKqitRM401UBQs9qDCbSpidXi14qQS9LqafrTAs9ElPeOdud9INze+tQO8w==", "38aa1359-0a78-48f7-a36d-04608e0b8ec7" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 5, 853, DateTimeKind.Local).AddTicks(4019), new DateTime(2025, 11, 26, 9, 30, 5, 853, DateTimeKind.Local).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 5, 853, DateTimeKind.Local).AddTicks(4037), new DateTime(2025, 11, 26, 9, 30, 5, 853, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 5, 853, DateTimeKind.Local).AddTicks(4189), new DateTime(2025, 11, 26, 9, 30, 5, 853, DateTimeKind.Local).AddTicks(4189) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 5, 853, DateTimeKind.Local).AddTicks(4190), new DateTime(2025, 11, 26, 9, 30, 5, 853, DateTimeKind.Local).AddTicks(4191) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 5, 853, DateTimeKind.Local).AddTicks(4260), new DateTime(2025, 11, 26, 9, 30, 5, 853, DateTimeKind.Local).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 5, 853, DateTimeKind.Local).AddTicks(4262), new DateTime(2025, 11, 26, 9, 30, 5, 853, DateTimeKind.Local).AddTicks(4262) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 5, 853, DateTimeKind.Local).AddTicks(4263), new DateTime(2025, 11, 26, 9, 30, 5, 853, DateTimeKind.Local).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 5, 853, DateTimeKind.Local).AddTicks(4264), new DateTime(2025, 11, 26, 9, 30, 5, 853, DateTimeKind.Local).AddTicks(4264) });
        }
    }
}
