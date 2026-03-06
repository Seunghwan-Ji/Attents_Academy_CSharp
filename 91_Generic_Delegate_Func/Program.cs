namespace _91_Generic_Delegate_Func
{
    delegate float FFunc(float a, float b);

    class Program
    {
        static float add(float a, float b)
        {
            return a + b;
        }

        static float sub(float a, float b)
        {
            return a - b;
        }

        static float mul(float a, float b)
        {
            return a * b;
        }

        static float div(float a, float b)
        {
            return a / b;
        }

        static float calculator(Func<float, float, float> func, float a, float b)
        {
            return func(a, b);
        }

        static int add(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            // Func: generic delegate 는 리턴 타입이 있는 경우에 사용합니다.
            Func<int, int, int> func;

            func = add;

            float a = 3.54f;
            float b = 10.23f;

            float ret = calculator(sub, a, b);

            Console.WriteLine($"{a} - {b} = {ret}");

            Console.WriteLine($"{a} x {b} = {calculator(mul, a, b)}");

            Func<int> func1 = () => 10;

            Console.WriteLine(func1());

            Func<int, int> func2 = (int a) =>
            {
                return a;
            };

            Console.WriteLine(func2(20));

            // 맨 뒤에 요소가 리턴 타입입니다.
            Func<int, float, float> func3 = (int a, float b) =>
            {
                return a / b;
            };
        }
    }
}
