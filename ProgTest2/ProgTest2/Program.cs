using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTest2
{
    class Program
    {
        //This is example 7.1
        static void Main(string[] args)
        {
            Student.Count = 0;
            Console.WriteLine("Total number of students before instantiation: {0}", Student.Count);
            //static members exist even when no objectj is created for the class
            Student e1 = new Student("Susan", "Baker");
            Student e2 = new Student("Bob", "Blue");
           
            //show that count is 2 after creating two employees
            Console.WriteLine("\nStudents after instantiantion: {0}", Student.Count);
            Console.WriteLine("\nStudent 1: {0} {1} \n Student 2: {0} {1}", e1.FirstName, e1.LastName, e2.FirstName, e2.LastName);
                

        }
    }
}
