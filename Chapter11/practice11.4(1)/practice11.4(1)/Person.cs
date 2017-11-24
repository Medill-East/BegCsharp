using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice11._4_1_
{
    public class Person
    {
        private string name;
        private int age;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        //override
        public static bool operator >(Person pe1, Person pe2) => (pe1.age > pe2.age);
        public static bool operator <(Person pe1, Person pe2) => !(pe1.age > pe2.age);
        public static bool operator >=(Person pe1, Person pe2) => (pe1.age >= pe2.age);
        public static bool operator <=(Person pe1, Person pe2) => !(pe1.age >= pe2.age);

        
    }


}
