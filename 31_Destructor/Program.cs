using System.Drawing;

namespace _31_Destructor
{
    // 소멸자의 호출 시점

    // 소멸자는 객체가 메모리에 할당 되어있다가 할당된 메모리 공간을
    // 반납 처리할 때 소멸자가 호출 됩니다.
    // 소멸자 객체가 소멸될 때 해야하는 후단 작업.

    // C# 에서는 소멸자 호출 시점을 알 수가 없습니다.
    // C# 에서는 소멸자에서 코드를 작동시키면 안됩니다.

    // C# 가비지컬렉터(Garbage collector)

    class Cat
    {
        public Cat()
        {
            Console.WriteLine("Cat 기본 생성자");
            Name = "";
            Color = "";
        }

        public Cat(string _Name, string _Color)
        {
            Console.WriteLine($"{_Name} Cat 인자 2개를 받는 생성자");
            Name = _Name;
            Color = _Color;
        }

        ~Cat() // 소멸자
        {
            Console.WriteLine("Cat 소멸자");
            Console.WriteLine($"{Name} : 잘가");
        }

        public string Name;
        public string Color;

        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }

    internal class Program
    {
        public static void Sample()
        {
            Cat mons = new Cat("몬스", "회색");
            mons.Meow();
        }

        static void Main(string[] args)
        {
            Sample();
            Cat Kitty = new Cat("키티", "하얀색");
            Kitty.Meow();
            Console.WriteLine($"{Kitty.Name} : {Kitty.Color}");

            GC.Collect(); // 가비지 콜렉트를 작동.
            // 가비지 콜렉터는 메모리에서 더 이상 사용되지 않는 객체를 찾아서 메모리를 해제하는 역할을 합니다.
            
            Console.ReadLine(); // 멈춤 입력대기

            Cat nero = new Cat("네로", "검은색");
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");

            {
                Cat aa = new Cat();

                {
                    Cat bb = aa;

                    {
                        Cat cc = bb;
                    }
                }
            }
        }
    }
}
