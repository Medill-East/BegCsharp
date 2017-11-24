using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_9._9__4_
{

    public class Vehicle
    {

    }

    public class Car:Vehicle
    {

    }

    public class Train:Vehicle
    {

    }

    public class Compact:Car,IPassengerCarrier
    {

    }

    public class SUV: Car,IPassengerCarrier
    {

    }

    public class Pickup:Car, IPassengerCarrier, IHeavyLoadCarrier
    {

    }

    public class PassengerTrain:Train,IHeavyLoadCarrier, IPassengerCarrier
    {

    }

    public class FreightTrain : Train, IHeavyLoadCarrier
    {

    }

    public class T424DoubleBogey : Train,IHeavyLoadCarrier
    {

    }

    public interface IPassengerCarrier
    {

    }

    public interface IHeavyLoadCarrier
    {

    }
}
