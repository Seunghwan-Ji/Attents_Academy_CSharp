namespace _56_Composition
{
    // 포함.
    // Composition: (포함), 강한결합, 생명주기를 같이 함.
    // Agreggation: (참조), 약한결합, 생명주기를 같이 하지 않음.

    class Heart
    {
        private float _purse;
        public Heart()
        {
            Console.WriteLine("Heart 생성자");
        }

        public Heart(float purse)
        {
            _purse = purse;
        }

        public void Check()
        {
            Console.WriteLine($"심장이 정상 작동중입니다.");
        }
    }

    class SmartPhone
    {
        private string _blendName;

        public SmartPhone(string blendName)
        {
            _blendName = blendName;
            Console.WriteLine($"{_blendName} SmartPhone 생성자");
        }

        public void Display()
        {
            Console.WriteLine($"{_blendName} 폰이 정상 작동 중입니다.");
        }
    }

    class Human
    {
        const int MAX = 100; // const는 변수를 만듦과 동시에 초기값을 부여해야합니다.   
                             // 초기값으로 부여된 값을 변경할 수 없습니다. 변수에 값을 보호하는 목적으로 사용.
        public readonly Heart _heart; // readonly는 실행중에 초기화가 될 수 있습니다. 처음 부터 초기화를 하지 않아도 됩니다.
                                      // 초기값을 부여하는 순간 이후에 값을 변경할 수 없습니다.

        private SmartPhone _smartPhone;  // agreggation(참조)

        public Human(SmartPhone smartPhone, float purse)
        {
            Console.WriteLine("Human 생성자");
            _heart = new Heart(purse);

            _smartPhone = smartPhone;
        }

        public void CheckHeart()
        {
            _heart.Check();
        }

        public void UsePhone()
        {
            _smartPhone.Display();
        }

        public void ChangePhone(SmartPhone phone)
        {
            _smartPhone = phone;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            SmartPhone samsungPhone = new SmartPhone("SamSung");
            SmartPhone iPhone = new SmartPhone("Apple");

            Human human = new Human(samsungPhone, 70.0f);

            human.CheckHeart();

            human.UsePhone();

            // 전화기를 바꿈.
            human.ChangePhone(iPhone);

            human.UsePhone();
        }
    }
}
