using System;

namespace ex8_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Right_Triangle triangle1 = new Right_Triangle(6, 8);
            Console.WriteLine(triangle1.side3);
            triangle1.calculate_area();
            Console.WriteLine(triangle1);

            Equilateral_triangle triangle2 = new Equilateral_triangle(4, 4, 4);
            triangle2.calculate_area();
            Console.WriteLine(triangle2);
        }
    }
}
