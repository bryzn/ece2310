using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            RightTriangle rt1 = new RightTriangle();
            RightTriangle rt2 = new RightTriangle(6, 8);
            rt1.SideA = 3;
            rt1.SideB = 4;
            Console.Write("Hypotenuse: {0}", rt1.SideA);
            Console.Write("\nPerimeter: {0}", rt1.SideB);
            Console.Write("\nArea: {0}", rt1.Area);


        }
    }
}
