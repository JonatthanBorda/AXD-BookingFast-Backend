using AXD_BookingFast.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXD_BookingFast.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IHotelRepository Hotels { get; }
        IRoomRepository Rooms { get; }
        IReservationRepository Reservations { get; }
        ISeasonRepository Seasons { get; }
        IRoomRateRepository RoomRates { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
