namespace _84_Delegate
{
    // Delegate: 대리자
    // C#에서 메소드를 참조하는 타입
    // 메소드를 변수로 다룰 수 있게 해주는 기능

    delegate int Func(int a, int b);  // 대리자

    class Program
    {
        static int add(int a, int b)
        {
            return a + b;
        }

        static int sub(int a, int b)
        {
            return a - b;
        }

        static int mul(int a, int b)
        {
            return a * b;
        }

        static float fadd(float a, float b)
        {
            return a + b;
        }

        // 메소드를 저장하는 타입이 있다는 의미는
        // 메소드를 다른 메소드의 인자값을 전달할 수 있다는 의미입니다.
        static int calculator(Func func, int a, int b)
        {
            return func(a, b);
        }



        static void Main(string[] args)
        {
            int a = 20;
            int b = 30;

            Func func = add;

            int ret = func(a, b);

            Console.WriteLine($"{a} + {b} = {ret}");

            func = sub;

            ret = func(a, b);
            Console.WriteLine($"{a} - {b} = {ret}");

            Console.WriteLine($"{a} - {b} = {calculator(sub, a, b)}");

            Console.WriteLine($"{a} + {b} = {calculator(add, a, b)}");


        }
    }
}
