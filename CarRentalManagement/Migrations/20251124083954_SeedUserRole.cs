using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 32, 6, 358, DateTimeKind.Local).AddTicks(6666), new DateTime(2025, 11, 24, 16, 32, 6, 358, DateTimeKind.Local).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 32, 6, 358, DateTimeKind.Local).AddTicks(6690), new DateTime(2025, 11, 24, 16, 32, 6, 358, DateTimeKind.Local).AddTicks(6691) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 32, 6, 358, DateTimeKind.Local).AddTicks(7005), new DateTime(2025, 11, 24, 16, 32, 6, 358, DateTimeKind.Local).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 32, 6, 358, DateTimeKind.Local).AddTicks(7008), new DateTime(2025, 11, 24, 16, 32, 6, 358, DateTimeKind.Local).AddTicks(7009) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 32, 6, 358, DateTimeKind.Local).AddTicks(7166), new DateTime(2025, 11, 24, 16, 32, 6, 358, DateTimeKind.Local).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 32, 6, 358, DateTimeKind.Local).AddTicks(7169), new DateTime(2025, 11, 24, 16, 32, 6, 358, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 32, 6, 358, DateTimeKind.Local).AddTicks(7172), new DateTime(2025, 11, 24, 16, 32, 6, 358, DateTimeKind.Local).AddTicks(7172) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 32, 6, 358, DateTimeKind.Local).AddTicks(7174), new DateTime(2025, 11, 24, 16, 32, 6, 358, DateTimeKind.Local).AddTicks(7175) });
        }
    }
}
