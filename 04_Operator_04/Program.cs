namespace _04_Operator_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("논리연산자");
            // 논리연산자
            // &&(논리 And), || (논리 OR), !(논리 Not)

            // 논리 And(그리고)
            // 논리 And 연산자는 False 확률이 높은 것을 앞에 위치시키는 것이 유리함.
            bool ret = true && true;
            Console.WriteLine($"True && True = {ret}");

            ret = true && false;
            Console.WriteLine($"True && False = {ret}");

            ret = false && true;
            Console.WriteLine($"False && True = {ret}");

            ret = false && false;
            Console.WriteLine($"False && False = {ret}");

            // 논리 OR(또는)
            // 논리 OR 연산자는 true 확률이 높은 것을 앞쪽에 놓는 것이 유리함.
            ret = true || true;
            Console.WriteLine($"True || True = {ret}");

            ret = true || false;
            Console.WriteLine($"True || False = {ret}");

            ret = false || true;
            Console.WriteLine($"False || True = {ret}");

            ret = false || false;
            Console.WriteLine($"False || False = {ret}");

            // 논리 Not
            ret = !true;
            Console.WriteLine($"!True = {ret}");

            ret = !false;
            Console.WriteLine($"!False = {ret}");
        }
    }
}
