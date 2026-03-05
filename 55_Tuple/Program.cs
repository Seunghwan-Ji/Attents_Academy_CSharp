namespace _55_Tuple
{
    internal class Program
    {
        // 튜플
        static void Main(string[] args)
        {
            // 간단한 데이터 구조로 여러 데이터요소를 그룹화할때.

            var ccc = 100; // 타입유추

            ccc = 200;

            // 명명되지 않은 튜플
            var a = ("고릴라", 100);
            Console.WriteLine($"{a.Item1}, {a.Item2}");

            // 명명된 튜플
            var b = (Kind: "Tiger", Age: 17);
            Console.WriteLine($"{b.Kind}, {b.Age}");

            // 분해
            var (name, age) = b; // (var name, var age) = b;
            Console.WriteLine($"{name}, {age}");

            // 명명된 튜플 = 명명되지 않은 튜플
            b = a;
            Console.WriteLine($"{b.Kind}, {b.Age}");

            var c = (1, 2, 3, 4, 5);
            Console.WriteLine($"{c.Item1}, {c.Item2}, {c.Item3}, {c.Item4}");

            Tuple<int, int, int, int, int> aa = new Tuple<int, int, int, int, int>(1, 2, 3, 4, 5);
        }
    }
}
