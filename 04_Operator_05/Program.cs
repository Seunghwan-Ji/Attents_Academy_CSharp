namespace _04_Operator_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 관계연산자
            // <, >, ==, !=, >=, <=
            int a = 20;
            int b = 30;

            bool ret = a < b;
            Console.WriteLine($"{a} < {b} = {ret}");

            ret = a > b;
            Console.WriteLine($"{a} > {b} = {ret}");

            ret = a == b;
            Console.WriteLine($"{a} == {b} = {ret}");

            ret = a != b;
            Console.WriteLine($"{a} != {b} = {ret}");
            
            ret = a >= b;
            Console.WriteLine($"{a} >= {b} = {ret}");

            ret = a <= b;
            Console.WriteLine($"{a} <= {b} = {ret}");
        }
    }
}
