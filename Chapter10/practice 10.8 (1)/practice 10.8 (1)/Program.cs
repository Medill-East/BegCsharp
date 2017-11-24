using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_10._8__1_
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class MyClass
    {
        protected string myString;

        public string ContainedString
        {
            set
            {
                myString = value;
            }
        }

        public virtual string GetString()
        {
            return myString;
        }
    }

}
