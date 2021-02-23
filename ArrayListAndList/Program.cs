using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayListAndList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();

            array.Add(15);
            array.Add("Md Masum");
            array.Add(3.316);
            array.Add("J");
            array.Add(47);

            foreach (var data in array)
            {
                Console.WriteLine("Output : " + data);
            }

            array.Remove(47);
            array.RemoveAt(2);
            array.Reverse();
            foreach (var item in array)
            {
                Console.WriteLine("Reverse Output: " + item);
            }

            List<string> names = new List<string>();
            names.Add("Mx. X");
            names.Add("Mx. Y");
            names.Add("Mx. Z");
            names.Add("Mx. A");

            names.Reverse();
            foreach (var data in names)
            {
                if(data == "Mx. Z")
                Console.WriteLine("Output Name: Found");
            }

        }
    }
}
