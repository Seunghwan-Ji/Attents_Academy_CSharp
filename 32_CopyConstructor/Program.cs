namespace _32_CopyConstructor
{
    class A
    {
        public int _value;

        // 기본 생성자
        public A()
        {
            Console.WriteLine("A Type 기본 생성자");
        }

        // 인자를 받는 생성자
        public A(int value)
        {
            Console.WriteLine("A Type 인자를 받는 생성자");          
            _value = value;
        }

        // 복사 생성자
        // C#에서는 자동으로 만들어주지 않습니다. 직접 만들어야 합니다.
        public A(A value) // 복사 생성자
        {
            _value = value._value;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"A::_value = {_value}");
        }
    }

    class B
    {
        public A _value; // 클래스 형 멤버필드
        // C# 클래스형 데이타 타입은 참조로 작동을 합니다.

        // 클래스 A타입을 인자로 받는 생성자
        public B(A value)
        {
            _value = new A(value);
        }

        public B(B value) : this(value._value) // 복사 생성자
        {
            //_value = value._value;
            //_value = new A(value._value);
        }

        ~B() // 소멸자
        {
            Console.WriteLine("B::소멸자");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"B::_value = {_value._value}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A(); // 기본 생성자
            a.ShowInfo();

            A a1 = new A(10); // 인자를 1개 받는 생성자
            a1.ShowInfo();

            // C#에서는 복사생성자를 자동으로 만들어주지 않습니다.
            // 필요시에 직접 만들어야 합니다.
            A a2 = new A(a); // 자신과 같은 타입 객체를 인자로 받는 생성자를 복사 생성자라고 합니다.
            a2.ShowInfo();

            Console.WriteLine();

            B b = new B(a);

            B b2 = new B(b); // 복사 생성자

            b.ShowInfo();
            b2.ShowInfo();

            b._value._value = 1000;

            b.ShowInfo();
            b2.ShowInfo();

            a._value = 4000;

            b.ShowInfo();
            b2.ShowInfo();
        }
    }
}
