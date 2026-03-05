using System;
using System.Linq;

namespace _81_LINQ_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "strawberry", "mango", "banana", "apple", "blueberry", "melon" };

            // fruit 범위 변수 (Range Variable)는
            // LINQ 쿼리에서 Data Source 의 각 요소를 나타내는 임시 변수
            var sortedfruits = from fruit in fruits
                               orderby fruit descending
                               select fruit;

            foreach (var str in sortedfruits)
            {
                Console.WriteLine($"{str}, ");
            }
        }
    }
}
