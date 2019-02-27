using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_1
{
    public class Date
    {
        private int month, day, year;
        public Date(int theMonth, int theDay, int theYear)
        {
            Month = theMonth;
            Year = theYear;
            Day = theDay;
            Console.WriteLine("Date object constructor for date {0}", this);
        }
        public int Year
        { get { return year; }
            private set // makes writing inaccesible outside the class
            { if (value > 1900 && value <= 2013)
                    year = value;
                else
                    throw new ArgumentOutOfRangeException("Year", value, "must be between 1900 and 2013");
            }
        }
        public int Month
        {
            get { return month; }
            private set
            {
                if (value > 0 && value <= 12)
                    month = value;
                else
                    throw new ArgumentOutOfRangeException("Month", value, "must be between 1 and 12");
            }
        }
        public int Day
        { get { return day; }
            private set
            { int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 31, 30, 31, 30, 31 };
                if (value > 0 && value <= daysPerMonth[Month])
                    day = value;
                // check for leap year
                else if (Month == 2 && value == 29 && (Year % 400 == 0 || (Year % 4 == 0 && Year % 100 != 0)))
                    //day is not valid for that month
                    throw new ArgumentOutOfRangeException("Day", value, "Day out of range for current month and year");
                }
        }
        public override string ToString()
        {
            return string.Format("{0}/{1}/{2}", Month, Day, Year);
        }
    }
}
