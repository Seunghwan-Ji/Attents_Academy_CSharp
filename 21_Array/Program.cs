namespace _21_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 0 ~ 100까지 저장하세요.
            int a0 = 0;
            int a1 = 1;
            int a2 = 2;
            // ...

            int a99 = 99;
            int a100 = 100;

            // 짝수만 출력하세요.
            if (a0 % 2 == 0)
            {
                Console.WriteLine($"a0 = {a0}");
            }

            if (a1 % 2 == 0)
            {
                Console.WriteLine($"a1 = {a1}");
            }

            // 동일한 데이터 타입의 공간이 여러개 필요할 때 편리하게 사용할 수 있는 기능이 있음.
            // 배열
            // C# 배열 클래스

            int[] array = new int[100]; // 1차원 배열.

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}] = {array[i]}");
            }

            int[] array01 = new int[] { 0, 1, 2, 3, 4 };

            // 2차원 배열
            int[,] array2 = new int[10, 10]; // 2차원 배열

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
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
        }
    }
}
