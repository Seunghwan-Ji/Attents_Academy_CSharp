namespace Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 변수
            // DataType 변수명; (;(세미콜론은 명령이 끝났다는 표시입니다.))
            // 변수명은 영대소문자, _, 숫자(숫자 첫글자로 사용안됨)
            // 변수명을 명명할때는 변수에 저장되어지는 값을 의미하는 
            // 단어나 문장을 사용하는 것이 좋습니다.
            int score;

            byte a = 255;
            sbyte b = -127;

            Console.WriteLine($"a = {a}, b = {b}");

            short c = -32768;
            ushort d = 65535;
            Console.WriteLine($"c = {c}, d = {d}");

            int e = -2147483648;
            uint f = 4294967295;
            Console.WriteLine($"e = {e}, f = {f}");

            long g = -922_337_203_685_477_508;
            ulong h = 18_446_744_073_709_551_615;
            Console.WriteLine($"g = {g}, h = {h}");

            char i = '코';
            Console.WriteLine($"i = {i}끼리");

            float j = -3.4e38f;
            double k = -1.79e308;
            decimal l = 1.0e+28m;
            Console.WriteLine($"j = {j}, k = {k}, l = {l}");
            Console.WriteLine("j = {0:F38}, k = {1:F38}", j, k);

            string str = "monster";
            Console.WriteLine($"str = {str}");

            bool logicValue = true;

            Console.WriteLine($"logicValue = {logicValue}");

            logicValue = false;
            Console.WriteLine($"logoValue = {logicValue}");
        }
    }
}