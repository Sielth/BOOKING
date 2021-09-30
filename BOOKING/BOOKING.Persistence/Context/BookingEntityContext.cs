using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOOKING.Domain.Booking;
using BOOKING.Domain.Kalender;
using Microsoft.EntityFrameworkCore;

namespace BOOKING.Persistence.Context
{
    class BookingEntityContext : DbContext
    {
        public DbSet<BookingEntity> Bookings { get; set; }
        public DbSet<KalenderEntity> Calendars { get;set; }
    }
}
