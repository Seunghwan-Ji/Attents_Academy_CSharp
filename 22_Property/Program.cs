namespace _22_Property
{
    // 손흥민이라는 대상에서
    // 동사무소 필요한 정보는 어떤게 있을까요?

    // 주소,  string
    // 생년월일 int
    // 나이 int
    // 전화번호 string

    // 대상객체 -> 추상화 -> Data -> 캡슐화 -> 클래스형 Datatype

    // class 클래스명{
    //      Data;
    // }

    // 접근제어자
    // public: 어디서든 접근 가능
    // private: 해당 클래스 내부에서만 접근 가능(기본값)
    // protected: 상속관계에서만 접근 가능

    class Son
    {
        public string address;
        public int birthday;
        public int age;
        public string telephone;
    }

    internal class Program
    {
        // 객체지향 언어.
        static void Main(string[] args)
        {
            // 값타입(value type): 기본데이타 타입, 구조체, 열거형(스택영역에 저장공간이 만들어지고 저장공간에 값이 바로 저장하는 방식)
            // 참조타입(reference type): string, 클래스형 DataType, array(동적메모리공간에 실제 저장공간이 할당되고 스택에는 참조형변수가 만들어져 참조형변수 주소값을 저장하는 방식)

            // C# 클래스형 데이타타입은 참조 방식으로만 만들수 있습니다.
            Son son = new Son();
            son.address = "런던";
            son.birthday = 19920708;
            son.age = 33;
            son.telephone = "010-1234-5678";

            Console.WriteLine($"주소: {son.address}");
            Console.WriteLine($"생년월일: {son.birthday}");
            Console.WriteLine($"나이: {son.age}");
            Console.WriteLine($"전화번호: {son.telephone}");
        }
    }
}
