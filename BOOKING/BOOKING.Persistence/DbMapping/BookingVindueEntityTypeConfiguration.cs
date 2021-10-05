using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOOKING.Domain.BookingVindue;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BOOKING.Persistence.DbMapping
{
    class BookingVindueEntityTypeConfiguration : IEntityTypeConfiguration<BookingVindueEntity>
    {
        public void Configure(EntityTypeBuilder<BookingVindueEntity> builder)
        {
            builder.HasKey(b => b.BookingVindueID);
            builder.Property(x => x.BookingVindueID).HasDefaultValueSql("NEWID()");

            builder
                .HasMany(c => c.Bookinger)
                .WithOne(e => e.BookingVinduer);
        }
    }
}
