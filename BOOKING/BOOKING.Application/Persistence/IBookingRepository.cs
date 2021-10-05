using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOOKING.Domain.Booking;

namespace BOOKING.Application.Persistence
{
    public interface IBookingRepository
    {
        void Save(BookingEntity booking);
    }
}
