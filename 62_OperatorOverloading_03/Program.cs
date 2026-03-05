namespace _62_OperatorOverloading_03
{
    public class Vector2D
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        // 생성자
        public Vector2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        // 벡터 + 벡터
        public static Vector2D operator +(Vector2D a, Vector2D b)
        {
            return new Vector2D(a.X + b.X, a.Y + b.Y);
        }

        // 벡터 - 벡터
        public static Vector2D operator -(Vector2D a, Vector2D b)
        {
            return new Vector2D(a.X - b.X, a.Y - b.Y);
        }

        // 벡터 * 스칼라
        public static Vector2D operator *(Vector2D v, double scalar)
        {
            return new Vector2D(v.X * scalar, v.Y * scalar);
        }

        // 스칼라 * 벡터
        public static Vector2D operator *(double scalar, Vector2D v)
        {
            return new Vector2D(v.X * scalar, v.Y * scalar);
        }

        // 벡터 / 스칼라
        public static Vector2D operator /(Vector2D v, double scalar)
        {
            return new Vector2D(v.X / scalar, v.Y / scalar);
        }

        // ToString 메서드 오버라이드
        public override string ToString()
        {
            return $"({X:F2}, {Y:F2})";
        }
    }

    // 테스트 프로그램
    public class Program
    {
        // Main 함수가 작동하도록 
        // Vector2D 클래스에 연산자 오버로딩 함수를 추가하세요.
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Vector2D 클래스 테스트 ===\n");

            // 벡터 생성
            Vector2D v1 = new Vector2D(3, 4);
            Vector2D v2 = new Vector2D(1, 2);
            Vector2D v3 = new Vector2D(-2, 1);

            Console.WriteLine($"v1 = {v1}");
            Console.WriteLine($"v2 = {v2}");
            Console.WriteLine($"v3 = {v3}");


            Console.WriteLine("\n=== 벡터 덧셈과 뺄셈 ===");
            Vector2D sum = v1 + v2;
            Console.WriteLine($"{v1} + {v2} = {sum}");

            Vector2D diff = v1 - v2;
            Console.WriteLine($"{v1} - {v2} = {diff}");

            Console.WriteLine("\n=== 스칼라 곱셈과 나눗셈 ===");
            Vector2D scaled = v1 * 2.5;
            Console.WriteLine($"{v1} × 2.5 = {scaled}");

            Vector2D divided = v1 / 2;
            Console.WriteLine($"{v1} ÷ 2 = {divided}");

            Vector2D scaled2 = 3 * v2;
            Console.WriteLine($"3 × {v2} = {scaled2}");

        }
    }
}
