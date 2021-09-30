using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOKING.Domain.Person
{
    public interface IPerson
    {
        string Fnavn { get; set; }
        string Enavn { get; set; }
    }
}
