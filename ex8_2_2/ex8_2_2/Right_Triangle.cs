using System;
namespace ex8_2_2
{
    public class Right_Triangle : Triangle
    {
        public Right_Triangle(double s1, double s2):base(s1, s2)
        {
            side3 = Math.Sqrt(s1 * s1 + s2 * s2);
        }
        public void calculate_area()
        {
            area = (side1 * side2) / 2;
        }
        public override string ToString()
        {
            return String.Format("Side 1: {0} Side 2: {1} Side 3: {2} Area: {3}\n", side1, side2, side3, area);
        }
    }
}
