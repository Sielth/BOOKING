using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOOKING.Application.Commands;

namespace BOOKING.Application
{
    interface ICreateKalenderUseCase
    {
        void CreateKalender(KalenderCommand kalenderCommand);
    }
}
