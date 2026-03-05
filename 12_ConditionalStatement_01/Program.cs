namespace _12_ConditionalStatement_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 조건이 여러개 있을때
            // if-else-if
            Console.Write("용돈을 입력하세요: ");

            string moneyStr = Console.ReadLine();

            int money = Convert.ToInt32(moneyStr);

            if (money <= 60000 && money > 40000)
            {
                Console.WriteLine("PC방");
            }
            else if (money > 100000)
            {
                Console.WriteLine("친구 만남");
            }
            else if (money <= 80000 && money > 60000)
            {
                Console.WriteLine("중국집");
            }
            else if (money <= 40000 && money > 20000)
            {
                Console.WriteLine("카페");
            }
            else // 생략 가능
            {
                Console.WriteLine("낮잠");
            }
        }
    }
}
