using AXD_BookingFast.Domain.Entities;
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
    public class ReservationRepository : Repository<Reservation>, IReservationRepository
    {
        public ReservationRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Reservation>> GetReservationsByRoomAsync(Guid roomId)
        {
            return await _context.Reservations.Where(r => r.RoomId == roomId).ToListAsync();
        }
    }
}
