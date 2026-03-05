namespace _25_Optional_Param
{
    internal class Program
    {
        // Optional parameter(선택적 매개변수)
        // 메소드 선언시 매개변수의 기본값을 할당
        // 호출자가 인수를 입력하지 않으면 기본값으로 할당된 매개변수로 사용.

        static void PrintMergeName(string name, string nickName = "바보")
        {
            Console.WriteLine($"{name}은 {nickName}이다");
        }

        /* default 인자는 매개변수 리스트의 우측에서 좌측으로 채워야 합니다.
        static void PrintMergeName2(string name = "바보", string nickName )
        {
            Console.WriteLine("{0}은 {1}이다", name, nickName);
        }
        */

        static void Main(string[] args)
        {
            PrintMergeName("몬스터");
            PrintMergeName("몬스터", "천재");
            PrintMergeName(name: "몬스터");
            PrintMergeName(name: "몬스터", nickName: "천재");
        }
    }
}
