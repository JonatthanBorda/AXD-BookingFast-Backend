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
    public class RoomRateRepository : Repository<RoomRate>, IRoomRateRepository
    {
        public RoomRateRepository(AppDbContext context) : base(context) { }

        public async Task<RoomRate?> GetRateAsync(Guid hotelId, RoomType roomType, SeasonType seasonType, int peopleCount)
        {
            return await _context.RoomRates
                .FirstOrDefaultAsync(r =>
                    r.HotelId == hotelId &&
                    r.RoomType == roomType &&
                    r.SeasonType == seasonType &&
                    r.PeopleCount == peopleCount);
        }
    }
}
