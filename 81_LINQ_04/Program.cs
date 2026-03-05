using System;
using System.Linq;

namespace _81_LINQ_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var reversedIDigits =
                (from digit in digits
                 where digit[1] == 'i' || digit[1] == 'n'
                 select digit)
                 .Reverse();

            foreach (var data in reversedIDigits)
            {
                Console.WriteLine($"{data} ");
            }
        }
    }
}
