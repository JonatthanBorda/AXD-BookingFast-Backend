using AXD_BookingFast.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXD_BookingFast.Application.DTOs
{
    public class RoomTypeAvailabilityDto
    {
        public RoomType RoomType { get; set; }
        public int TotalRooms { get; set; }
        public int AvailableRooms { get; set; }
        public int MaxPeoplePerRoom { get; set; }
    }
}
