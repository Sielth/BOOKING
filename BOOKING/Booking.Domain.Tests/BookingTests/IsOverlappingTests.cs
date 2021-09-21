using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Booking.Domain.Tests.BookingTests
{
    public class IsOverlappingTests
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var sut = new BOOKING.Domain.Booking.BookingEntity();
            var expected = false;
            //Act
            var actual = sut.IsOverlapping(new List<BOOKING.Domain.Booking.BookingEntity>());
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GivenBookingIsOverlapping_ThenReturnTrue()
        {
            //Arrange
            var sut = new BOOKING.Domain.Booking.BookingEntity(new DateTime(2021, 9, 1, 10, 0, 0), new DateTime(2021, 9, 1, 12, 0, 0));
            var otherBookings = new List<BOOKING.Domain.Booking.BookingEntity>(new[]
            {
                new BOOKING.Domain.Booking.BookingEntity(new DateTime(2021,9,1, 11, 0, 0),new DateTime(2021,9,1,13,0,0))
            });
            var expected = true;
            //Act
            var actual = sut.IsOverlapping(otherBookings);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
