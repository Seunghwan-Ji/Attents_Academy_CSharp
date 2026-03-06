namespace _95_is_as
{
    // is, as 연산자
    // as: 클래스 타입간의 형변환을 처리하는 연산자
    // 형변환이 정상적으로 이루어지지 않으면 null 을 반환합니다.

    // is: 타입 확인 (bool 값을 리턴)

    class Parent
    {
        public void ShowInfo()
        {
            Console.WriteLine($"Parent::ShowInfo()");
        }
    }

    class Child : Parent
    {
        public new void ShowInfo()
        {
            Console.WriteLine($"Child::ShowInfo()");
        }
    }

    class Child2
    {
        public void ShowInfo()
        {
            Console.WriteLine($"Child2::ShowInfo()");
        }
    }

    internal class Program
    {
        static void TestCast(Object obj)
        {

        }

        static void Main(string[] args)
        {
            Object child = new Child2();

            Parent parent = child as Parent;

            if (parent != null)
            {
                parent.ShowInfo();
            }
            else
            {
                Console.WriteLine($"형변환에 실패하였습니다.");
            }

            bool ret = child is Parent;

            if (ret)
            {
                Parent parent2 = (Parent)child;
                Console.WriteLine($"Parent Type");
            }
            else
            {
                Console.WriteLine($"Parent Type 아님");
            }
        }
    }
}
