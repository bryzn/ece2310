using System;

namespace ex5_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            BMI Eric = new BMI();
            Eric.set_values(150, 72);
            Eric.print();
            BMI Alice = new BMI(120, 60);
            Alice.print();
            Console.WriteLine(Math.Exp(1.0));

       

        }
    }
}
