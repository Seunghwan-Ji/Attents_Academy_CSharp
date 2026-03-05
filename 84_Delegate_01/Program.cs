namespace _84_Delegate_01
{
    // delegate (대리자)

    delegate int MyDelegate(int a, int b);

    class Calculator
    {
        public int Plus(int a, int b) // 메소드
        {
            return a + b;
        }

        public static int Minus(int a, int b) // 정적메소드
        {
            return a - b;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Calculator Calc = new Calculator();
            MyDelegate Callback;
            
            Callback = new MyDelegate(Calc.Plus); // 일반메소드
            Console.WriteLine(Callback(3, 4));

            Callback = new MyDelegate(Calculator.Minus); // 정적메소드
            Console.WriteLine(Callback(7, 5));
        }
    }
}
