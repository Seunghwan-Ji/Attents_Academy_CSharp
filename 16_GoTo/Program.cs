namespace _16_GoTo
{
    internal class Program
    {
        // 무조건 분기
        // goto 문
        static void Main(string[] args)
        {
            int inputValue = 0;

        Start: // 레이블
            Console.Write("값을 입력하세요: ");
            inputValue = int.Parse(Console.ReadLine());

            if (inputValue < 10)
            {
                goto Exit; // 하향식 분기
            }

            Console.WriteLine($"{inputValue} 값이 10보다 크거나 같아서 다시");

            goto Start; // 무조건 분기 goto문

            Console.WriteLine("실행 절대 안됨");

        Exit: // 레이블
            Console.WriteLine($"{inputValue} 값이 10보다 작아서 탈출");
        }
    }
}
