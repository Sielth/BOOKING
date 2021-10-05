using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOKING.Application.Commands
{
    class BookingCommand
    {
        public Guid BookingVindue { get; set; }
        public DateTime StartTid { get; set; }
        public DateTime SlutTid { get; set; }
    }
}
