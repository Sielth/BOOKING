using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOOKING.Domain.BookingVindue;

namespace BOOKING.Domain.Kalender
{
    public interface IKalenderEntity
    {
        Guid KalenderID { get; }
        List<BookingVindueEntity> BookingVinduer { get; set; }
        //public Hold.HoldEntity HoldEntity { get; set; } -- Forbind senere
    }
}
