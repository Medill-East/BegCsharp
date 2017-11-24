using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch06Ex02
{
    class Program
    {
        static int MaxValue(int[] intArray)
        {
            int maxVal = intArray[0];
            for(int i=1;i<intArray.Length;++i)
            {
                if(intArray[i]>maxVal)
                {
                    maxVal = intArray[i];
                }
            }
            return maxVal;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 8, 9, 6, 5, 2, 4, 5, 3, 4, 1, 2, 6 };
            int maxVal = MaxValue(myArray);
            WriteLine($"The maxium value in myArray is {maxVal}.");
            ReadKey();
        }
    }
}
