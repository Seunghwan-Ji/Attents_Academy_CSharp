namespace _18_IterativeStatement_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while 문
            // 반복횟수는 모르지만
            // 조건식이 만족하는 동안 얼마든지 반복해도 될 경우.

            float a = 12312.43435f;

            // while (조건식)
            // {
            //      명령어들;
            // }

            while (a > 0)
            {
                a -= 123.545f;

                Console.WriteLine($"a = {a}");
            }

            a = 123231.234f;

            do
            {
                a -= 234.234f;
                Console.WriteLine($"a = {a}");
            }
            while (a > 0);
        }
    }
}
