using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "c4687305-bb1f-4d48-873d-69a71bca981c", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAENdx1VnhKqitRM401UBQs9qDCbSpidXi14qQS9LqafrTAs9ElPeOdud9INze+tQO8w==", null, false, "38aa1359-0a78-48f7-a36d-04608e0b8ec7", false, "admin@localhost.com" });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 39, 53, 654, DateTimeKind.Local).AddTicks(7051), new DateTime(2025, 11, 24, 16, 39, 53, 654, DateTimeKind.Local).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 39, 53, 654, DateTimeKind.Local).AddTicks(7078), new DateTime(2025, 11, 24, 16, 39, 53, 654, DateTimeKind.Local).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 39, 53, 654, DateTimeKind.Local).AddTicks(7522), new DateTime(2025, 11, 24, 16, 39, 53, 654, DateTimeKind.Local).AddTicks(7523) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 39, 53, 654, DateTimeKind.Local).AddTicks(7525), new DateTime(2025, 11, 24, 16, 39, 53, 654, DateTimeKind.Local).AddTicks(7526) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 39, 53, 654, DateTimeKind.Local).AddTicks(7685), new DateTime(2025, 11, 24, 16, 39, 53, 654, DateTimeKind.Local).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 39, 53, 654, DateTimeKind.Local).AddTicks(7688), new DateTime(2025, 11, 24, 16, 39, 53, 654, DateTimeKind.Local).AddTicks(7689) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 39, 53, 654, DateTimeKind.Local).AddTicks(7690), new DateTime(2025, 11, 24, 16, 39, 53, 654, DateTimeKind.Local).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 39, 53, 654, DateTimeKind.Local).AddTicks(7693), new DateTime(2025, 11, 24, 16, 39, 53, 654, DateTimeKind.Local).AddTicks(7694) });
        }
    }
}
