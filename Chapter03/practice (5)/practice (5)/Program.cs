using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Convert;
using static System.Console;

namespace practice__5_
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, thirdNumber, forthNumber;
            Console.WriteLine("Please give me a number:");
            firstNumber = ToInt32(ReadLine());
            WriteLine("Please give me another number:");
            secondNumber = ToInt32(ReadLine());
            WriteLine("Please give me another number:");
            thirdNumber = ToInt32(ReadLine());
            WriteLine("Please give me another number:");
            forthNumber = ToInt32(ReadLine());
            WriteLine($"The product of {firstNumber} and {secondNumber} and {thirdNumber} and {forthNumber} is {firstNumber * secondNumber * thirdNumber * forthNumber}.");
            ReadKey();
        }
    }
}
