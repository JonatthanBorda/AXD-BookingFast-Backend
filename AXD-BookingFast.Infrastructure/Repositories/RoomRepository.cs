using AXD_BookingFast.Domain.Entities;
using AXD_BookingFast.Domain.Enums;
using AXD_BookingFast.Domain.Interfaces;
using AXD_BookingFast.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXD_BookingFast.Infrastructure.Repositories
{
    public class RoomRepository : Repository<Room>, IRoomRepository
    {
        public RoomRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Room>> GetAvailableRoomsAsync(Guid hotelId, RoomType roomType, DateTime checkIn, DateTime checkOut, int requiredCount, int requiredPeople)
        {
            var rooms = await _context.Rooms
                .Where(r => r.HotelId == hotelId && r.RoomType == roomType && r.MaxPeople >= requiredPeople)
                .Include(r => r.Reservations)
                .ToListAsync();

            return rooms.Where(room =>
                room.Reservations.All(res =>
                    res.CheckOut <= checkIn || res.CheckIn >= checkOut))
                .Take(requiredCount)
                .ToList();
        }
    }
}
