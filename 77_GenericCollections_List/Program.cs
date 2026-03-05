using System;
using System.Collections.Generic;
using System.Linq;

namespace _77_GenericCollections_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            for (int i = 0; i < 10; i++)
            {
                list.Add(3 + i);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"list[{i}] = {list[i]}");
            }

            Console.WriteLine("삭제");
            list.Remove(3);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"list[{i}] = {list[i]}");
            }

            Console.WriteLine();
            list.Remove(10);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"list[{i}] = {list[i]}");
            }

            Console.WriteLine("삽입");
            list.Insert(10, 10);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"list[{i}] = {list[i]}");
            }
        }
    }
}
