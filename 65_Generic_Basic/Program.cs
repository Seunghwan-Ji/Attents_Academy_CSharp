namespace _202602261614_Generic_Basic
{
    // 일반화 프로그래밍.
    // generic 프로그래밍
    // DataType에 일반화한 프로그래밍 환경을 제공함.

    class Base
    {

    }

    class Test
    {
        int _value;
        int _value2;

        public Test(int value, int value2)
        {
            _value = value;
            _value2 = value2;
        }

        public override string ToString()
        {
            return $"_value = {_value}, _value2 = {_value2}";
        }
    }


    class Program
    {
        /*
        static void Swap(ref int a, ref int b)
        {
           int temp = 0;
           temp = a;
           a = b;
           b = temp;
        }

        static void Swap(ref float a, ref float b)
        {
           float temp = 0.0f;
           temp = a;
           a = b;
           b = temp;
        }

        static void Swap(ref double a, ref double b)
        {
           double temp = 0.0;
           temp = a;
           a = b;
           b = temp;
        }


        static void Swap( ref string a, ref string b)
        {
           string temp = "";
           temp = a;
           a = b;
           b = temp;
        }
        */

        // 제약사항
        // where T : struct => 값타입만 가능
        // where T : class => 참조타입만 가능
        // where T : new() => T는 기본생성자가 있어야함
        // where T: Base => T는 Base 클래스에서 파생된 클래스만 가능
        // where T: IMove => T는 IMove 인터페이스가 있어야 함.

        // 다중제약
        // where T : Base, IMove, new() => Base에서 파생된 클래스, IMove 인터페이스, 기본생성자가 있어야함..

        // 일반화 메소드
        static void Swap<A>(ref A a, ref A b) // where A : Base

        {
            A temp;
            temp = a;
            a = b;
            b = temp;
        }


        static void Print<T, T1>(T a, T1 b)
        {
            Console.WriteLine($"a = {a}, b = {b}");
        }


        static void Main(string[] args)
        {
            int a = 20;
            int b = 30;

            float c = 2.4f;
            float d = 3.4f;

            double e = 10.3d;
            double f = 20.4d;

            string str = "monster";
            string str2 = " is World!!";

            Console.WriteLine($"before a = {a} , b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"after a = {a} , b = {b}");

            Console.WriteLine($"before c = {c} , d = {d}");
            Swap(ref c, ref d);
            Console.WriteLine($"after a = {c} , b = {d}");


            Console.WriteLine($"before e = {e} , f = {f}");
            Swap(ref e, ref f);
            Console.WriteLine($"after e = {e} , f = {f}");


            Console.WriteLine($"before str = {str} , str2 = {str2}");
            Swap(ref str, ref str2);
            Console.WriteLine($"after str = {str} , str2 = {str2}");

            Test aa = new Test(10, 20);
            Test bb = new Test(40, 50);

            Console.WriteLine($"Before aa = {aa}, bb = {bb}");
            Swap(ref aa, ref bb);
            Console.WriteLine($"After aa = {aa}, bb = {bb}");


            Print(a, c);

            Print(str, aa);

        }
    }
}
