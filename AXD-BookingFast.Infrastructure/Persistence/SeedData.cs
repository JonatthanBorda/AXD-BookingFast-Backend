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
            //IDs fijos para los hoteles:
            var hotel1Id = new Guid("f7b9ce9b-2ff0-4bc5-b42a-46948a0f8136"); // Barranquilla
            var hotel2Id = new Guid("ea2c6bb1-9515-4443-bfb8-b80cfbfe15ef"); // Cali
            var hotel3Id = new Guid("7e7db5c0-7d1d-4e9c-b226-6e2d1390c7f4"); // Cartagena
            var hotel4Id = new Guid("95c27ad9-3d5f-4f32-8e5e-bd4d91a9907d"); // Bogotá

            //Hoteles:
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel { Id = hotel1Id, Name = "Barranquilla", City = "Barranquilla" },
                new Hotel { Id = hotel2Id, Name = "Cali", City = "Cali" },
                new Hotel { Id = hotel3Id, Name = "Cartagena", City = "Cartagena" },
                new Hotel { Id = hotel4Id, Name = "Bogotá", City = "Bogotá" }
            );

            //Habitaciones:
            var rooms = new List<Room>();
            int roomNum = 1;
            int idCount = 1;

            //Barranquilla: 30 estándar, 3 premium; max 4 personas
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

            //Cali: 20 premium, 2 VIP; max 6 personas
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

            //Cartagena: 10 estándar, 1 premium; max 8 personas
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

            //Bogotá: 20 estándar, 20 premium, 2 VIP; max 6 personas
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

            modelBuilder.Entity<Room>().HasData(rooms);
        }
    }
}
