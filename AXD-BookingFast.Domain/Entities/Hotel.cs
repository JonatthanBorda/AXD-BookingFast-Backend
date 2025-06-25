using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXD_BookingFast.Domain.Entities
{
    public class Hotel
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string City { get; set; }

        public ICollection<Room>? Rooms { get; set; }
    }
}
