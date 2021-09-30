using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOOKING.Domain.Kalender;


namespace BOOKING.Application.Persistence
{
    public interface IKalenderRepository
    {
        void Save(KalenderEntity kalenderEntity);
    }
}
