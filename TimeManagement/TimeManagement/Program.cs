using System;

namespace TimeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Time lunchtime = new Time(); //instantiating the new object named lunch time
            lunchtime.set_time(13, 10, 00);
            lunchtime.get_time();
            lunchtime.display_time();
            //creating a new object named lunchtime2
            Time lunchtime2 = lunchtime.get_time();
            lunchtime2.display_time();
            Time dinnertime = new Time(18, 0, 0);
            dinnertime.display_time();
            dinnertime.set_time(25, 60, 60);
            dinnertime.display_time();
            //creating an object with third constructor
            Time newtime = new Time(5);
            newtime.display_time();


        }
    }
}
