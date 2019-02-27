using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2310Midterm
{
    class Component
    {
        private String name;
        private int mttf;
        public String Name
        {
            get { return name; }
            set { name = value; }
            }
        public int MTTF
        {
            get { return mttf; }
            set { mttf = value; }
        }
        public Component()
        {
        }
        public Component(String n, int m)
        {
            Name = n;
            MTTF = m;
        }
        public void Display()
        {
            Console.WriteLine("\nName: {0}", Name);
            Console.WriteLine("\nMTTF: {0}", MTTF);

        }
        public void Modify_mttf(int m)
        {
            MTTF = m;
        }
       
    }
}
