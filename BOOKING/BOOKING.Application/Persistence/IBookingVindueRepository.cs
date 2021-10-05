using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOOKING.Domain.BookingVindue;

namespace BOOKING.Application.Persistence
{
    public interface IBookingVindueRepository
    {
        void Save(BookingVindueEntity bookingVindueEntity);
    }
}
