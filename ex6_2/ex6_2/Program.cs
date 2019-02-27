using System;

namespace ex6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Date audi_r8Date = new Date(9, 25, 2012);
            Date honda_civicDate = new Date(01, 01, 1999);
            Date toyota_priusDate = new Date(03, 13, 2009);

            Car audi_r8 = new Car(663636, 2019, "Blue", 45000, audi_r8Date);
            Car honda_civic = new Car(566748, 1999, "Green", 20000, honda_civicDate);
            Car toyota_prius = new Car(909878, 2009, "Electric Blue", 17000, toyota_priusDate);

            audi_r8.ToString();
            honda_civic.ToString();
            toyota_prius.ToString();

        }
    }
}
