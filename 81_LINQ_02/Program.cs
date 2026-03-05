using System;
using System.Linq;

namespace _81_LINQ_02
{
    // Where 절
    // 
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "strawberry", "mango", "banana", "apple", "blueberry", "melon", "sinamon", "si" };

            var linqList = from fruit in fruits
                           where fruit.StartsWith("s") && fruit.Length > 3
                           select fruit;

            foreach (var str in linqList)
            {
                Console.WriteLine(str + " ");
            }
        }
    }
}
