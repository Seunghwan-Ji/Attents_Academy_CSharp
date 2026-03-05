namespace Base
{
    // UpCasting(업캐스팅)

    class Parent
    {
        private int _value;

        public Parent(int value)
        {
            _value = value;
        }

        public void Print()
        {
            Console.WriteLine($"Parent::Print() value = {_value}");
        }
    }

    class Child : Parent
    {
        private int _value2;

        public Child(int value1, int value2)
           : base(value1)
        {
            _value2 = value2;
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Child::Print() _value2 = {_value2}");
        }
    }

    class Child2 : Parent
    {
        private int _value2;

        public Child2(int value1, int value2)
           : base(value1)
        {
            _value2 = value2;
        }

        /*
        public new void Print()
        {

           base.Print();
           Console.WriteLine($"Child2::Print() _value2 = {_value2}");
        }
        */
    }

    class Program
    {
        static void Main(string[] args)
        {
            // UpCasting : 자식타입의 객체를 부모의 타입으로 받는 것.
            Parent parent1 = new Child(10, 200);            

            // 자식타입의 객체를 부모타입으로 받으면
            // 부모타입 참조형변수로 자식객체의 부모의 영역만 접근이 가능합니다.
            parent1.Print(); // Parent 타입의 Print() 메소드가 호출됩니다.

            Console.WriteLine();

            Parent parent2 = new Child2(20, 300);

            parent2.Print(); // Parent의 Print() 메소드 호출

            //Child child = new Parent(20); // DownCasting: 부모타입을 자식타입에 대입하는 것
            // 다운캐스팅은 원칙적으로 허용이 안됩니다.
            // 부모는 자식의 영역을 가지고 있지 않습니다.
            
            // 이렇게는 됨.
            Child cchild = (Child)parent1; // 다운 캐스팅
            cchild.Print();

            Child2 cchild2 = (Child2)parent2;   // 다운캐스팅
            cchild2.Print();
        }
    }
}
