using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    class Train
    {
        public double reservationId;
        public string customerName;
        public string contactNo;
        public double noOfSeats;
        public double totalWeight;
        public double seatFare = 50;
        public double farePerKg = 30;

        public Train()
        {

        }
        public void SetCustomerDetails(double resId,string custName, string contNo, double seatNos, double weightTotal)
        {
            reservationId = resId;
            customerName = custName;
            contactNo = contNo;
            noOfSeats = seatNos;
            totalWeight = weightTotal;
        }
       
       
    }
}
