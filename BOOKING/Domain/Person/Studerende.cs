using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOKING.Domain.Person
{
    class Studerende : IPerson
    {
        public int StudieID { get; }
        public string Fnavn { get; set; }
        public string Enavn { get; set; }
    }
}
