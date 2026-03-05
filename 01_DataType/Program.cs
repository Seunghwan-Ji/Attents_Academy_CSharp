// C# 프로젝트 생성하는법
// 1. 솔루션 탐색기 -> 솔루션 우클릭 -> 추가 -> 새 프로젝트
// 2. 언어: C#, 플랫폼: Windows, 형식: 콘솔 -> 템플릿 선택: 콘솔 앱
// 3. 프로젝트 이름 입력 -> 프레임 워크: .NET 8.0 -> 최상위 문 사용 안 함 체크. -> 만들기.

// C#은 객체지향 언어.
// 객체와 객체간의 상호작용으로 프로그램이 실행되며 모든게 객체로 이루어져 있음.

namespace DataType
// 아래 클래스의 소속.
// 클래스 이름 충돌 방지용 주소 같은 개념.
{
    internal class Program
    // Program이라는 클래스를 만든다는 뜻.
    // C#은 모든 코드가 클래스 안에 있어야 실행 가능.
    // internal: 이 Program 클래스는 이 프로젝트 안에서만 쓰겠다는 의미.
    // public: 어디서나 사용 가능.
    // private: 클래스 내부만.
    {
        static void Main(string[] args)
        // 프로그램 시작점.
        // C# 프로그램은 무조건 여기서 시작됨.
        // static: 객체 없이 실행 가능. (객체 생성 없이 바로 사용)
        {
            Console.Write("monster "); // 줄바꿈을 하지 않음
            Console.WriteLine("is a World!!");    // 줄바꿈을 합니다.
            // $: 문자열 안에 변수를 넣을 때 사용.
            // \t: 탭(간격) 문자.

            Console.WriteLine(string.Format("bool\t size: {0} byte", sizeof(bool)));
            Console.WriteLine("char\t size: {0} byte", sizeof(char));
            Console.WriteLine("byte\t size: " + sizeof(byte) + " byte");
            Console.WriteLine("sbyte\t size: " + sizeof(sbyte) + " byte");
            Console.WriteLine($"short\t size: {sizeof(short)} byte");
            Console.WriteLine($"ushort\t size: {sizeof(ushort)} byte");
            Console.WriteLine($"int\t size: {sizeof(int)} byte");
            Console.WriteLine($"uint\t size: {sizeof(uint)} byte");
            Console.WriteLine($"long\t size: {sizeof(long)} byte");
            Console.WriteLine($"ulong\t size: {sizeof(ulong)} byte");

            Console.WriteLine($"float\t size: {sizeof(float)} byte");
            Console.WriteLine($"double\t size: {sizeof(double)} byte");
            Console.WriteLine($"decimal\t size: {sizeof(decimal)} byte");
        }
    }
}