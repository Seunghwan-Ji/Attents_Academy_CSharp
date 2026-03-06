namespace _88_DelegateChain
{
    delegate void CalChain(int a, int b);

    // delegate chain: delegate에 여러개의 함수를 연결해서 일괄적으로 처리할때 사용.

    class Program
    {
        static void add(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        static void sub(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }

        static void mul(int a, int b)
        {
            Console.WriteLine($"{a} x {b} = {a * b}");
        }

        static void div(int a, int b)
        {
            Console.WriteLine($"{a} / {b} = {a / (float)b}");
        }

        static void Main(string[] args)
        {
            // delegate chain
            CalChain cal =
                (CalChain)Delegate.Combine(
                    new CalChain(add),
                    new CalChain(sub),
                    new CalChain(mul)
                );

            cal(200, 300);

            Console.WriteLine();
            cal += div; // 델리게이트 체인에 메소드 추가.

            cal(20, 30);

            cal -= div; // 델리게이트 체인에서 메소드 빼기.

            Console.WriteLine();

            cal(20, 30);
        }
    }
}
