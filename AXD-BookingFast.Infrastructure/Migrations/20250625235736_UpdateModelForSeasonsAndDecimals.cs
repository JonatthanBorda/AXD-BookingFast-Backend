using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AXD_BookingFast.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModelForSeasonsAndDecimals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: new Guid("6c634f08-339b-4e56-b60e-8752e134cb3d"));

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: new Guid("768124bd-a809-4130-af6d-3852374453d5"));

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "EndDate", "SeasonType", "StartDate" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2025, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2026, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "EndDate", "SeasonType", "StartDate" },
                values: new object[,]
                {
                    { new Guid("6c634f08-339b-4e56-b60e-8752e134cb3d"), new DateTime(2026, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("768124bd-a809-4130-af6d-3852374453d5"), new DateTime(2025, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
