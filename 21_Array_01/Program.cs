
namespace _21_Array_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array2 = new int[10, 10];

            // GetLength(0) : 행의 길이 반환
            // GetLength(1) : 열의 길이 반환

            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    array2[i, j] = i * 10 + j;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine($"array2[{i}, {j}] = {array2[i, j]}");
                }
            }

            int[,] array4 = new int[10, 5];

            for (int i = 0; i < array4.GetLength(0); i++)
            {
                for (int j = 0; j < array4.GetLength(1); j++)
                {
                    array4[i, j] = i * array4.GetLength(1) + j;
                }
            }

            Console.WriteLine($"행의 갯수: {array4.GetLength(0)}");
            Console.WriteLine($"열의 갯수: {array4.GetLength(1)}");
            Console.WriteLine($"전체요소의 갯수: {array4.Length}");
            Console.WriteLine($"차원수: {array4.Rank}");


            Console.WriteLine();
            int[,,] array5 = new int[10, 5, 4];

            Console.WriteLine($"행의 갯수: {array5.GetLength(0)}");
            Console.WriteLine($"열의 갯수: {array5.GetLength(1)}");
            Console.WriteLine($"z의 갯수: {array5.GetLength(2)}");
            Console.WriteLine($"전체요소의 갯수: {array5.Length}");
            Console.WriteLine($"차원수: {array5.Rank}");

            // 배열 복사
            int[,] array4_copy = (int[,])array4.Clone();

            for (int i = 0; i < array4_copy.GetLength(0); i++)
            {
                for (int j = 0; j < array4_copy.GetLength(1); j++)
                {
                    Console.WriteLine($"array4_copy[{i}, {j}] = {array4_copy[i, j]}");
                }
            }
        }
    }
}
