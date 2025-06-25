using AXD_BookingFast.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXD_BookingFast.Domain.Entities
{
    public class Room
    {
        public Guid Id { get; set; }
        public Guid HotelId { get; set; }
        public RoomType RoomType { get; set; }
        public int Number { get; set; }
        public int MaxPeople { get; set; }

        //Llaves foráneas a Hotel y Reservation:
        public Hotel? Hotel { get; set; }
        public ICollection<Reservation>? Reservations { get; set; }
    }
}
