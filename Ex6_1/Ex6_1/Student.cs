using System;
namespace Ex6_1
{
    public class Student
    {
        public string FirstName { get; private set; } //auto implemented property
        public string LastName { get; private set; }
        public Date BirthDate { get; private set; }
        public Date RegisterDate { get; private set; }
        public Student(string first, string last, Date dateOfBirth, Date dateOfRegister)
        {
            FirstName = first;
            LastName = last;
            BirthDate = dateOfBirth;
            RegisterDate = dateOfRegister;
        }
        //convert employee to string format
        public override string ToString()
        {
            return string.Format("{0}, {1} Registered: {2} Birthday: {3}", LastName,
                FirstName, RegisterDate, BirthDate);
        }
    }
}
