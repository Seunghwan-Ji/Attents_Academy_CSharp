namespace _05_BitOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 비트 연산자
            // 비트 And (&)
            // 비트 Or (|)
            // 비트 Not (~)
            // Xor(배타적 Or) (^)
            // << 왼쪽 Shift
            // >> 오른쪽 Shift

            int a = 2; // 00000010
            int b = 3; // 00000011
            int c = 0; // 00000000

            // 비트 And
            c = a & b;
            //     a: 00000010
            //     b: 00000011
            // a & b: 00000010
            Console.WriteLine("c = {0}", Convert.ToString(c, 2));

            // 비트 Or
            c = a | b;
            //     a: 00000010
            //     b: 00000011
            // a | b: 00000011
            Console.WriteLine("c = {0}", Convert.ToString(c, 2));

            // 비트 Not
            c = ~a;
            //     a: 00000010
            //    ~a: 11111101
            Console.WriteLine("c = {0}", Convert.ToString(c, 2));

            c = a ^ b;
            // Xor, exclusive or
            //     a: 00000010
            //     b: 00000011
            // a ^ b: 00000001
            Console.WriteLine("c = {0}", Convert.ToString(c, 2));
        }
    }
}
