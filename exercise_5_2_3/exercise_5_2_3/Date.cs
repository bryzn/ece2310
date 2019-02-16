using System;
namespace exercise_5_2_3
{
    public class Date
    {
        int month;
        int day;
        int year;
        public Date() //constructor and setting the variables to 0
        {
            month = 0;
            day = 0;
            year = 0;
        }
        public Date(int m, int d, int y)
        {
            set_date(m, d, y);
        }
        public void set_date(int m, int d, int y)
        {
            month = m;
            day = d;
            year = y;
        }
        public Date get_date()
        { return this; }
        public void display_date()
        {
            Console.WriteLine("\n{0}-{1}-{2}\n", month, day, year);
        }
    }
}
