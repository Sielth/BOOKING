using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOOKING.Domain.Kalender;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BOOKING.Persistence.DbMapping
{
    class BookingKalenderEntityTypeConfiguration : IEntityTypeConfiguration<KalenderEntity>
    {
        public void Configure(EntityTypeBuilder<KalenderEntity> builder)
        {
            builder.HasKey(b => b.KalenderID);
            builder.Property(x => x.KalenderID).HasDefaultValueSql("NEWID()");

            builder
                .HasMany(c => c.BookingVinduer)
                .WithOne(e => e.Kalender);
        }
    }
}
