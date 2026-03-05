namespace _47_BoxingUnBoxing
{
    // Boxing(박싱), UnBoxing(언박싱)

    // 값타입(value type) : 기본데이타타입(string 제외), 구조체, 열거체
    // 참조타입(reference type) : string, class, array

    class A
    {
        public int _value;

        public void Print()
        {
            Console.WriteLine($"_value = {_value}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 20;

            object obj = 20; // Boxing : 값타입을 참조타입으로 받는 것

            int j = (int)obj; // UnBoxing: 참조타입을 값타입으로 받는 것

            obj = new A(); // C#의 모든 클래스는 Object 타입에서 상속을 받습니다.
                           // UpCasting
            
            ((A)obj)._value = 20; // DownCasting

            A a = (A)obj;

            a.Print();

            obj = i; // Boxing

            i = (int)obj; // UnBoxing
        }
    }
}
