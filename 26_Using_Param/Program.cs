namespace _26_Using_Param
{
    // 가변 길이 인자
    // 인자의 갯수를 유연하게 사용
    // param 키워드와 배열을 이용해서 선언하면됨
    // DataType의 형식이 동일하면 가변길이 인수를 통해 오버로딩 대신 사용할 수 있음.
    internal class Program
    {
        static int Sum(params int[] args)
        {
            int sum = 0;

            for (int i = 0; i < args.Length; i++)
            {
                sum += args[i];
            }

            return sum;
        }

        static string Sum(params string[] args)
        {
            string sum = "";
            
            for (int i = 0; i < args.Length; i++)
            {
                sum += args[i] + ", ";
            }

            return sum;
        }

        // double 값을 가변인자로 받는 메소드를 만들어보세요.

        static void Main(string[] args)
        {
            int sumValue = 0;

            sumValue = Sum(1, 2);
            Console.WriteLine($"Sum = {sumValue}");

            sumValue = Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine($"Sum = {sumValue}");

            string fruits = Sum("사과", "배");
            Console.WriteLine($"fruits = {fruits}");

            fruits = Sum("apple", "banana", "pineApple", "mango");
            Console.WriteLine($"fruits = {fruits}");

            string[] ff = { "potato", "apple", "banana", "pineApple", "mango" };
            fruits = Sum(ff);
            Console.WriteLine($"fruits = {fruits}");
        }
    }
}
