using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1;
            person1 = new Person("MD.","Masum","Vai");

            person1.FirstName = "Md.";
            person1.MiddleName = "Masum";
            person1.LastName = "Billah";

            string fullname = person1.GetFullName();
            Console.WriteLine(fullname);
            Console.ReadLine();
        }
    }
}
