namespace _23_Method
{
    // c# 언어는 완벽한 객체 지향언어로 모든 것이 객체로 이루어져 있습니다.
    // 객체는 멤버필드(속성) 과 메소드 (액션)으로 구성되어있습니다.
    // 속성(attribute)는 다른 객체와 구별되어지는 데이터를 이야기 합니다.
    // 액션은 객체의 행동(행위)를 구성합니다.

    // 메소드 (클래스안에 정의된 함수를 메소드라고 합니다.)
    // 리턴타입 메소드명(매개변수) {
    //      명령어들;
    // }

    // 리턴타입은 메소드가 명령어를 처리한 결과값을 어떤 데이타 타입으로 메소드 외부에 전달할
    // 것인지를 기재합니다. (return 문에 반드시 있어야함)
    // 리턴 타입이 없는 경우 void 지정해주시면 됩니다.
    // 매개변수는 메소드를 호출할때 전달하는 값(인자: argument)를 받는 변수
    
    class Calculator
    {
        // 리턴타입은 int
        // 매개변수는 int형 2개
        // 리턴타입이 있는 경우에는 반드시 return 문이 있어야 합니다.

        public int add(int a, int b)
        {
            int sum = a + b;

            return sum;
        }

        public int sub(int a, int b)
        {
            return a - b;
        }

        // 리턴값이 없는 경우에는 void라고 지정하시면 됩니다.
        public void printName()
        {
            Console.WriteLine("Calculator");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 30;

            Calculator cal = new Calculator();

            int ret = cal.add(a, b); // 메소드는 반드시 객체를 통해서만 호츨할 수 있습니다.

            Console.WriteLine($"{a} + {b} = {ret}");

            ret = cal.sub(a, b);
            Console.WriteLine($"{a} - {b} = {ret}");

            cal.printName(); // printName은 리턴값이 없음.
        }
    }
}
