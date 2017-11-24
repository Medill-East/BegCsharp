using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Convert;
using static System.Console;


namespace practice6._7_5_
{

    class Program
    {
        struct order
            {
                public string itemName;
                public int unitCount;
                public double unitCost;
                public double Sum() => unitCost * unitCount;
                public string info() => "Order Information : " + unitCount.ToString() + " " + itemName + " items at $" + unitCost.ToString() + " each, total cost $" + Sum();
            }
        static void Main(string[] args)
        {
            order order1;
            order1.itemName = "a";
            order1.unitCount = 100;
            order1.unitCost = 200;
            WriteLine( order1.info());
            ReadKey();
        }
    }
}
