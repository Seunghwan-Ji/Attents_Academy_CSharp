namespace _42_Inheritance_Extension
{
    // 상속
    // 기능의 확장적인 면에서의 상속

    class Math2
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int sub(int a, int b)
        {
            return a - b;
        }

        public int mul(int a, int b)
        {
            return a * b;
        }
    }

    class MathextendDiv : Math2
    {
        public float div(int a, int b)
        {
            return a / (float)b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 30;

            Math2 math2 = new Math2();

            Console.WriteLine($"{a} + {b} = {math2.add(a, b)}");
            Console.WriteLine($"{a} - {b} = {math2.sub(a, b)}");

            Console.WriteLine();
            Console.WriteLine($"Math3");
            MathextendDiv mathDiv = new MathextendDiv();

            Console.WriteLine($"{a} + {b} = {mathDiv.add(a, b)}");
            Console.WriteLine($"{a} - {b} = {mathDiv.sub(a, b)}");
            Console.WriteLine($"{a} x {b} = {mathDiv.mul(a, b)}");
            Console.WriteLine($"{a} / {b} = {mathDiv.div(a, b)}");
        }
    }
}
