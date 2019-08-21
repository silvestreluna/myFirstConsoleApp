using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool myBool = true;
            int myIntValue;
            myIntValue = 1234;


            if (myBool)
            {
                Console.WriteLine("We'll never hit this code.");
            }

            switch (myIntValue)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                default:
                    Console.WriteLine("something");
                    break;
            }

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine($"number is {i}");
            }

            List<string> myString = new List<string>();
            myString.Add("heelo");
            myString.Add("hello2");
            myString.Insert(1,"hellinsert");

            foreach (var myStrings in myString)
            {
                Console.WriteLine(myStrings);
            }



            Console.WriteLine("Hello World!");
        }
    }
}
