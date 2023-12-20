using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.TravelingStrategies
{
    public class Car : TravelStrategy
    {
         public Car() 
        {
            KilometerCost = 25;
        }

        public override decimal Drive(int kilometers)
        {
            return kilometers * KilometerCost;
        }
    }
}
