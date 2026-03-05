namespace _20_LowHighGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matchValue = 0;
            int randValue = 0;
            int count = 0;

            Random random; // Random 클래스 타입 변수 선언.

        Start:;

            random = new System.Random(); // 난수 발생용 객체 생성.

            randValue = random.Next(); // 난수 발생.

            matchValue = randValue % 101; // 0 ~ 100

            Console.WriteLine("0 ~ 100사이의 값 중 하나의 값이 설정되었습니다.");
            Console.WriteLine("그 값이 어떤 값인지 맞춰보세요.");

            while (true)
            {
                Console.Write("값을 입력하세요: ");
                int inputValue = int.Parse(Console.ReadLine());

                if (inputValue > matchValue)
                {
                    Console.WriteLine($"입력된 {inputValue} 값이 맞춰야 하는 값보다 큽니다.");
                    count++;
                }
                else if (inputValue < matchValue)
                {
                    Console.WriteLine($"입력된 {inputValue} 값이 맞춰야 하는 값보다 작습니다.");
                    count++;
                }
                else
                {
                    Console.WriteLine($"{count} 횟수 만에 같은 값을 찾으셨습니다. 값은 {matchValue}");
                    Console.WriteLine("계속 하시겠습니까? (탈출: Exit, 계속: continue)");
                    string str = Console.ReadLine();

                    switch (str)
                    {
                        case "Exit":
                        case "exit":
                            goto Exit;

                        case "Continue":
                        case "continue":
                            goto Start;

                        default:
                            goto Exit;
                    }
                }
            }
        Exit:;
        }
    }
}
