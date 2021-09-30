using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BOOKING.Domain.Booking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BOOKING.Persistence.DbMapping
{
    public class BookingEntityTypeConfiguration : IEntityTypeConfiguration<BookingEntity>
    {
        public void Configure(EntityTypeBuilder<BookingEntity> builder)
        {
            builder.HasKey(b => b.BookingID);

            builder
                .Property(b => b.StartTid)
                .IsRequired();

            builder
                .Property(b => b.SlutTid)
                .IsRequired();
        }
    }
}
