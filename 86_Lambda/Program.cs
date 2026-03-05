using System;

namespace _86_Lambda
{
    // 람다식(Lambda Expression) // 익명함수
    // 람다 표현식은 delegate를 이용해서 익명함수를 정의하는데 사용합니다.


    delegate int Func(int a, int b);    // 대리자 , 함수포인터
    delegate int Func2();

    class Program
    {
        static int add(int a, int b)
        {
            return a + b;
        }

        static int calculator(Func func, int a, int b)
        {
            return func(a, b);
        }
        static void Main(string[] args)
        {
            int a = 20;
            int b = 30;

            Func2 func = () => a + b;


            int ret = calculator((int a, int b) => a - b, a, b);

            Console.WriteLine($"{a} - {b} = {ret}");

            Console.WriteLine($"{a} - {b} = {calculator((int a, int b) => a - b, a, b)}");
            Console.WriteLine($"{a} x {b} = {calculator((int a, int b) => a * b, a, b)}");

            Console.WriteLine($"{a} x {b} = {calculator((int a, int b) => {
                int temp = 0;
                temp = a + b;
                return a * b;
            }, a, b)}");

            // 익명메소드
            Func fa = (int a, int b) => a - b;

            fa(a, b);

            // 람다문 (Statement Lambda);
            ret = calculator((int a, int b) =>
            {
                int temp = 0;
                temp = a + b;
                return temp;
            }, a, b);


            for (int i = 0; i < 100; i++)
            {
                // 람다식은 클래스를 생성하고 그 클래스의 인스턴스를 생성하고 처리하기때문에 
                // 메모리 사용량을 증가시킬수 있습니다.
                // 반복문안에서 람다를 사용할때는 주의 해야합니다.
                // 반복문안세서 메소드를 호출 할때는 메소드를 호출 하는 방식으로 만드는 것이 
                Func2 func2 = () => 2 + i;

                func2();
            }




        }
    }
}
