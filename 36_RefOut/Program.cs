namespace _36_RefOut
{
    // 메소드를 호출할 때 인자를 전달하는 방식
    // 1. call by value (값에 의한 호출)
    // 2. call by reference (주소값에 의한 호출)

    // C#
    // 값타입(Value Type): 기본 데이터 타입, 열거체, 구조체
    // 참조타입(Reference Type): 클래스, string, array

    internal class Program
    {
        static void add(int a, int b, int ret)
        {
            ret = a + b;
        }

        static void addref(int a, int b, ref int ret)
        {
            // ref 키워드로 전달한 매개변수에는 값을 넣지 않아도
            // 에러가 나지 않습니다.
            ret = a + b;
        }

        static void addout(int a, int b, out int ret)
        {
            // out 키워드가 전달된 변수에 반드시 값을 넣어야 합니다.
            ret = a + b;
        }

        static void Calculate(int a, int b, out int addValue, out int subValue, out int mulValue)
        {
            addValue = a + b;
            subValue = a - b;
            mulValue = a * b;
        }

        static int add(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            int a = 20;
            int b = 30;

            int ret = 0;
            int outret; // out 키워드로 전달하는 변수는 초기화가 되어있지 않아도 됩니다.

            add(a, b, ret);
            Console.WriteLine($"{a} + {b} = {ret}");

            // ref 키워드로 전달하는 변수는 초기화가 되어있어야 합니다.
            addref(a, b, ref ret);
            Console.WriteLine($"{a} + {b} = {ret}");

            // out 키워드로 전달하는 변수는 초기화가 되어있지 않아도 됩니다.
            addout(a, b, out outret);
            Console.WriteLine($"{a} + {b} = {outret}");

            int addValue;
            int subValue;
            int mulValue;

            // 리턴값을 여러개 받아야 할 때,
            // out 키워드를 사용하시면 됩니다.
            Calculate(a, b, out addValue, out subValue, out mulValue);

            Console.WriteLine($"{a} + {b} = {addValue}");
            Console.WriteLine($"{a} - {b} = {subValue}");
            Console.WriteLine($"{a} * {b} = {mulValue}");
        }
    }
}
