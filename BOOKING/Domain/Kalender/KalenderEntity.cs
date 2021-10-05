using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOOKING.Domain.BookingVindue;

namespace BOOKING.Domain.Kalender
{
    public class KalenderEntity
    {
        public int KalenderID { get; set; }
        public List<BookingVindueEntity> BookingVinduer { get; set; }

        //public BookingVindue.BookingVindueEntity BookingVindueEntity { get; set; }
        //public Hold.HoldEntity HoldEntity { get; set; } -- Forbind senere

        public KalenderEntity()
        {

        }
    }
}
