using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOOKING.Application.Commands;
using BOOKING.Application.Persistence;
using BOOKING.Domain.Kalender;

namespace BOOKING.Application.Implementation
{
    class CreateKalenderUseCase : ICreateKalenderUseCase
    {
        private readonly IKalenderRepository _repository;

        public CreateKalenderUseCase(IKalenderRepository repository)
        {
            _repository = repository;
        }
        public void CreateKalender(KalenderCommand kalenderCommand)
        {
            var kalender = new KalenderEntity();
            _repository.Save(kalender);
        }
    }
}
