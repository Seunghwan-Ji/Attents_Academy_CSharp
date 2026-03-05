namespace Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 수식연산자
            // +, -, *, /, %
            int a = 1;
            int b = 2;
            int ret = 0;

            ret = a + b;    // 정수 + 정수 = 정수
            Console.WriteLine($"{a} + {b} = {ret}");

            ret = a - b;    // 정수 - 정수 = 정수
            Console.WriteLine($"{a} - {b} = {ret}");

            ret = a * b;    // 정수 x 정수 = 정수
            Console.WriteLine($"{a} x {b} = {ret}");

            ret = a / b;    // 정수 / 정수 = 정수
            Console.WriteLine($"{a} / {b} = {ret}");

            float fret = 0.0f;

            fret = a / b;
            Console.WriteLine($"{a} / {b} = {fret}");

            fret = a / (float)b;    // (float) 형변환 연산자
            Console.WriteLine($"{a} / {b} = {fret}");

            // Cpu에는 정수, 정수 연산자와 실수 실수 연산자만 있습니다.
            // 정수 / 정수를 하면 무조건 정수가 나옵니다.
            // 정수 / 정수의 결과값을 실수로 받으려면 
            // 한쪽의 값을 실수로 변환해야 합니다.
        }
    }
}