using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practice_9._9__4_;
using static System.Console;

namespace practice_9._9__5_
{
    class Program
    {
        static void AddPassenger(IPassengerCarrier Vehicle)
        {
            WriteLine(Vehicle.ToString());
        }


        static void Main(string[] args)
        {
            AddPassenger(new Compact());
            AddPassenger(new SUV());
            AddPassenger(new Pickup());
            AddPassenger(new PassengerTrain());
            ReadKey();
        }
    }
}
