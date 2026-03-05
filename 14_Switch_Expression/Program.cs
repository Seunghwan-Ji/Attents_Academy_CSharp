namespace _14_Switch_Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("점수를 입력하세요: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int score = (int)(Math.Truncate(input / 10.0f) * 10);
            // Truncate: 버림하는 함수.
            // input 값을 10 단위로 버림해서 정수로 만든다.

            Console.Write("추가 점수를 주시겠습니까 (1(true), 0(false))?");
            bool appendScore = false;

            int num = Console.Read();

            num -= 48;

            if (num == 0)
            {
                appendScore = false;
            }
            else
            {
                appendScore = true;
            }


            // switch 식
            string grade = score switch
            {
                90 when (appendScore) => "A+", // when 절로 조건을 추가.
                90 => "A",
                80 => "B",
                70 => "C",
                60 => "D",
                _ => "F" // default 역할

                /*
                score가 90이고 추가 점수 조건이 있으면 "A+"
                score가 90이면 "A"
                score가 80이면 "B"
                score가 70이면 "C"
                score가 60이면 "D"
                그 외는 "F"
                */
            };

            Console.WriteLine($"grade = {grade}");
        }
    }
}
