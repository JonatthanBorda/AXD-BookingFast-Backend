using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AXD_BookingFast.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSeasonsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("7e7db5c0-7d1d-4e9c-b226-6e2d1390c7f4"),
                column: "Name",
                value: "Hotel Atlantic Lux");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"),
                column: "Name",
                value: "Hotel Black Tower Premium");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("ea2c6bb1-9515-4443-bfb8-b80cfbfe15ef"),
                column: "Name",
                value: "Hotel Marriott");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"),
                column: "Name",
                value: "Hotel Platinum");

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "EndDate", "SeasonType", "StartDate" },
                values: new object[,]
                {
                    { new Guid("6c634f08-339b-4e56-b60e-8752e134cb3d"), new DateTime(2026, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("768124bd-a809-4130-af6d-3852374453d5"), new DateTime(2025, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: new Guid("6c634f08-339b-4e56-b60e-8752e134cb3d"));

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: new Guid("768124bd-a809-4130-af6d-3852374453d5"));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("7e7db5c0-7d1d-4e9c-b226-6e2d1390c7f4"),
                column: "Name",
                value: "Cartagena");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"),
                column: "Name",
                value: "Bogotá");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("ea2c6bb1-9515-4443-bfb8-b80cfbfe15ef"),
                column: "Name",
                value: "Cali");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"),
                column: "Name",
                value: "Barranquilla");
        }
    }
}
