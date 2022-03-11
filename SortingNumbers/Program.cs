using System;
using System.Collections.Generic;

namespace SortingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 9, 3, 4, 5, 6, 7, 8, 2, 1};

            Console.WriteLine("До:");

            foreach (int number in numbers)
            {
                Console.Write(number + "|");
            }

            Console.Write("\nПосле:");
            Array.Sort(numbers);
            Console.WriteLine();

            foreach (int number in numbers)
            {
                Console.Write(number + "|");
            }
        }
    }
}