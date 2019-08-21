using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a list of numbers...");
            var input = Console.ReadLine();

            var inputString = input.Split(",");

            Console.WriteLine(inputString[0]);

            Console.WriteLine(input);

            Console.ReadLine();
        }
    }
}
