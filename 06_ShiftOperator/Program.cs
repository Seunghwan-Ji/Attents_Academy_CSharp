namespace _06_ShiftOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Shift 연산자
            // << 왼쪽 shift
            // >> 오른쪽 shift

            int a = 1; // 00000001

            // 왼쪽 shift
            // 비트 값을 왼쪽으로 이동시킬 때
            // 비트 값을 왼쪽으로 1비트 민다는 것은 곱하기 2를 하는 것과 같음.
            a = a << 1;
            //      a:   00000001
            // a << 1:   00000010
            Console.WriteLine($"a = {Convert.ToString(a, 2)}");

            a = a << 2;
            //       a:    00000010
            //  a << 2:    00001000
            Console.WriteLine($"a = {Convert.ToString(a, 2)}");

            // 오른쪽 shift
            a = a >> 1;
            //       a:    00001000
            //  a >> 1:    00000100
            Console.WriteLine($"a = {Convert.ToString(a, 2)}");

            a = a >> 2;
            //       a:    00001000
            //  a >> 2:    00000100
            Console.WriteLine($"a = {Convert.ToString(a, 2)}");
        }
    }
}
