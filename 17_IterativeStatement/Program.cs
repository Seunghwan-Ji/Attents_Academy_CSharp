
namespace _17_IterativeStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 반복문
            // for, while, do-while
            // 명령어를 반복실행할 때 사용
            // 반복 횟수를 아는 경우

            // for(초기식; 조건식; 증감식)
            // {
            //      명령어들;
            // }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("i = " + i);
            }

            for (int i = 0, j = 10; i < 10 && j > 0; i += 2, j -= 2)
            {
                Console.WriteLine($"i ={i}, j = {j}");
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine($"i = {i}, j = {j}");
                }
            }
        }
    }
}
