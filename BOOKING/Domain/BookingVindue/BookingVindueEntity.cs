using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOOKING.Domain.Booking;
using BOOKING.Domain.Kalender;

namespace BOOKING.Domain.BookingVindue
{
    public class BookingVindueEntity
    {
        public Guid BookingVindueID { get; set; }
        public KalenderEntity Kalender { get; set; }
        public List<BookingEntity> Bookinger { get; set; }

    }
}
