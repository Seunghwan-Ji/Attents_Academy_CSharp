namespace _13_SwitchCase_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C#에서 switch - case 문에 문자열 사용이 가능합니다.
            Console.Write("과일 이름을 영문으로 입력하세요: ");
            string kindStr = Console.ReadLine();

            switch (kindStr)
            {
                case "banana":
                    Console.WriteLine($"{kindStr} 입니다.");
                    break;

                case "apple":
                    Console.WriteLine($"{kindStr} 입니다.");
                    break;

                case "mango":
                    Console.WriteLine($"{kindStr} 입니다.");
                    break;

                case "strawberry":
                    Console.WriteLine($"{kindStr} 입니다.");
                    break;

                default:
                    Console.WriteLine($"{kindStr} 등록되지 않은 과일을 입력하셨습니다.");
                    break;
            }
        }
    }
}
