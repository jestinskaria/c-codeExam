using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    class Luggage:Train
    {
        Train trainLuggObj = new Train();

        public double TotalLuggageFare(double totalLug)
        {
            double totalluggageFareOnly = totalLug * trainLuggObj.farePerKg;
            return totalluggageFareOnly;
        }
    }
}
