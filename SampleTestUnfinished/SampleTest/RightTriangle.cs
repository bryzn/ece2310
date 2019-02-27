using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTest
{
    class RightTriangle
    {private double sideA, sideB, hypotenuse, area, perimeter;
        public double SideA
        {get { return sideA; }
         set{sideA = value;}

        }
        public double SideB
        {   get { return sideB; }
            set { sideB = value; }
        }
        public double Hypotenuse
        {   get { return hypotenuse; }
            set { hypotenuse = value; }
        }
        public double Area
        {   get { return area; }
            set { area = value; }

        }
        public double Perimeter
        {
            get { return perimeter; }
            set { perimeter = value; }

        }
        public RightTriangle()
        {
            SideA = 1;
            SideB = 1;
            calculate();
        }
        public RightTriangle(double sa, double sb)
        {
            SideA = sa;
            SideB = sb;
            calculate();

        }
        private void calculate()
        {
            Hypotenuse = Math.Sqrt(SideA * SideA + SideB*SideB);
            Area = 0.5 * SideA * SideB;
            Perimeter = SideA + SideB + Hypotenuse;
        }
    }
}
