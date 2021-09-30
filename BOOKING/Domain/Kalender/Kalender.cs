using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOKING.Domain.Kalender
{
    public class Kalender
    {
        public int KalenderID { get; }
        public BookingVindue.BookingVindueEntity BookingVindueEntity { get; set; }
        public Hold.HoldEntity HoldEntity { get; set; }
    }
}
