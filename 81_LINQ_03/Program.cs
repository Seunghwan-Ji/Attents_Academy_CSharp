using System;
using System.Linq;

namespace _81_LINQ_03
{
    // orderby
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "a", "z" };
             var sortedDigits = from digit in digits
                                orderby digit.Length descending
                                select digit;

            foreach (var data in sortedDigits)
            {
                Console.WriteLine($"[{data}]");
            }
        }
    }
}
