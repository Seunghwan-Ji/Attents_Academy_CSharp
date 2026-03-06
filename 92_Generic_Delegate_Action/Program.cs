namespace _92_Generic_Delegate_Action
{
    class Program
    {
        static void add(float a, float b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        static void add(float a, float b, int c)
        {
            Console.WriteLine($"{a} + {b} + {c} = {a + b + c}");
        }

        static void add(int a, float b, double c)
        {
            Console.WriteLine($"{a} + {b} + {c} = {a + b + c}");
        }

        static void calculator(Action<float, float> func, float a, float b)
        {
            func(a, b);
        }

        static void Main(string[] args)
        {
            // Action : genenric delegate 리턴값이 없는 경우에 사용

            Action act1 = () => Console.WriteLine("Action");

            Action<float, float> act2;

            act2 = add;
            act2(12.3f, 20.3f);

            Action<float, float, float> printFloat = (float a, float b, float c) =>
            {
                Console.WriteLine($"{a} + {b} + {c} = {a + b + c}");
            };

            printFloat(2.3f, 3.4f, 5.5f);
        }
    }
}
