using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 14, 57, 30, 597, DateTimeKind.Local).AddTicks(8867), new DateTime(2025, 11, 24, 14, 57, 30, 597, DateTimeKind.Local).AddTicks(8883), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 14, 57, 30, 597, DateTimeKind.Local).AddTicks(8885), new DateTime(2025, 11, 24, 14, 57, 30, 597, DateTimeKind.Local).AddTicks(8885), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 14, 57, 30, 597, DateTimeKind.Local).AddTicks(9024), new DateTime(2025, 11, 24, 14, 57, 30, 597, DateTimeKind.Local).AddTicks(9024), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 14, 57, 30, 597, DateTimeKind.Local).AddTicks(9026), new DateTime(2025, 11, 24, 14, 57, 30, 597, DateTimeKind.Local).AddTicks(9026), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 14, 57, 30, 597, DateTimeKind.Local).AddTicks(9091), new DateTime(2025, 11, 24, 14, 57, 30, 597, DateTimeKind.Local).AddTicks(9091), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 14, 57, 30, 597, DateTimeKind.Local).AddTicks(9092), new DateTime(2025, 11, 24, 14, 57, 30, 597, DateTimeKind.Local).AddTicks(9093), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 24, 14, 57, 30, 597, DateTimeKind.Local).AddTicks(9093), new DateTime(2025, 11, 24, 14, 57, 30, 597, DateTimeKind.Local).AddTicks(9094), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 24, 14, 57, 30, 597, DateTimeKind.Local).AddTicks(9094), new DateTime(2025, 11, 24, 14, 57, 30, 597, DateTimeKind.Local).AddTicks(9095), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
