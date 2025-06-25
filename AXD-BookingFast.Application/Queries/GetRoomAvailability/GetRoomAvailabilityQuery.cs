using AXD_BookingFast.Application.DTOs;
using AXD_BookingFast.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXD_BookingFast.Application.Queries.GetRoomAvailability
{
    public class GetRoomAvailabilityQuery : IRequest<RoomAvailabilityDto>
    {
        public Guid HotelId { get; set; }
        public RoomType RoomType { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int PeopleCount { get; set; }
        public int RoomsNeeded { get; set; }
    }
}
