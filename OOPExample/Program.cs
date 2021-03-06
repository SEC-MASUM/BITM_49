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
            person1 = new Person();

            person1.firstName = "Md.";
            person1.middleName = "Masum";
            person1.lastName = "Billah";

            string fullname = person1.GetFullName();
            Console.WriteLine(fullname);
        }
    }
}
