using AXD_BookingFast.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXD_BookingFast.Domain.Interfaces
{
    public interface IHotelRepository : IRepository<Hotel>
    {
        /// <summary>
        /// Obtener un hotel por id con las habitaciones.
        /// </summary>
        /// <param name="hotelId"></param>
        /// <returns></returns>
        Task<Hotel?> GetHotelWithRoomsAsync(Guid hotelId);
    }
}
