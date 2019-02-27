using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Date birth = new Date(9, 25, 1995);
            Date register = new Date(8, 10, 2013);
            Student student = new Student("Justin", "Lee", birth, register);
            Console.WriteLine(student);
        }
    }
}
