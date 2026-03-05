namespace _05_BitOperator_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 컴퓨터에서 음의 정수
            // 컴퓨터는 뺄셈을 할 줄 모름.

            int a;

            a = 2 - 2;
            a = 2 + (-2);

            // 2의 보수 연산
            // 00000010 (2)
            // 11111101 (1의 보수)
            // 11111110 (2의 보수) (-2)

            //           00000010 (2)
            //           11111110 (-2)
            // 2 + (-2): 00000000

            a = -2;
            Console.WriteLine("a = {0}", Convert.ToString(a, 2));
        }
    }
}
