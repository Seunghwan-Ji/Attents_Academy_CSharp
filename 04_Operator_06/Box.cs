namespace _04_Operator_06
{
    internal class Box
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수값을 입력하세요: ");
            string inputStr = Console.ReadLine(); // 문자열을 입력.

            // int inputValue = Console.Read(); // 한 문자 입력

            int inputValue = 0;

            // 예외 처리문
            try
            {
                // 예외가 발생할 수 있는 코드.
                inputValue = int.Parse(inputStr);
            }
            catch (Exception ex)
            // Exception: 모든 예외의 부모 클래스.
            // ex: 발생한 예외 객체.
            {
                // 예외가 발생했을 때 실행.
                Console.WriteLine(ex.ToString());
            }

            bool ret = (0 < inputValue) && (inputValue < 10);

            if (ret == true)
            {
                Console.WriteLine($"x:{inputValue}가 0과 10 사이에 있다.");
            }
            else
            {
                Console.WriteLine($"x:{inputValue}가 0과 10 사이에 없다.");
            }

            // todo: 박스(0, 0) ~ (10, 10)에 점(x, y)가 포함되는지 확인하는 로직 작성해서 실행해보세요.
            Console.WriteLine("x값을 입력하세요: ");
            string InputX = Console.ReadLine();
            int X = int.Parse(InputX);

            Console.WriteLine("y값을 입력하세요: ");
            string InputY = Console.ReadLine();
            int Y = int.Parse(InputY);

            if ( ((0 < X) && (X < 10)) && ((0 < Y) && (Y < 10)) )
            {
                Console.WriteLine($"점 ({X}, {Y})은 박스 안에 포함됨.");
            }
            else
            {
                Console.WriteLine($"점 ({X}, {Y})은 박스 안에 포함되지 않음.");
            }
        }
    }
}
