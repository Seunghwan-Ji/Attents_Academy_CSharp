using System;
using System.Linq;

namespace _81_LINQ_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var sortedWords = words
               .OrderBy(a => a.Length)
               .ThenBy(a => a);


            foreach (var data in sortedWords)
            {
                Console.WriteLine($"{data}, ");
            }
        }
    }
}
