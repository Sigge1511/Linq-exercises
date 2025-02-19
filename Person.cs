using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v8tis
{
    internal class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        public Person()
        {
            
        }
        public Person(string firstname, string lastname, int age)
        {
            Firstname=firstname; 
            Lastname=lastname; 
            Age=age;
        }
    }
}
