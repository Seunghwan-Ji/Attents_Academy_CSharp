namespace _40_Inheritance_Specialization
{
    // 열거체를 활용한 상속.
    enum AnimalType
    {
        Pig,
        Cow,
        Chicken,
        Dolphin,
    }

    class Animal
    {
        private AnimalType _type;
        private string _name;
        private float _age;
        private float _weight;
        private float _healthRate;
        private bool _isFly;
        private bool _isSwim;

        private void Fly()
        {
            Console.WriteLine($"{_name}이 납니다.");
        }

        private void Swim()
        {
            Console.WriteLine($"{_name}가 헤엄칩니다.");
        }

        public Animal(AnimalType type, string name, float age, float weight, float healthRate, bool isFly, bool isSwim)
        {
            _type = type;
            _name = name;
            _age = age;
            _weight = weight;
            _healthRate = healthRate;
            _isFly = isFly;
            _isSwim = isSwim;
        }

        public void Speak()
        {
            switch (_type)
            {
                case AnimalType.Pig:
                    Console.WriteLine($"{_name}가 꿀꿀합니다.");
                    break;
                case AnimalType.Chicken:
                    Console.WriteLine($"{_name}이 꼬끼오합니다.");
                    break;
                case AnimalType.Cow:
                    Console.WriteLine($"{_name}가 음매합니다.");
                    break;
                case AnimalType.Dolphin:
                    Console.WriteLine($"{_name}가 끽끽합니다.");
                    break;
            }
        }

        public void Eat()
        {
            Console.WriteLine($"{_name}이 먹습니다.");
        }

        public void Run()
        {
            if (_isFly)
            {
                Fly();
            }
            else
            {
                if (_isSwim)
                {
                    Swim();
                }
                else
                {
                    Console.WriteLine($"{_name}이 뜁니다.");
                }                       
            }
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
            Console.Write($"이름: {_name}, 몸무게: {_weight}, 나이: {_age}, 건강지수: {GetHealth()}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Animal pig = new Animal(AnimalType.Pig, "돼지", 2.8f, 200.0f, 60.0f, false, false);
            Animal cow = new Animal(AnimalType.Cow, "소", 1.9f, 240.0f, 83.0f, false, false);
            Animal flyChicken = new Animal(AnimalType.Chicken, "나는 닭", 2.9f, 4.0f, 90.0f, true, false);
            Animal notFlyChicken = new Animal(AnimalType.Chicken, "못나는 닭", 0.8f, 3.0f, 90.0f, false, false);
            Animal dolphin = new Animal(AnimalType.Dolphin, "돌고래", 3.0f, 230.0f, 45.0f, false, true);

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

            pig.Run();
            cow.Run();
            flyChicken.Run();
            notFlyChicken.Run();
            dolphin.Run();

            Console.WriteLine();

            pig.Info(); Console.WriteLine("\n");
            cow.Info(); Console.WriteLine("\n");
            flyChicken.Info(); Console.WriteLine("\n");
            notFlyChicken.Info(); Console.WriteLine("\n");
            dolphin.Info();
        }
    }
}
