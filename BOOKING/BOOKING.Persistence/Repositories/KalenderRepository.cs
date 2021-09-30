using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOOKING.Application.Persistence;
using BOOKING.Domain.Kalender;
using BOOKING.Persistence.Context;

namespace BOOKING.Persistence.Repositories
{
    class KalenderRepository : IKalenderRepository
    {
        private readonly BOOKINGContext _context;

        public KalenderRepository(BOOKINGContext context)
        {
            _context = context;
        }

        void IKalenderRepository.Save(KalenderEntity kalenderEntity)
        {
            _context.Kalendere.Add(kalenderEntity);
            _context.SaveChanges();
        }
    }
}
