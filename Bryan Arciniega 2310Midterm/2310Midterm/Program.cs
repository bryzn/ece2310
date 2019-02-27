using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2310Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating all objects #6
            Component c1 = new Component("Receiving Antenna", 100000);
            Component c2 = new Component("Low Noise Amplifier", 150000);
            Component c3 = new Component("Down Converter", 75000);
            Component c4 = new Component("IF Amplifier", 110000);
            Component c5 = new Component("ADC", 130000);
            Component c6 = new Component("DSP", 125000);
            Component c7 = new Component("Microprocessor", 100000);
            Component c8 = new Component("Display", 500000);
            //#7
            c1.Display();
            c2.Display();
            c3.Display();
            c4.Display();
            c5.Display();
            c6.Display();
            c7.Display();
            c8.Display();
            //#8
            c3.Modify_mttf(80000);
            //#9
            c1.Display();
            c2.Display();
            c3.Display();
            c4.Display();
            c5.Display();
            c6.Display();
            c7.Display();
            c8.Display();
            int avgMTTF = (c1.MTTF + c2.MTTF + c3.MTTF + c4.MTTF + c5.MTTF + c6.MTTF + c7.MTTF + c7.MTTF) / 8;
            Console.WriteLine("\nThe average value of all components' mttfs (in hours): {0}", avgMTTF);
            
        }
    }
}
