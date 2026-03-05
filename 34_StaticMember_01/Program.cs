namespace _34_StaticMember_01
{
    // 정적 멤버를 사용하는 이유
    // 유용한 잡다구리 메소드를 하나의 클래스에 몰아넣고,
    // 필요할 때마다 접근을 쉽게 해서 사용하려고.

    class Utility
    {
        // 일반 메소드는 사용하려면 객체를 생성한 후에 메소드를 객체를 통해서
        // 호출해야 합니다.

        public static float add(float a, float b) // 정적 메소드
        {
            return a + b;
        }

        public static float sub(float a, float b)
        {
            return a - b;
        }

        public static float mul(float a, float b)
        {
            return a * b;
        }
    }

    class A
    {
        private float _left;
        private float _right;

        public A(int left, int right)
        {
            _left = left;
            _right = right;
        }

        public float GetSum()
        {
            return Utility.add(this._left, this._right);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Utility util = new Utility(); // 객체 생성
            // util.add(1, 2); // 정적 메소드는 객체를 통해 호출할 수 없음.

            float a = 1.2f;
            float b = 3.4f;

            // 정적 메소드는 클래스 이름으로 바로 접근이 가능합니다.
            Console.WriteLine($"{a} + {b} = {Utility.add(a, b)}");
            Console.WriteLine($"{a} - {b} = {Utility.sub(a, b)}");

            A c = new A(10, 20);

            Console.WriteLine($"Sum = {c.GetSum()}");
        }
    }
}
