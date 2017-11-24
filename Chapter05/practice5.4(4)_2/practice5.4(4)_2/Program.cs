using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace practice5._4_4__2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Please enter a string:");
            string myString = ReadLine();
            string reversedString = "";
            for(int index = myString.Length -1;index >=0; --index)
            {
                reversedString += myString[index];
            }
            WriteLine($"Reversed:{reversedString}");
            ReadKey();
        }
    }
}
