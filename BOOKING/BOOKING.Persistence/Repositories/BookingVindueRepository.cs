using BOOKING.Application.Persistence;
using BOOKING.Domain.BookingVindue;
using BOOKING.Persistence.Context;

namespace BOOKING.Persistence.Repositories
{
    public class BookingVindueRepository : IBookingVindueRepository
    {
        private readonly BOOKINGContext _context;

        public BookingVindueRepository(BOOKINGContext context)
        {
            _context = context;
        }

        void IBookingVindueRepository.Save(BookingVindueEntity bookingVindueEntity)
        {
            _context.BookingVinduer.Add(bookingVindueEntity);
            _context.SaveChanges();
        }

    }
}
