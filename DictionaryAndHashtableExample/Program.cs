using System;
using System.Collections;
using System.Collections.Generic;

namespace DictionaryAndHashtableExample
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Dictionary
            Dictionary<int, string> aDictionary = new Dictionary<int, string>();

            aDictionary.Add(101, "Md. Masum");
            aDictionary.Add(102, "Md. Hasan");
            aDictionary.Add(103, "Md. Hamidur");
            aDictionary.Add(104, "Mrs. Masta");
            string outputValue;
            if(aDictionary.TryGetValue(102, out outputValue))
            {
                Console.WriteLine("Found: " + outputValue);
            }
            else
            {
                Console.WriteLine("Not Found");
            }

            //foreach (var data in aDictionary)
            //{
            //   // Console.WriteLine("Key: "+ data.Key +" Value: "+data.Value);
            //    if(data.Key == 102)
            //    {
            //        Console.WriteLine("Found: " + data.Value);
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not Found");
            //        break;
            //    }
            //}
            #endregion

            #region Hashtable
            Hashtable aHashtable = new Hashtable();
            aHashtable.Add(1, "One");
            aHashtable.Add(2, "Two");
            aHashtable.Add(3.5, 45.54);
            aHashtable.Add("Four", 4.120f);
            Console.WriteLine(aHashtable["Four"]);
            Console.WriteLine(aDictionary[101]);

            //foreach (var data in aHashtable.Keys)
            //{
            //    Console.WriteLine(data);
            //}
            #endregion




        }
    }
}
