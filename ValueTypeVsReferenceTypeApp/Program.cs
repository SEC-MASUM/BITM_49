using System;

namespace ValueTypeVsReferenceTypeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person aPerson = new Person();
            aPerson.firstName = "Md";
            aPerson.middleName = "Abid";
            aPerson.lastName = "Hasan";
            Change(aPerson);
            Console.WriteLine(aPerson.lastName);

        }

        public static void Change(Person person)
        {
            person.firstName = "Suad";
            person.lastName = "Jim";
        }
    }
}
