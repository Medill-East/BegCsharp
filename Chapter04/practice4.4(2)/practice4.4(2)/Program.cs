using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace practice4._4_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            double var1=0;
            double var2=0;
            WriteLine("Please give me a number:");
            var1 = ToDouble(ReadLine());
            WriteLine("Please give me another number:");
            var2 = ToDouble(ReadLine());
            if((var1>10)||(var2>10))
            {
                WriteLine("You've entered a number which is grater than 10 , please regive me these two numbers:");
                WriteLine("Please give me a number:");
                var1 = ToDouble(ReadLine());
                WriteLine("Please give me another number:");
                var2 = ToDouble(ReadLine());
            }
            WriteLine($"You've entered {var1} and {var2}.");
            ReadLine();
        }
    }
}
