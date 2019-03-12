using System;
namespace ex8_2_2
{
    public class Triangle : Shape
    {
        public double side1, side2, side3;
        public double area;
        public Triangle(String c, double s1, double s2, double s3): base(c)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
        }
        public Triangle(double s1, double s2, double s3)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
        }
        public Triangle(double s1, double s2)
        {
            side1 = s1;
            side2 = s2;
        }
        public void calculate_area()
        {
            area = 1;
        }
        public override string ToString()
        {
            return String.Format("Color: {4} Side 1: {0} Side 2: {1} Side 3: {2} Area: {3}\n", side1, side2, side3, area, color);
        }
    }
}
