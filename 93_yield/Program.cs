using System;
using System.Collections.Generic;

namespace _93_yield
{
    class Program
    {
        static IEnumerator<int> GetNumber()
        {
            yield return 1;

            yield return 2;

            yield return 3;

            yield return 4;
        }

        static void Func()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"i = {i}");
            }
        }

        static IEnumerator<int> yieldFunc()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"i = {i}");
                yield return i;
            }
        }

        static void Main(string[] args)
        {
            /*
            var num = GetNumber();
            num.MoveNext();
            Console.WriteLine(num.Current);
            num.MoveNext();
            Console.WriteLine(num.Current);
            num.MoveNext();
            Console.WriteLine(num.Current);
            num.MoveNext();
            Console.WriteLine(num.Current);
            */

            Func(); // 메소드의 명령어가 다 처리되고 호출했던 곳으로 리턴

            var func = yieldFunc();

            func.MoveNext();
            Console.WriteLine($"func i = {func.Current}");

            Console.WriteLine("yahoo");

            func.MoveNext();
            Console.WriteLine($"func i = {func.Current}");

            Console.WriteLine("yahoo");

            func.MoveNext();
            Console.WriteLine($"func i = {func.Current}");

            Console.WriteLine("yahoo");

            func.MoveNext();
            Console.WriteLine($"func i = {func.Current}");

            Console.WriteLine("yahoo");

            func.MoveNext();
            Console.WriteLine($"func i = {func.Current}");

            Console.WriteLine("yahoo");
        }
    }
}
