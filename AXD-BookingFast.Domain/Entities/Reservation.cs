using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXD_BookingFast.Domain.Entities
{
    public class Reservation
    {
        public Guid Id { get; set; }
        public Guid RoomId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int PeopleCount { get; set; }
        public decimal TotalPrice { get; set; }

        //Llave foranea a Room:
        public Room? Room { get; set; }
    }
}
