using AXD_BookingFast.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXD_BookingFast.Domain.Entities
{
    public class RoomRate
    {
        public Guid Id { get; set; }
        public Guid HotelId { get; set; }
        public RoomType RoomType { get; set; }
        public SeasonType SeasonType { get; set; }
        public int PeopleCount { get; set; }
        public decimal PricePerNight { get; set; }
    }
}
