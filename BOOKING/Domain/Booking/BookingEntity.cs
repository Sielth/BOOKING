using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOKING.Domain.Booking
{
    public class BookingEntity : IBookingEntity
    {
        public Guid BookingID { get; set; }
        //public int BookingID { get; set; }
        public DateTime StartTid { get; set; }
        public DateTime SlutTid { get; set; }

        public BookingEntity()
        {

        }

        public BookingEntity(DateTime startTid, DateTime slutTid)
        {
            if (startTid == default) throw new ArgumentException($"StartTid skal være udfuldt.");
            StartTid = startTid;
            SlutTid = slutTid;
        }
        /*
        * Logisk bagvendt.
        * Hvis den retunerer true kan der ikke oprettes en booking pga. overlap
        * Hvis den retunerer false kan der oprettes en booking fordi tiden ikke overlapper andre bookinger
        */
        public bool IsOverlapping(List<BookingEntity> otherBookings)
        {
            var result = otherBookings.Any(a => a.StartTid >= StartTid && StartTid <= a.SlutTid);
            return result;
        }
    }
}
