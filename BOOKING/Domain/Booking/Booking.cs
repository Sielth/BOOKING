using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOKING.Domain.Booking
{
    public class Booking : IBooking
    {
        public int BookingID { get; set; }
        public DateTime StartTid { get; set; }
        public DateTime SlutTid { get; set; }

        public Booking(DateTime startTid, DateTime slutTid)
        {
            if (startTid == default) throw new ArgumentException($"StartTid skal være udfuldt.");
            StartTid = startTid;
            SlutTid = slutTid;
        }

        public bool IsOverlapping(List<Booking> otherBookings)
        {
            var result = otherBookings.Any(a => a.StartTid >= StartTid && StartTid <= a.SlutTid);
            return result;
        }
    }
}
