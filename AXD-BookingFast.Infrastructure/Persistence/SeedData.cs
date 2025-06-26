using AXD_BookingFast.Domain.Entities;
using AXD_BookingFast.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXD_BookingFast.Infrastructure.Persistence
{
    public static class SeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // IDs fijos para los hoteles (formato GUID correcto)
            var hotel1Id = new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"); // Barranquilla
            var hotel2Id = new Guid("ea2c6bb1-9515-4443-bfb8-b80cfbfe15ef"); // Cali
            var hotel3Id = new Guid("7e7db5c0-7d1d-4e9c-b226-6e2d1390c7f4"); // Cartagena
            var hotel4Id = new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"); // Bogotá

            // Hoteles:
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel { Id = hotel1Id, Name = "Hotel Platinum", City = "Barranquilla" },
                new Hotel { Id = hotel2Id, Name = "Hotel Marriott", City = "Cali" },
                new Hotel { Id = hotel3Id, Name = "Hotel Atlantic Lux", City = "Cartagena" },
                new Hotel { Id = hotel4Id, Name = "Hotel Black Tower Premium", City = "Bogotá" }
            );

            // Datos de Temporadas (Seasons)
            modelBuilder.Entity<Season>().HasData(
                new Season
                {
                    Id = new Guid("11111111-1111-1111-1111-111111111111"),
                    SeasonType = SeasonType.High,
                    StartDate = new DateTime(2025, 06, 01), // Temporada alta
                    EndDate = new DateTime(2025, 08, 31)
                },
                new Season
                {
                    Id = new Guid("22222222-2222-2222-2222-222222222222"),
                    SeasonType = SeasonType.Low,
                    StartDate = new DateTime(2025, 12, 01), // Temporada baja
                    EndDate = new DateTime(2026, 02, 28)
                }
            );

            // Habitaciones (Rooms):
            var rooms = new List<Room>();
            int roomNum = 1;
            int idCount = 1;

            // Barranquilla: 30 estándar, 3 premium; max 4 personas
            for (int i = 0; i < 30; i++)
                rooms.Add(new Room
                {
                    Id = Guid.Parse($"00000000-0000-0000-0001-{idCount++.ToString("D12")}"),
                    HotelId = hotel1Id,
                    RoomType = RoomType.Standard,
                    Number = roomNum++,
                    MaxPeople = 4
                });
            for (int i = 0; i < 3; i++)
                rooms.Add(new Room
                {
                    Id = Guid.Parse($"00000000-0000-0000-0001-{idCount++.ToString("D12")}"),
                    HotelId = hotel1Id,
                    RoomType = RoomType.Premium,
                    Number = roomNum++,
                    MaxPeople = 4
                });

            // Cali: 20 premium, 2 VIP; max 6 personas
            roomNum = 1;
            for (int i = 0; i < 20; i++)
                rooms.Add(new Room
                {
                    Id = Guid.Parse($"00000000-0000-0000-0002-{idCount++.ToString("D12")}"),
                    HotelId = hotel2Id,
                    RoomType = RoomType.Premium,
                    Number = roomNum++,
                    MaxPeople = 6
                });
            for (int i = 0; i < 2; i++)
                rooms.Add(new Room
                {
                    Id = Guid.Parse($"00000000-0000-0000-0002-{idCount++.ToString("D12")}"),
                    HotelId = hotel2Id,
                    RoomType = RoomType.VIP,
                    Number = roomNum++,
                    MaxPeople = 6
                });

            // Cartagena: 10 estándar, 1 premium; max 8 personas
            roomNum = 1;
            for (int i = 0; i < 10; i++)
                rooms.Add(new Room
                {
                    Id = Guid.Parse($"00000000-0000-0000-0003-{idCount++.ToString("D12")}"),
                    HotelId = hotel3Id,
                    RoomType = RoomType.Standard,
                    Number = roomNum++,
                    MaxPeople = 8
                });
            for (int i = 0; i < 1; i++)
                rooms.Add(new Room
                {
                    Id = Guid.Parse($"00000000-0000-0000-0003-{idCount++.ToString("D12")}"),
                    HotelId = hotel3Id,
                    RoomType = RoomType.Premium,
                    Number = roomNum++,
                    MaxPeople = 8
                });

            // Bogotá: 20 estándar, 20 premium, 2 VIP; max 6 personas
            roomNum = 1;
            for (int i = 0; i < 20; i++)
                rooms.Add(new Room
                {
                    Id = Guid.Parse($"00000000-0000-0000-0004-{idCount++.ToString("D12")}"),
                    HotelId = hotel4Id,
                    RoomType = RoomType.Standard,
                    Number = roomNum++,
                    MaxPeople = 6
                });
            for (int i = 0; i < 20; i++)
                rooms.Add(new Room
                {
                    Id = Guid.Parse($"00000000-0000-0000-0004-{idCount++.ToString("D12")}"),
                    HotelId = hotel4Id,
                    RoomType = RoomType.Premium,
                    Number = roomNum++,
                    MaxPeople = 6
                });
            for (int i = 0; i < 2; i++)
                rooms.Add(new Room
                {
                    Id = Guid.Parse($"00000000-0000-0000-0004-{idCount++.ToString("D12")}"),
                    HotelId = hotel4Id,
                    RoomType = RoomType.VIP,
                    Number = roomNum++,
                    MaxPeople = 6
                });

            // Insertar habitaciones:
            modelBuilder.Entity<Room>().HasData(rooms);

            // RoomRates - Precios por noche:
            modelBuilder.Entity<RoomRate>().HasData(
                // Barranquilla (Hotel 1)
                new RoomRate
                {
                    Id = new Guid("10101010-1010-1010-1010-101010101010"),
                    HotelId = hotel1Id,
                    RoomType = RoomType.Standard,
                    SeasonType = SeasonType.High,
                    PeopleCount = 4,
                    PricePerNight = 500000m
                },
                new RoomRate
                {
                    Id = new Guid("10101010-1010-1010-1010-101010101011"),
                    HotelId = hotel1Id,
                    RoomType = RoomType.Premium,
                    SeasonType = SeasonType.Low,
                    PeopleCount = 4,
                    PricePerNight = 600000m
                },
                new RoomRate
                {
                    Id = new Guid("10101010-1010-1010-1010-101010101012"),
                    HotelId = hotel1Id,
                    RoomType = RoomType.Standard,
                    SeasonType = SeasonType.Low,
                    PeopleCount = 4,
                    PricePerNight = 550000m
                },

                // Cali (Hotel 2)
                new RoomRate
                {
                    Id = new Guid("20202020-2020-2020-2020-202020202020"),
                    HotelId = hotel2Id,
                    RoomType = RoomType.Premium,
                    SeasonType = SeasonType.High,
                    PeopleCount = 6,
                    PricePerNight = 700000m
                },
                new RoomRate
                {
                    Id = new Guid("20202020-2020-2020-2020-202020202021"),
                    HotelId = hotel2Id,
                    RoomType = RoomType.VIP,
                    SeasonType = SeasonType.Low,
                    PeopleCount = 6,
                    PricePerNight = 800000m
                },

                // Cartagena (Hotel 3)
                new RoomRate
                {
                    Id = new Guid("30303030-3030-3030-3030-303030303030"),
                    HotelId = hotel3Id,
                    RoomType = RoomType.Standard,
                    SeasonType = SeasonType.Low,
                    PeopleCount = 8,
                    PricePerNight = 650000m
                },
                new RoomRate
                {
                    Id = new Guid("30303030-3030-3030-3030-303030303031"),
                    HotelId = hotel3Id,
                    RoomType = RoomType.Premium,
                    SeasonType = SeasonType.Low,
                    PeopleCount = 8,
                    PricePerNight = 750000m
                },

                // Bogotá (Hotel 4)
                new RoomRate
                {
                    Id = new Guid("40404040-4040-4040-4040-404040404040"),
                    HotelId = hotel4Id,
                    RoomType = RoomType.Standard,
                    SeasonType = SeasonType.High,
                    PeopleCount = 6,
                    PricePerNight = 900000m
                },
                new RoomRate
                {
                    Id = new Guid("40404040-4040-4040-4040-404040404041"),
                    HotelId = hotel4Id,
                    RoomType = RoomType.Premium,
                    SeasonType = SeasonType.Low,
                    PeopleCount = 6,
                    PricePerNight = 1000000m
                },
                new RoomRate
                {
                    Id = new Guid("40404040-4040-4040-4040-404040404042"),
                    HotelId = hotel4Id,
                    RoomType = RoomType.VIP,
                    SeasonType = SeasonType.Low,
                    PeopleCount = 6,
                    PricePerNight = 1200000m
                }
            );
        }
    }

}
