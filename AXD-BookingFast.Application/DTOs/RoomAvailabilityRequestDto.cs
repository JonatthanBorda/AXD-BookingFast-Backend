using AXD_BookingFast.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXD_BookingFast.Application.DTOs
{
    public class RoomAvailabilityRequestDto
    {
        public Guid HotelId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public RoomType RoomType { get; set; }
        public int PeopleCount { get; set; }
        public int RoomsNeeded { get; set; }
    }
}
