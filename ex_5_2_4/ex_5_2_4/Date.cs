using System;
namespace ex_5_2_4
{
    public class Date
    {
        int month;
        int day;
        int year;
        private Func<string> readLine;

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

        public Date(Func<string> readLine)
        {
            this.readLine = readLine;
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
