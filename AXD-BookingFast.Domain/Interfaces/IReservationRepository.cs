using AXD_BookingFast.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXD_BookingFast.Domain.Interfaces
{
    public interface IReservationRepository : IRepository<Reservation>
    {
        /// <summary>
        /// Obtener reservaciones por habitación.
        /// </summary>
        /// <param name="roomId"></param>
        /// <returns></returns>
        Task<IEnumerable<Reservation>> GetReservationsByRoomAsync(Guid roomId);
    }
}
