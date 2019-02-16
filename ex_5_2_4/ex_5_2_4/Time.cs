using System;
namespace ex_5_2_4
{
    public class Time
    {
        int hour;
        int minute;
        int second;
        public Time()
        {
            hour = 0;
            minute = 0;
            second = 0;
        }
        public Time(int h, int m, int s)
        {
            set_time(h, m, s);
        }
        public Time(int h)
        {
            set_time(h, 5, 5);
        }
        public void set_time(int h, int m, int s)
        {
            if (h < 0 || h > 23) { h = 0; }
            if (m < 0 || m > 59) { m = 0; }
            if (s < 0 || s > 59) { s = 0; }
            hour = h;
            minute = m;
            second = s;
        }
        public Time get_time()
        {
            return this;
        }

        internal Time set_time()
        {
            throw new NotImplementedException();
        }

        public void display_time()
        {
            Console.WriteLine("\n{0}:{1}:{2} \n", hour, minute, second);
        }
    }
}
