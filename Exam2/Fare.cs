using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    class Fare:Train
    {
        Train trainFareObj = new Train();

        public double TotalSeatFare(double seatNos)
        {
            double totalSeatFareOnly = seatNos * trainFareObj.seatFare;
            return totalSeatFareOnly;
        }
    }
}
