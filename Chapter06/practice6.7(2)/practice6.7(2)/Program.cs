using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace practice6._7_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length != 2)
            {
                WriteLine("Two arguments are required.");
                return;
            }

            string param1 = args[0];
            int param2 = ToInt32(args[1]);
            WriteLine($"String parameter : {param1}");
            WriteLine($"Int parameter : {param2}");
            ReadKey();
        }
    }
}
