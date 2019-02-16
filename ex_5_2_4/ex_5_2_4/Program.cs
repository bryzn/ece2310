using System;

namespace ex_5_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int mth, day, yr, hr, min, sec;
            Console.WriteLine("This is the implementation of date and time projects\n");
            Console.Write("Insert Month:");
            mth = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInsert Day:");
            day = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInsert Year:");
            yr = Convert.ToInt32(Console.ReadLine());
            Date app_date = new Date(mth, day, yr);
            app_date.display_date();

        }
    }
}
