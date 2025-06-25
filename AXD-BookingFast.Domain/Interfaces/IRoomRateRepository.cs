using AXD_BookingFast.Domain.Entities;
using AXD_BookingFast.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXD_BookingFast.Domain.Interfaces
{
    public interface IRoomRateRepository : IRepository<RoomRate>
    {
        /// <summary>
        /// Obtener rango de precio de reserva.
        /// </summary>
        /// <param name="hotelId"></param>
        /// <param name="roomType"></param>
        /// <param name="seasonType"></param>
        /// <param name="peopleCount"></param>
        /// <returns></returns>
        Task<RoomRate?> GetRateAsync(Guid hotelId, RoomType roomType, SeasonType seasonType, int peopleCount);
    }
}
