namespace _38_CallByReference
{
    // 메소드 호출할때 인자를 전달하는 방식이
    // 1. call by value
    // 2. call by reference

    // C#
    // 값타입 : 기본 데이타 타입, 구조체, 열거체
    // 참조타입 : 클래스형 DataType, string , array

    class A
    {
        public int _value;

        public void Info()
        {
            Console.WriteLine($"_value = {_value}");
        }
    }

    struct B // 구조체
    {
        public int _bValue;

        public void Info()
        {
            Console.WriteLine($"_bvalue = {_bValue}");
        }
    }

    class Program
    {

        // A Type 인자로 받는 메소드
        // call by reference
        private static void ChangeValue(A value, int num)
        {
            value._value = num;
        }

        // 클래스형 B Type을 인자로 받는 메소드
        // call by value
        private static void ChangeValue(B value, int num)
        {
            value._bValue = num;
        }

        private static void ChangeValueRef(ref B value, int num)
        {
            value._bValue = num;
        }


        static void Main(string[] args)
        {


            Console.WriteLine("클래스형 타입");
            A aa = new A(); // A Type 객체 생성
            aa._value = 100;

            aa.Info();

            ChangeValue(aa, 1000); // 클래스형 데이타 타입은 call by reference 

            aa.Info();

            Console.WriteLine("구조체 타입");
            B b;
            b._bValue = 200;

            b.Info();

            ChangeValue(b, 1000); // call by value

            b.Info();

            // 구조체 변수 b를 인자로 전달해서 b변수의 값을 변경하는 함수를 만들고 실행해보세요...
            ChangeValueRef(ref b, 1000); // call by reference

            b.Info();
        }
    }
}
