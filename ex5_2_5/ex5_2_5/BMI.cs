using System;
namespace ex5_2_5
{
    public class BMI
    {
        double weight;
        double height;
        public double BMImeasure;
        public BMI()
        {
            weight = 1;
            height = 1;
            calculateBMI();
        }
        public BMI(double inweight, double inheight)
        {
            set_values(inweight, inheight);
            calculateBMI();
        }
        private void calculateBMI()
        {
            BMImeasure = 703 * (weight / (height *height));
        }
        public void set_values(double inweight, double inheight)
        {
            weight = inweight;
            height = inheight;
            calculateBMI();

        }
        public void print()
        {
            Console.Write("\nThe BMI is: {0}\n", BMImeasure);
        }

    }
}
