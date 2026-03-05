using System.Data.Common;

namespace _28_Overloading
{
    // 오버로딩(Overloading)
    // 동일한 이름의 메소드(Method)를 만드는 것
    // 매개변수의 타입이나 매개변수의 갯수가 달라야 합니다.
    // 리턴타입은 메소드명에 포함되지 않습니다.

    // 오버로딩은 다형성의 도구로 사용됩니다.

    class Add
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        /*
         public float add(int a, int b) // 리턴타입이 다르다고 해서 오버로딩이 성립하지 않습니다.
         {
            return a + b;
         }
         */

        public int add(int a, int b, int c)
        {
            return a + b + c;
        }

        public float add(float a, float b)
        {
            return a + b;
        }

        public double add(double a, double b)
        {
            return a + b;
        }

        public string add(string a, string b)
        {
            return a + b; // 문자열의 덧셈은 문자열을 이어붙이는 연산입니다.
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            float c = 3.4f;
            float d = 4.5f;

            double e = 10.2d;
            double f = 32.3d;

            string g = "monster";

            string i = "is World!!";

            Add add = new Add();

            int sum = add.add(a, b);

            Console.WriteLine($"{a} + {b} = {add.add(a, b)}");
            Console.WriteLine($"{c} + {d} = {add.add(c, d)}");
            Console.WriteLine($"{g} + {i} = {add.add(g, i)}");
            Console.WriteLine($"{a} + {b} + {20} = {add.add(a, b, 20)}");
        }
    }
}
