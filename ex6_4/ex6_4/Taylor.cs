using System;
namespace ex6_4
{
    public class Taylor
    {
        private int t; //total number of terms
        private int x; // total number of terms
        private double approximated;
        private NExp actual;
        private int T
        {
            get { return t; }
            set { t = value; }
        }
        private int X
        {
            get { return x; }
            set { x = value; }
        }
        private double Approximated
        {
            get { return approximated; }
            set { approximated = value; }
        }
        private NExp Actual
        {
            get { return actual; }
            set { actual = value; }
        }
        public Taylor(int n , int x)
        {

        }
        public void display()
        {
            Console.WriteLine("\nt: {0} x: {1} actual: {2", T, X, actual);
        }
        private double calculate()
        {
            return 4.5;
        }
    }
}
