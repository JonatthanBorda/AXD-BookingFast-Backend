using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AXD_BookingFast.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomRates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HotelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomType = table.Column<int>(type: "int", nullable: false),
                    SeasonType = table.Column<int>(type: "int", nullable: false),
                    PeopleCount = table.Column<int>(type: "int", nullable: false),
                    PricePerNight = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomRates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SeasonType = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HotelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomType = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    MaxPeople = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CheckIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PeopleCount = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "City", "Name" },
                values: new object[,]
                {
                    { new Guid("7e7db5c0-7d1d-4e9c-b226-6e2d1390c7f4"), "Cartagena", "Cartagena" },
                    { new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), "Bogotá", "Bogotá" },
                    { new Guid("ea2c6bb1-9515-4443-bfb8-b80cfbfe15ef"), "Cali", "Cali" },
                    { new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), "Barranquilla", "Barranquilla" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "HotelId", "MaxPeople", "Number", "RoomType" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0001-000000000001"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 1, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000002"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 2, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000003"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 3, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000004"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 4, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000005"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 5, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000006"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 6, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000007"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 7, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000008"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 8, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000009"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 9, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000010"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 10, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000011"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 11, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000012"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 12, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000013"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 13, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000014"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 14, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000015"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 15, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000016"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 16, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000017"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 17, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000018"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 18, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000019"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 19, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000020"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 20, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000021"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 21, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000022"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 22, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000023"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 23, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000024"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 24, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000025"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 25, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000026"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 26, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000027"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 27, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000028"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 28, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000029"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 29, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000030"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 30, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000031"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 31, 2 },
                    { new Guid("00000000-0000-0000-0001-000000000032"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 32, 2 },
                    { new Guid("00000000-0000-0000-0001-000000000033"), new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"), 4, 33, 2 },
                    { new Guid("00000000-0000-0000-0002-000000000034"), new Guid("ea2c6bb1-9515-4443-bfb8-b80cfbfe15ef"), 6, 1, 2 },
                    { new Guid("00000000-0000-0000-0002-000000000035"), new Guid("ea2c6bb1-9515-4443-bfb8-b80cfbfe15ef"), 6, 2, 2 },
                    { new Guid("00000000-0000-0000-0002-000000000036"), new Guid("ea2c6bb1-9515-4443-bfb8-b80cfbfe15ef"), 6, 3, 2 },
                    { new Guid("00000000-0000-0000-0002-000000000037"), new Guid("ea2c6bb1-9515-4443-bfb8-b80cfbfe15ef"), 6, 4, 2 },
                    { new Guid("00000000-0000-0000-0002-000000000038"), new Guid("ea2c6bb1-9515-4443-bfb8-b80cfbfe15ef"), 6, 5, 2 },
                    { new Guid("00000000-0000-0000-0002-000000000039"), new Guid("ea2c6bb1-9515-4443-bfb8-b80cfbfe15ef"), 6, 6, 2 },
                    { new Guid("00000000-0000-0000-0002-000000000040"), new Guid("ea2c6bb1-9515-4443-bfb8-b80cfbfe15ef"), 6, 7, 2 },
                    { new Guid("00000000-0000-0000-0002-000000000041"), new Guid("ea2c6bb1-9515-4443-bfb8-b80cfbfe15ef"), 6, 8, 2 },
                    { new Guid("00000000-0000-0000-0002-000000000042"), new Guid("ea2c6bb1-9515-4443-bfb8-b80cfbfe15ef"), 6, 9, 2 },
                    { new Guid("00000000-0000-0000-0002-000000000043"), new Guid("ea2c6bb1-9515-4443-bfb8-b80cfbfe15ef"), 6, 10, 2 },
                    { new Guid("00000000-0000-0000-0002-000000000044"), new Guid("ea2c6bb1-9515-4443-bfb8-b80cfbfe15ef"), 6, 11, 2 },
                    { new Guid("00000000-0000-0000-0002-000000000045"), new Guid("ea2c6bb1-9515-4443-bfb8-b80cfbfe15ef"), 6, 12, 2 },
                    { new Guid("00000000-0000-0000-0002-000000000046"), new Guid("ea2c6bb1-9515-4443-bfb8-b80cfbfe15ef"), 6, 13, 2 },
                    { new Guid("00000000-0000-0000-0002-000000000047"), new Guid("ea2c6bb1-9515-4443-bfb8-b80cfbfe15ef"), 6, 14, 2 },
                    { new Guid("00000000-0000-0000-0002-000000000048"), new Guid("ea2c6bb1-9515-4443-bfb8-b80cfbfe15ef"), 6, 15, 2 },
                    { new Guid("00000000-0000-0000-0002-000000000049"), new Guid("ea2c6bb1-9515-4443-bfb8-b80cfbfe15ef"), 6, 16, 2 },
                    { new Guid("00000000-0000-0000-0002-000000000050"), new Guid("ea2c6bb1-9515-4443-bfb8-b80cfbfe15ef"), 6, 17, 2 },
                    { new Guid("00000000-0000-0000-0002-000000000051"), new Guid("ea2c6bb1-9515-4443-bfb8-b80cfbfe15ef"), 6, 18, 2 },
                    { new Guid("00000000-0000-0000-0002-000000000052"), new Guid("ea2c6bb1-9515-4443-bfb8-b80cfbfe15ef"), 6, 19, 2 },
                    { new Guid("00000000-0000-0000-0002-000000000053"), new Guid("ea2c6bb1-9515-4443-bfb8-b80cfbfe15ef"), 6, 20, 2 },
                    { new Guid("00000000-0000-0000-0002-000000000054"), new Guid("ea2c6bb1-9515-4443-bfb8-b80cfbfe15ef"), 6, 21, 3 },
                    { new Guid("00000000-0000-0000-0002-000000000055"), new Guid("ea2c6bb1-9515-4443-bfb8-b80cfbfe15ef"), 6, 22, 3 },
                    { new Guid("00000000-0000-0000-0003-000000000056"), new Guid("7e7db5c0-7d1d-4e9c-b226-6e2d1390c7f4"), 8, 1, 1 },
                    { new Guid("00000000-0000-0000-0003-000000000057"), new Guid("7e7db5c0-7d1d-4e9c-b226-6e2d1390c7f4"), 8, 2, 1 },
                    { new Guid("00000000-0000-0000-0003-000000000058"), new Guid("7e7db5c0-7d1d-4e9c-b226-6e2d1390c7f4"), 8, 3, 1 },
                    { new Guid("00000000-0000-0000-0003-000000000059"), new Guid("7e7db5c0-7d1d-4e9c-b226-6e2d1390c7f4"), 8, 4, 1 },
                    { new Guid("00000000-0000-0000-0003-000000000060"), new Guid("7e7db5c0-7d1d-4e9c-b226-6e2d1390c7f4"), 8, 5, 1 },
                    { new Guid("00000000-0000-0000-0003-000000000061"), new Guid("7e7db5c0-7d1d-4e9c-b226-6e2d1390c7f4"), 8, 6, 1 },
                    { new Guid("00000000-0000-0000-0003-000000000062"), new Guid("7e7db5c0-7d1d-4e9c-b226-6e2d1390c7f4"), 8, 7, 1 },
                    { new Guid("00000000-0000-0000-0003-000000000063"), new Guid("7e7db5c0-7d1d-4e9c-b226-6e2d1390c7f4"), 8, 8, 1 },
                    { new Guid("00000000-0000-0000-0003-000000000064"), new Guid("7e7db5c0-7d1d-4e9c-b226-6e2d1390c7f4"), 8, 9, 1 },
                    { new Guid("00000000-0000-0000-0003-000000000065"), new Guid("7e7db5c0-7d1d-4e9c-b226-6e2d1390c7f4"), 8, 10, 1 },
                    { new Guid("00000000-0000-0000-0003-000000000066"), new Guid("7e7db5c0-7d1d-4e9c-b226-6e2d1390c7f4"), 8, 11, 2 },
                    { new Guid("00000000-0000-0000-0004-000000000067"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 1, 1 },
                    { new Guid("00000000-0000-0000-0004-000000000068"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 2, 1 },
                    { new Guid("00000000-0000-0000-0004-000000000069"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 3, 1 },
                    { new Guid("00000000-0000-0000-0004-000000000070"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 4, 1 },
                    { new Guid("00000000-0000-0000-0004-000000000071"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 5, 1 },
                    { new Guid("00000000-0000-0000-0004-000000000072"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 6, 1 },
                    { new Guid("00000000-0000-0000-0004-000000000073"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 7, 1 },
                    { new Guid("00000000-0000-0000-0004-000000000074"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 8, 1 },
                    { new Guid("00000000-0000-0000-0004-000000000075"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 9, 1 },
                    { new Guid("00000000-0000-0000-0004-000000000076"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 10, 1 },
                    { new Guid("00000000-0000-0000-0004-000000000077"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 11, 1 },
                    { new Guid("00000000-0000-0000-0004-000000000078"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 12, 1 },
                    { new Guid("00000000-0000-0000-0004-000000000079"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 13, 1 },
                    { new Guid("00000000-0000-0000-0004-000000000080"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 14, 1 },
                    { new Guid("00000000-0000-0000-0004-000000000081"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 15, 1 },
                    { new Guid("00000000-0000-0000-0004-000000000082"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 16, 1 },
                    { new Guid("00000000-0000-0000-0004-000000000083"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 17, 1 },
                    { new Guid("00000000-0000-0000-0004-000000000084"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 18, 1 },
                    { new Guid("00000000-0000-0000-0004-000000000085"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 19, 1 },
                    { new Guid("00000000-0000-0000-0004-000000000086"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 20, 1 },
                    { new Guid("00000000-0000-0000-0004-000000000087"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 21, 2 },
                    { new Guid("00000000-0000-0000-0004-000000000088"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 22, 2 },
                    { new Guid("00000000-0000-0000-0004-000000000089"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 23, 2 },
                    { new Guid("00000000-0000-0000-0004-000000000090"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 24, 2 },
                    { new Guid("00000000-0000-0000-0004-000000000091"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 25, 2 },
                    { new Guid("00000000-0000-0000-0004-000000000092"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 26, 2 },
                    { new Guid("00000000-0000-0000-0004-000000000093"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 27, 2 },
                    { new Guid("00000000-0000-0000-0004-000000000094"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 28, 2 },
                    { new Guid("00000000-0000-0000-0004-000000000095"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 29, 2 },
                    { new Guid("00000000-0000-0000-0004-000000000096"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 30, 2 },
                    { new Guid("00000000-0000-0000-0004-000000000097"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 31, 2 },
                    { new Guid("00000000-0000-0000-0004-000000000098"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 32, 2 },
                    { new Guid("00000000-0000-0000-0004-000000000099"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 33, 2 },
                    { new Guid("00000000-0000-0000-0004-000000000100"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 34, 2 },
                    { new Guid("00000000-0000-0000-0004-000000000101"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 35, 2 },
                    { new Guid("00000000-0000-0000-0004-000000000102"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 36, 2 },
                    { new Guid("00000000-0000-0000-0004-000000000103"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 37, 2 },
                    { new Guid("00000000-0000-0000-0004-000000000104"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 38, 2 },
                    { new Guid("00000000-0000-0000-0004-000000000105"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 39, 2 },
                    { new Guid("00000000-0000-0000-0004-000000000106"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 40, 2 },
                    { new Guid("00000000-0000-0000-0004-000000000107"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 41, 3 },
                    { new Guid("00000000-0000-0000-0004-000000000108"), new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"), 6, 42, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RoomId",
                table: "Reservations",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_HotelId",
                table: "Rooms",
                column: "HotelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "RoomRates");

            migrationBuilder.DropTable(
                name: "Seasons");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Hotels");
        }
    }
}
