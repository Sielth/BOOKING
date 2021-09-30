using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOOKING.Domain.Booking;
using BOOKING.Domain.Kalender;

namespace BOOKING.Domain.BookingVindue
{
    public interface IBookingVindueEntity
    {
        Guid BookingVindueID { get; set; }
        KalenderEntity Kalender { get; set; }
        List<BookingEntity> Bookinger { get; set; }
    }
}
