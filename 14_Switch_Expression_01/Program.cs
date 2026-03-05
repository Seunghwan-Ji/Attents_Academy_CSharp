namespace _14_Switch_Expression_01
{
    internal class Program
    {
        public static string GetGrade(int score, bool appendScore)
        {
            switch (score)
            {
                case 90 when appendScore:
                    return "A+";
                case 90:
                    return "A";

                case 80:
                    return "B";

                case 70:
                    return "C";

                case 60:
                    return "D";

                default:
                    return "F";
            }
        }

        static void Main(string[] args)
        {
            Console.Write("점수를 입력하세요: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int score = (int)(Math.Truncate(input / 10.0f) * 10);

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

            // switch식
            string grade = score switch
            {
                90 when (appendScore) => "A+", // when 절로 조건을 추가
                90 => "A",
                80 => "B",
                70 => "C",
                60 => "D",
                _ => "F" // default
            };

            Console.WriteLine($"grade = {grade}");

            grade = GetGrade(score, appendScore);
            Console.WriteLine($"grade = {grade}");
        }
    }
}
