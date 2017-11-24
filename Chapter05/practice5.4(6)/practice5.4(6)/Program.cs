using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace practice5._4_6_
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Please enter a string:");
            string myString = ReadLine();
            string[] myWords = myString.Split(' ');
            WriteLine("Adding double quotes around words:");
            foreach(string myWord in myWords)
            {
                Write($"\"{myWord}\"");
            }
        }
    }
}
