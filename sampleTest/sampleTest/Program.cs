using System;

namespace sampleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            RightTriangle rt1 = new RightTriangle();
            RightTriangle rt2 = new RightTriangle(3, 4);
            rt2.toString();
            rt1.set_values(6, 8);
            rt1.toString();
        }
    }
}
