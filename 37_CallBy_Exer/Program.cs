namespace _37_CallBy_Exer
{
    internal class Program
    {
        public static void Swap(int a, int b)
        {
            int temp = 0;

            temp = a;
            a = b;
            b = temp;
        }

        // 인자로 전달받은 2개의 변수의 값을 변경하는 메소드를 만들고 메인에 있는
        // a변수와 b변수의 값을, 만든 함수를 호출해서 바꿔보세요...
        public static void SwapRef(ref int a, ref int b)
        {
            int temp = 0;

            temp = a;
            a = b;
            b = temp;
        }

        /*
        public static void SwapOut(out int a, out int b)
        {
            int temp = 0;
            
            out 매개변수는 함수 안에서 반드시 값을 할당해야 함.
            할당하기 전에는 읽을 수 없음
            
            temp = a;
            a = b;
            b = temp;
        }
        */

        static void Main(string[] args)
        {
            int a = 20; // 지역범위(로컬변수), 자동변수
            int b = 30;

            Console.WriteLine($"before Swap a = {a}, b = {b}");
            Swap(a, b);
            Console.WriteLine($"after Swap a = {a}, b = {b}");

            Console.WriteLine();
            Console.WriteLine($"before SwapRef a = {a}, b = {b}");
            SwapRef(ref a, ref b);
            Console.WriteLine($"after SwapRef a = {a}, b = {b}");
        }
    }
}
