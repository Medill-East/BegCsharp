using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace practice_10._8__4_
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCopyableClass Obj1 = new MyCopyableClass();
            Obj1.ContainedInt = 1;
            MyCopyableClass Obj2 = Obj1.GetCopy();
            Obj1.ContainedInt = 11;
            WriteLine($"Obj1.ContainedInt:{Obj1.ContainedInt}\nObj2.ContainedInt:{Obj2.ContainedInt}");
        }
    }

    class MyCopyableClass
    {
        protected int myInt;
        public int ContainedInt
        {
            get
            {
                return myInt;
            }
            set
            {
                myInt = value;
            }
        }

        public MyCopyableClass GetCopy()
        {
            return (MyCopyableClass)MemberwiseClone();
        }
    }
}
