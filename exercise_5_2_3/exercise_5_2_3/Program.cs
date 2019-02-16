using System;

namespace exercise_5_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the date project\n");
            Date birthdate = new Date(3, 14, 1998);
            birthdate.set_date(3, 15, 1998);
            birthdate.display_date();
            //this will be my anniversary date
            Date anniversaryDate = new Date(01, 19, 2016);
            anniversaryDate.display_date();
            Date newAnniversaryDate = anniversaryDate.get_date();
            anniversaryDate.set_date(0, 0, 000);
            Console.Write("Unfortunately I do not have an anniversary date anymore :(\n");
            newAnniversaryDate.display_date();
        }
    }
}
