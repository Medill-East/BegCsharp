using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace practice5._4_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Please enter a string:");
            string myString = ReadLine();
            myString = myString.Replace("no", "yes");
            WriteLine($"Replaced \"no\" with \"yes\" : {myString}");
        }
    }
}
