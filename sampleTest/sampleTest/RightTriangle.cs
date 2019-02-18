using System;
namespace sampleTest
{
    public class RightTriangle
    {
        double sideA, sideB, hypotenuse, area, perimeter;
        public RightTriangle()
        {
            sideA = 1;
            sideB = 1;
            calculate();
        }
        public RightTriangle(double insideA, double insideB)
        {
            set_values(insideA, insideB);
            calculate();
        }
        private void calculate()
        {
            area = sideA * sideB;
            perimeter = (sideA * sideA) + (sideB * sideB);
            hypotenuse = Math.Sqrt(perimeter);
        }
        public void set_values(double insideA, double insideB)
        {
            sideA = insideA;
            sideB = insideB;
        }
        public void toString()
        {
            Console.WriteLine("SideA: " + sideA + "\nSideB: " + sideB +
            "\nHypotenuse: " + hypotenuse + "\nArea: " + area + "\nPerimeter: " + perimeter);
        }
    }
}
