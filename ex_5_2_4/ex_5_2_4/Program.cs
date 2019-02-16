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
            Console.Write("Insert Day:");
            day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert Year:");
            yr = Convert.ToInt32(Console.ReadLine());
            Date app_date = new Date(3,15,1998); //instantiating the object
            app_date.set_date(mth, day, yr); //setting the date of appointment
            Console.Write("Your appointment is on: ");
            Date app_date1 = app_date.get_date(); 
            app_date1.display_date(); //displaying date


            Console.Write("Enter Hour:");
            hr = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Minute");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second:");
            sec = Convert.ToInt32(Console.ReadLine());
            Time app_time = new Time(hr, min, sec);
            Time app_time1 = app_time.get_time();
            Console.Write("Your appointment is at: ");
            app_time1.display_time();
        }
    }
}
