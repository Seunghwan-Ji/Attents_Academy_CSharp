namespace Operator_Modulus
{
    internal class Program
    {
        // % (나머지 연산자, modulate 연산자)
        // 11 % 2 = 1

        // 임의의값을 일정한 범위값으로 만들대 사용합니다.

        static void Main(string[] args)
        {
            Random random = new System.Random();   // 난수 발생용 객체 생성

            for (int i = 0; i < 10; i++)
            {
                int randValue = random.Next();  // 난수 발생



                // 0: 도망(runAway), 1: 공격(attack), 2: 방어(defense)

                int actionValue = randValue % 3;
                Console.WriteLine($"randValue = {randValue}, actionValue = {actionValue}");

                switch (actionValue)
                {
                    case 0:
                        Console.WriteLine("RunAway");
                        break;

                    case 1:
                        Console.WriteLine("Attack");
                        break;

                    case 2:
                        Console.WriteLine("Defense");
                        break;
                }
            }

        }
    }
}