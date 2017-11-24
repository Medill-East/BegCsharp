using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace practice_10._8__1__again
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

    class MyDerivedClass:MyClass
    {
        public override string GetString()
        {
            return base.GetString() + "(output from derived class)";
        }
    }
}
