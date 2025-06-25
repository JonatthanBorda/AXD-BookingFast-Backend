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
            //Sedes/habitaciones:
            var hotel1 = new Hotel { Id = Guid.NewGuid(), Name = "Barranquilla", City = "Barranquilla" };
            var hotel2 = new Hotel { Id = Guid.NewGuid(), Name = "Cali", City = "Cali" };
            var hotel3 = new Hotel { Id = Guid.NewGuid(), Name = "Cartagena", City = "Cartagena" };
            var hotel4 = new Hotel { Id = Guid.NewGuid(), Name = "Bogotá", City = "Bogotá" };

            modelBuilder.Entity<Hotel>().HasData(hotel1, hotel2, hotel3, hotel4);

            //Habitaciones y tarifas:
            int roomNumber = 1;
            var rooms = new List<Room>();

            for (int i = 0; i < 30; i++)
                rooms.Add(new Room { Id = Guid.NewGuid(), HotelId = hotel1.Id, RoomType = RoomType.Standard, Number = roomNumber++, MaxPeople = 4 });

            for (int i = 0; i < 3; i++)
                rooms.Add(new Room { Id = Guid.NewGuid(), HotelId = hotel1.Id, RoomType = RoomType.Premium, Number = roomNumber++, MaxPeople = 4 });


            modelBuilder.Entity<Room>().HasData(rooms);
        }
    }
}
