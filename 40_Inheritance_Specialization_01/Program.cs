namespace _40_Inheritance_Specialization_01
{
    // 상속
    // 특수화
    // 동물 농장 시뮬레이션
    // 돼지, 소, 닭

    // 부모 클래스에 기본적인 것들을 정의하고, 자식 클래스에서 특수화된 것들을 정의하는 방식으로 구현.
    class Animal
    {
        protected string _name;
        private float _age;
        private float _weight;
        private float _healthRate;


        public Animal(string name, float age, float weight, float healthRate)
        {
            _name = name;
            _age = age;
            _weight = weight;
            _healthRate = healthRate;
        }

        public void Speak()
        {
            Console.WriteLine($"{_name}이 말한다.");
        }

        public void Eat()
        {
            Console.WriteLine($"{_name}이 먹습니다.");
        }

        public void Run()
        {
            Console.WriteLine($"{_name}이 뜁니다.");
        }

        string GetHealth()
        {
            if (_healthRate > 90)
            {
                return "매우건강";
            }
            else if (_healthRate > 70 && _healthRate <= 90)
            {
                return "건강";
            }
            else if (_healthRate > 60 && _healthRate <= 70)
            {
                return "보통";
            }
            else if (_healthRate > 40 && _healthRate <= 60)
            {
                return "미흡";
            }
            else
            {
                return "치료요망";
            }
        }

        public void Info()
        {
            Console.Write($"이름: {_name}, 몸무게: {_weight},  나이: {_age}, 건강지수: {GetHealth()}");
        }
    }

    class Pig : Animal
    {
        public Pig(string name, float age, float weight, float healthRate)
           : base(name, age, weight, healthRate)
        {

        }

        // 부모 클래스의 Speak 메소드를 자식 클래스에서 재정의하여, 돼지에 맞는 소리를 내도록 구현.
        public new void Speak()
        {
            Console.WriteLine($"{_name}가 꿀꿀합니다.");
        }

    }

    class Cow : Animal
    {
        public Cow(string name, float age, float weight, float healthRate)
           : base(name, age, weight, healthRate)
        {

        }

        // 부모 클래스의 Speak 메소드를 자식 클래스에서 재정의하여, 소에 맞는 소리를 내도록 구현.
        public new void Speak()
        {
            Console.WriteLine($"{_name}가 음매합니다.");
        }

    }

    class Chicken : Animal
    {
        // 닭은 날 수 있는 닭과 날 수 없는 닭이 있으므로, 날 수 있는지 여부를 나타내는 변수를 추가.
        private bool _isFly;

        private void Fly()
        {
            Console.WriteLine($"{_name}이 납니다.");
        }

        public Chicken(string name, float age, float weight, float healthRate, bool isFly)
           : base(name, age, weight, healthRate)
        {
            _isFly = isFly;
        }

        // 부모 클래스의 Speak 메소드를 자식 클래스에서 재정의하여, 닭에 맞는 소리를 내도록 구현.
        public new void Speak()
        {
            Console.WriteLine($"{_name}가 꼬끼오합니다.");
        }

        // 부모 클래스의 Run 메소드를 자식 클래스에서 재정의하여,
        // 날 수 있는 닭은 Fly 메소드를 호출하고, 날 수 없는 닭은
        // 부모 클래스의 Run 메소드를 호출하도록 구현.
        public new void Run()
        {
            Fly();
        }
    }

    class Dolphin : Animal
    {
        private void Swim()
        {
            Console.WriteLine($"{_name}이 헤엄칩니다.");
        }

        public Dolphin(string name, float age, float weight, float healthRate)
           : base(name, age, weight, healthRate)
        {

        }

        // 부모 클래스의 Speak 메소드를 자식 클래스에서 재정의하여, 돌고래에 맞는 소리를 내도록 구현.
        public new void Speak()
        {
            Console.WriteLine($"{_name}가 끽끽합니다.");
        }

        // 부모 클래스의 Run 메소드를 자식 클래스에서 재정의하여,
        // 돌고래는 헤엄치는 동물이므로, Swim 메소드를 호출하도록 구현.
        public new void Run()
        {
            Swim();
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Pig pig = new Pig("돼지", 2.8f, 200.0f, 60.0f);
            Cow cow = new Cow("소", 1.9f, 240.0f, 83.0f);
            Chicken flyChicken = new Chicken("나는 닭", 2.9f, 4.0f, 90.0f, true);
            Chicken notFlyChicken = new Chicken("모나는 닭", 0.8f, 3.0f, 90.0f, false);
            Dolphin dolphin = new Dolphin("돌고래", 3.0f, 230.0f, 45.0f);

            pig.Speak();
            cow.Speak();
            flyChicken.Speak();
            notFlyChicken.Speak();
            dolphin.Speak();

            Console.WriteLine();

            pig.Eat();
            cow.Eat();
            flyChicken.Eat();
            notFlyChicken.Eat();
            dolphin.Eat();

            Console.WriteLine();

            pig.Info(); Console.WriteLine();
            cow.Info(); Console.WriteLine();
            flyChicken.Info(); Console.WriteLine();
            notFlyChicken.Info(); Console.WriteLine();
            dolphin.Info();

        }
    }
}
