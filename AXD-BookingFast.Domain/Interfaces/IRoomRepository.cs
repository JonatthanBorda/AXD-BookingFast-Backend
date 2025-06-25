using AXD_BookingFast.Domain.Entities;
using AXD_BookingFast.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXD_BookingFast.Domain.Interfaces
{
    /// <summary>
    /// Obtener las habitaciones disponibles de un hotel.
    /// Filtrando por tipo de habitación, fechas requeridas y número de personas. 
    /// </summary>
    public interface IRoomRepository : IRepository<Room>
    {
        Task<IEnumerable<Room>> GetAvailableRoomsAsync(Guid hotelId, RoomType roomType, DateTime checkIn, DateTime checkOut, int requiredCount, int requiredPeople);
    }
}
