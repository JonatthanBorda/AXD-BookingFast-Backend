using AXD_BookingFast.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXD_BookingFast.Domain.Entities
{
    public class Season
    {
        public Guid Id { get; set; }
        public SeasonType SeasonType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
