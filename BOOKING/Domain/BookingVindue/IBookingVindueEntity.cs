using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOKING.Domain.BookingVindue
{
    public interface IBookingVindueEntity
    {
        Guid BookingVindueID { get; set; }
        int KalenderID { get; set; }
    }
}
