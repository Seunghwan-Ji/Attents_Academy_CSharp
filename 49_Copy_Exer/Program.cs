namespace _49_Copy_Exer
{
    class MyClass
    {
        public int MyField1;
        public int MyField2;
        public string MyField3 = "monster";

        // MyClass의 Copy 함수를 만드세요.
        public MyClass Copy()
        {
            return (MyClass)this.MemberwiseClone();
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deep Copy");
            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;
                source.MyField3 = "monster4";

                MyClass target = source.Copy();
                target.MyField2 = 30;
                target.MyField3 = "monster5";

                Console.WriteLine($"{source.MyField1} {source.MyField2} {source.MyField3}");
                Console.WriteLine($"{target.MyField1} {target.MyField2} {target.MyField3}");
            }
        }
    }
}
