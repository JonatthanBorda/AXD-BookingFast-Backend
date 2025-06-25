using AXD_BookingFast.Application.DTOs;
using AXD_BookingFast.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXD_BookingFast.Application.Queries.GetRoomRate
{
    public class GetRoomRateQuery : IRequest<RoomRateDto>
    {
        public Guid HotelId { get; set; }
        public RoomType RoomType { get; set; }
        public int PeopleCount { get; set; }
        public DateTime CheckIn { get; set; }
    }
}
