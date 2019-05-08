using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19xBedAndBreakfast
{
    class Reservation
    {
        private Guest g;
        private Værelse v;
        private DateTime FromDate;
        private DateTime ToDate;

        public Reservation(Guest g, Værelse v, DateTime fromDate, DateTime toDate)
        {
            this.g = g;
            this.v = v;
            FromDate = fromDate;
            ToDate = toDate;
        }
    }
}
