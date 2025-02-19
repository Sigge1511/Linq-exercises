using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v8tis
{
    internal class Student:Person
    {

        public string ClassYear { get; set; }

        public Student(string firstname, string lastname, int age, string classyear)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
            ClassYear = classyear;
        }
    }
}
