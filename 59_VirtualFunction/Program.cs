namespace _59_VirtualFunction
{
    class Parent
    {
        public void Print() // 일반메소드
        {
            Console.WriteLine("Parent::Print");
        }

        public virtual void VirtualPrint() // 가상메소드
        {
            Console.WriteLine("Parent::VirtualPrint");
        }
        public virtual void VirtualPrint2() // 가상메소드
        {
            Console.WriteLine("Parent::VirtualPrint2");
        }
    }


    class Child : Parent
    {
        public new void Print() // 메소드 Hiding
        {
            Console.WriteLine("Child::Print");
        }

        public override void VirtualPrint()
        {
            Console.WriteLine("Child::VirtualPrint");
        }

    }

    class Child2 : Parent
    {
        public new void Print() // 메소드 Hiding
        {
            Console.WriteLine("Child2::Print");
        }

        public override void VirtualPrint2()
        {
            Console.WriteLine("Child2::VirtualPrint2");
        }

    }


    class Program
    {
        // 일반 메소드 호출
        static void CallPrint(Parent value)
        {
            // 인자를 받는 참조형변수가
            // Parent 타입이어서 무조건 Parent 타입의 Print() 메소드가 
            // 호출이 됩니다.
            // 컴파일 타임(실행파일을 만들때)에  Parent의 Print메소드가
            // 호출 되도록 코드가 생성됩니다.
            // 컴파일 타임에 바인딩이 되도록 하는 것을
            // 정적 바인딩이라고 합니다.
            //value.Parent.Print();
            value.Print(); // 정적바인딩
        }

        // 가상 메소드 호출
        static void CallVirtualPrint(Parent value)
        {
            // 바인딩을 유보합니다.
            // 가상함수는 컴파일타임에 어느타입의 
            // 가상함수가 호출될지 결정할 수가 없습니다.
            // 프로그램 실행중에 어느 타입의 가상함수가 호출 될지 결정이됩니다.
            // 실행중에 바인딩이 결정나는 것을 동적바인딩
            value.VirtualPrint(); // 동적바인딩
        }

        // 가상 메소드 호출
        static void CallVirtualPrint2(Parent value)
        {
            value.VirtualPrint2();
        }

        static void Main(string[] args)
        {

            Parent parent = new Parent();
            Child child = new Child();
            Child2 child2 = new Child2();

            // 일반 메소드 호출
            CallPrint(parent);
            CallPrint(child);
            CallPrint(child2);


            // 가상메소드 호출
            CallVirtualPrint(parent);
            CallVirtualPrint(child);
            CallVirtualPrint(child2);
        }
    }
}

