namespace _94_NullOperator
{
    // null operator

    class Car
    {
        public int? _weight; // nullable
        public void Move()
        {
            Console.WriteLine($"Car 가 움직입니다.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Move();

            car = null;

            if (car != null)
            {
                car.Move();
            }
            else
            {
                Console.WriteLine($"car 가 null 입니다.");
            }

            // Null Conditional Operator
            Console.WriteLine("Null Conditional Operator");
            car?.Move();

            car = new Car();

            // null 병합 연산자
            Console.WriteLine("Null 병합 연산자");
            car._weight = 10;
            int weight = car._weight ??= 0;

            Console.WriteLine($"car._weight = {weight}");

            car._weight = null;

            weight = car._weight ??= 0;

            Console.WriteLine($"car._weight = {weight}");

            // Nullable
            Console.WriteLine("Nullable");
            int a; // 값 타입

            // a = null; // 값 타입에는 null 값을 할당할 수 없습니다.

            int? b; // Nullable

            b = null;

            Console.WriteLine($"b 에 값이 {b.HasValue}");
            Console.WriteLine($"b != null {b != null}");

            b = 3;
            Console.WriteLine($"b 에 값이 {b.HasValue}");
            Console.WriteLine($"b != null {b != null}");
            Console.WriteLine($"b.value = {b.Value}");
        }
    }
}
