using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BOOKING.Application.Persistence;
using BOOKING.Persistence.Context;
using BOOKING.Domain.Booking;

namespace BOOKING.Persistence.Repositories
{
    class BookingRepository : IBookingRepository
    {
        private readonly BOOKINGContext _context;

        public BookingRepository(BOOKINGContext context)
        {
            _context = context;
        }

        void IBookingRepository.Save(BookingEntity booking)
        {
            _context.Bookinger.Add(booking);
            _context.SaveChanges();
        }
    }
}