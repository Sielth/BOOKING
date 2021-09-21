using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOKING.Domain.Booking
{
    interface IBooking
    {
        int BookingID { get; set; }
        DateTime StartTid { get; set; }
        DateTime SlutTid { get; set; }

        bool IsOverlapping(List<Booking> otherBookings);
    }
}
