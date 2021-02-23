using System;
using System.Collections;
using System.Collections.Generic;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack aStack = new Stack();
            //aStack.Push("Name");
            //aStack.Push(63);
            //aStack.Push("Address Line");

            //foreach (var data in aStack)
            //{
            //    Console.WriteLine(data);
            //}
            //aStack.Pop();

            //foreach (var data in aStack)
            //{
            //    Console.WriteLine(data);
            //}

            Stack<char> bStack = new Stack<char>();
            string word = "MUMMOM";
            foreach (var c in word)
            {
                bStack.Push(c);
            }

            bool isPalindrom = true;

            foreach (var letter in word)
            {
                if(letter != bStack.Pop())
                {
                    isPalindrom = false;
                    break;
                }
            }

            Console.WriteLine(isPalindrom);
            
        }
    }
}
