using System;
namespace ex8_2_2
{
    public class Equilateral_triangle : Triangle
    {
        public Equilateral_triangle(double s1, double s2, double s3):base(s1, s2, s3)
        {
        }
        public void calculate_area()
        {
            area = (Math.Sqrt(3)/4)*Math.Pow(side1, 2);
        }
        public override string ToString()
        {
            return String.Format("Side 1: {0} Side 2: {1} Side 3: {2} Area: {3}\n", side1, side2, side3, area);
        }
    }
}
