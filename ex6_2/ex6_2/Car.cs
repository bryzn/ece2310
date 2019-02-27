using System;
namespace ex6_2
{
    public class Car
    {
        public int License { get; private set; }
        public int Year { get; private set; }
        public string Color { get; private set; }
        public double Price { get; private set; }
        public Date Inventory_date { get; private set; }
        public Car(int l, int y, string c, double p, Date i_d)
        {
            License = l;
            Year = y;
            Color = c;
            Price = p;
            Inventory_date = i_d;
        }
        public string toString()
        {
            return string.Format("License: {0}\nYear: {1}\nColor: {2}\nPrice: {3}\nInventory Date: {4}",
                License, Year, Color, Price, Inventory_date);
        }
    }
}
