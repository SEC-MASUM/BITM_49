using System;
using System.Linq;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            //numbers[0] = 20;
            //numbers[1] = 40;
            //numbers[2] = 60;

            for (int i = 0; i < numbers.Count(); i++)
            {
                numbers[i]  = Convert.ToInt32(Console.ReadLine());
            }

            int sum = numbers.Sum();
            Console.WriteLine(sum);

            //for (int i = 0; i < numbers.Count(); i++)
            //{
            //    Console.WriteLine("Output:" + numbers[i]);
            //}

            foreach (var item in numbers)
            {
                Console.WriteLine("Output: " + item);
            }
        }
    }
}
