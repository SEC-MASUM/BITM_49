using System;

namespace MethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
           int result =  Add(45, 25);
            Console.WriteLine(result);
        }

        static  int Add(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            return sum;
        }
    }
}
