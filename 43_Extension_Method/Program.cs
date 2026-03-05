using _43_Extension_Method.Base;
// _43_Extension_Method 네임 스페이스 안에 Base 네임 스페이스를 사용하겠다.

namespace _43_Extension_Method
{
    namespace Base
    {
        // 확장메소드
        // 기존 클래스의 기능을 확장하는 기능입니다. (상속x)

        sealed public class Math2 // sealed 키워드로 Math2를 더이상 상속하지 말도록 처리됨.
        {

            public int add(int a, int b)
            {
                return a + b;
            }

            public int sub(int a, int b)
            {
                return a - b;
            }
        }

        // 클래스를 static class
        // 확장할 메소드는 static Method
        // static 메소드에 첫번째 매개변수 this 키워드 확장할 클래스Datatype
        public static class Math2Extension
        {
            public static float div(this Math2 myMath, int a, int b)
            {
                return a / (float)b;
            }

            public static float mul(this Math2 myMath, int a, int b)
            {
                return a * (float)b;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 30;

            Math2 math2 = new Math2();

            int sum = 0;

            sum = math2.add(a, b);
            Console.WriteLine($"{a} + {b} = {sum}");

            sum = math2.sub(a, b);
            Console.WriteLine($"{a} - {b} = {sum}");


            float ret = math2.div(a, b);
            Console.WriteLine($"{a} / {b} = {ret}");


            // Math2 클래스 mul (곱셈) 확장 메소드를 추가하고
            // 실행해보세요..

            float ret2 = math2.mul(a, b);
            Console.WriteLine($"{a} x {b} = {ret2}");
        }
    }
}
