using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTest2
{
    public class Student
    {
        public static int Count
        {get; set;}
        public string FirstName { get; set; }
        public string LastName { get; private set; }
        public Student(string f, string l)
        {
            FirstName = f;
            LastName = l;
            ++Count; //maintain the public class member count
            Console.WriteLine("Student Constructor: {0} {1}; Count = {2}", FirstName, LastName, Count);
        }


    }
}
