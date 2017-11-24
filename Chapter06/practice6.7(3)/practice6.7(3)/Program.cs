using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace practice6._7_3_
{
    class Program
    {
        //√
        /*delegate string ProcessDelegate();

        static void Main(string[] args)
        {
            ProcessDelegate myReadLine = new ProcessDelegate(ReadLine);
            WriteLine("Please enter a string:");
            string userInput = myReadLine();
            WriteLine($"You've input {userInput}");
            ReadKey();
        }*/

        //test
        delegate string ProcessDelegate();
        static string myReadLine() => ReadLine();

        static void Main(string[] args)
        {
            ProcessDelegate process;
            WriteLine("Please enter a string:");
            process = new ProcessDelegate(myReadLine);
            string userInput = process();
            WriteLine($"You've input {userInput}");
            ReadKey();
        }
    }
}
