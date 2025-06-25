using AXD_BookingFast.Domain.Interfaces;
using AXD_BookingFast.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXD_BookingFast.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public IHotelRepository Hotels { get; }
        public IRoomRepository Rooms { get; }
        public IReservationRepository Reservations { get; }
        public ISeasonRepository Seasons { get; }
        public IRoomRateRepository RoomRates { get; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Hotels = new HotelRepository(_context);
            Rooms = new RoomRepository(_context);
            Reservations = new ReservationRepository(_context);
            Seasons = new SeasonRepository(_context);
            RoomRates = new RoomRateRepository(_context);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
