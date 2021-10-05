using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOOKING.Application.Commands;
using BOOKING.Application.Persistence;
using BOOKING.Domain.BookingVindue;

namespace BOOKING.Application.Implementation
{
    class CreateBookingVindueUseCase : ICreateBookingVindueUseCase
    {
        private readonly IBookingVindueRepository _repository;
        
        public CreateBookingVindueUseCase(IBookingVindueRepository repository)
        {
            _repository = repository;
        }

        public void CreateBookingVindue(BookingVindueCommand bookingVindueCommand)
        {
            var bookingVindue = new BookingVindueEntity();
            _repository.Save(bookingVindue);
        }
    }
}
