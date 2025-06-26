using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AXD_BookingFast.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddRoomRatesData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RoomRates",
                columns: new[] { "Id", "HotelId", "PeopleCount", "PricePerNight", "RoomType", "SeasonType" },
                values: new object[,]
                {
                    { new Guid("10101010-1010-1010-1010-101010101010"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 500000m, 1, 2 },
                    { new Guid("10101010-1010-1010-1010-101010101011"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 600000m, 2, 1 },
                    { new Guid("10101010-1010-1010-1010-101010101012"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 550000m, 1, 1 },
                    { new Guid("20202020-2020-2020-2020-202020202020"), new Guid("ea2c6bb1-9515-4443-bfb8-b80cfbfe15ef"), 6, 700000m, 2, 2 },
                    { new Guid("20202020-2020-2020-2020-202020202021"), new Guid("ea2c6bb1-9515-4443-bfb8-b80cfbfe15ef"), 6, 800000m, 3, 1 },
                    { new Guid("30303030-3030-3030-3030-303030303030"), new Guid("7e7db5c0-7d1d-4e9c-b226-6e2d1390c7f4"), 8, 650000m, 1, 1 },
                    { new Guid("30303030-3030-3030-3030-303030303031"), new Guid("7e7db5c0-7d1d-4e9c-b226-6e2d1390c7f4"), 8, 750000m, 2, 1 },
                    { new Guid("40404040-4040-4040-4040-404040404040"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 900000m, 1, 2 },
                    { new Guid("40404040-4040-4040-4040-404040404041"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 1000000m, 2, 1 },
                    { new Guid("40404040-4040-4040-4040-404040404042"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 1200000m, 3, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoomRates",
                keyColumn: "Id",
                keyValue: new Guid("10101010-1010-1010-1010-101010101010"));

            migrationBuilder.DeleteData(
                table: "RoomRates",
                keyColumn: "Id",
                keyValue: new Guid("10101010-1010-1010-1010-101010101011"));

            migrationBuilder.DeleteData(
                table: "RoomRates",
                keyColumn: "Id",
                keyValue: new Guid("10101010-1010-1010-1010-101010101012"));

            migrationBuilder.DeleteData(
                table: "RoomRates",
                keyColumn: "Id",
                keyValue: new Guid("20202020-2020-2020-2020-202020202020"));

            migrationBuilder.DeleteData(
                table: "RoomRates",
                keyColumn: "Id",
                keyValue: new Guid("20202020-2020-2020-2020-202020202021"));

            migrationBuilder.DeleteData(
                table: "RoomRates",
                keyColumn: "Id",
                keyValue: new Guid("30303030-3030-3030-3030-303030303030"));

            migrationBuilder.DeleteData(
                table: "RoomRates",
                keyColumn: "Id",
                keyValue: new Guid("30303030-3030-3030-3030-303030303031"));

            migrationBuilder.DeleteData(
                table: "RoomRates",
                keyColumn: "Id",
                keyValue: new Guid("40404040-4040-4040-4040-404040404040"));

            migrationBuilder.DeleteData(
                table: "RoomRates",
                keyColumn: "Id",
                keyValue: new Guid("40404040-4040-4040-4040-404040404041"));

            migrationBuilder.DeleteData(
                table: "RoomRates",
                keyColumn: "Id",
                keyValue: new Guid("40404040-4040-4040-4040-404040404042"));
        }
    }
}
