using System.Collections.Generic;

namespace _78_GenericCollections_Stack_01
{
    public static class StackExtenstion
    {
        // 확장 메소드
        public static bool IsIn(this Stack<string> myStack, string name)
        {
            foreach (var str in myStack)
            {
                if (str == name)
                {
                    return true;
                }
            }

            return false;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("Start");

            for (int i = 0; i < 10; i++)
            {
                stack.Push($"Data {i}");
            }

            if (stack.IsIn("Data 3"))
            {
                Console.WriteLine("Data 3가 문자열이 스택에 저장되어있습니다.");
            }

            if (stack.IsIn("Monster"))
            {
                Console.WriteLine("Monster가 문자열이 스택에 저장되어있습니다.");
            }
            else
            {
                Console.WriteLine("Monster가 문자열이 스택에 없습니다..");
            }


            Console.WriteLine();
            Console.WriteLine($"peek {stack.Peek()}");
            Console.WriteLine();


            foreach (var data in stack)
            {
                Console.WriteLine(data);
            }

            Console.WriteLine();


            while (stack.Count > 0)
            {
                Console.WriteLine($"{stack.Pop()}");
            }


            foreach (var data in stack)
            {
                Console.WriteLine(data);
            }

            Console.WriteLine();


        }
    }
}
