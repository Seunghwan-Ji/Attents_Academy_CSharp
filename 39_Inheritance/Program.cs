namespace _39_Inheritance
{
    // 상속(Inheritance)
    // 일반화
    // 동물농장 시뮬레이션
    // 돼지, 소, 닭

    class Stock
    {
        // 속성
        private string _name; // 이름
        private float _weight; // 몸무게
        private float _height; // 신장
        private float _age; // 나이
        private float _healthRate; // 건강 지수

        protected string Name
        {
            get => _name;
        }

        public Stock(string name, float weight, float height, float age, float healthRate)
        {
            _name = name;
            _weight = weight;
            _height = height;
            _age = age;
            _healthRate = healthRate;
        }

        public void Speak()
        {
            Console.WriteLine($"{_name}가 말합니다.");
        }

        public void Run()
        {
            Console.WriteLine($"{_name}가 뜁니다.");
        }

        public void Eat()
        {
            Console.WriteLine($"{_name}가 먹습니다.");
        }

        string GetHealth()
        {
            if (_healthRate > 90)
            {
                return "매우 건강";
            }
            else if (70 < _healthRate && _healthRate <= 90)
            {
                return "건강";
            }
            else if (60 < _healthRate && _healthRate <= 70)
            {
                return "보통";
            }
            else if (40 < _healthRate && _healthRate <= 60)
            {
                return "미흡";
            }
            else
            {
                return "치료 요망";
            }
        }
        public void Info()
        {
            Console.WriteLine($"이름: {_name}, 몸무게: {_weight}, 신장: {_height}, 나이: {_age}, 건강 지수: {GetHealth()}");
        }
    }

    class Pig : Stock
    {
        // 인자를 받는 생성자
        public Pig(string name, float weight, float height, float age, float healthRate)
            : base(name, weight, height, age, healthRate)
            // base: 부모 클래스의 생성자 호출.
        {
        }

        public new void Speak() // new: 부모 함수를 새로 정의. (안 붙여도됨)
        {
            Console.WriteLine($"{Name}가 꿀꿀합니다.");
        }
    }

    class Cow : Stock
    {
        public Cow(string name, float weight, float height, float age, float healthRate)
            : base(name, weight, height, age, healthRate)
        {
        }

        public new void Speak()
        {
            Console.WriteLine($"{Name}가 음매합니다.");
        }
    }

    class Chicken : Stock
    {
        private bool _isFly; // true: 나는 닭, false: 못나는 닭

        private void Fly()
        {
            Console.WriteLine($"{Name}이 납니다.");
        }

        public Chicken(string name, float weight, float height, float age, float healthRate, bool isFly)
            : base(name, weight, height, age, healthRate)
        {         
            _isFly = isFly;
        }

        public new void Speak()
        {
            Console.WriteLine($"{Name}이 꼬끼오 합니다.");
        }

        public new void Run()
        {
            if (_isFly)
            {
                Fly();
            }
            else
            {
                base.Run();
            }
        }

        public new void Info()
        {
            base.Info(); // 부모의 Info();
            string temp = _isFly ? "나는 닭" : "못 나는 닭";
            Console.WriteLine($", 종류: {temp}");
        }
    }

    class Sheep : Stock
    {
        private bool _type; // true: 털 양, false: 고기 양

        public Sheep(string name, float weight, float height, float age, float healthRate, bool type)
            : base(name, weight, height, age, healthRate)
        {
            _type = true;
        }

        public new void Speak()
        {
            Console.WriteLine($"{Name}이 메에에 합니다.");
        }

        public new void Info()
        {
            base.Info();
            string type = _type ? "털 양" : "고기 양";
            Console.WriteLine($"종류: {type}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pig pig = new Pig("돼지", 200.0f, 150.0f, 4.3f, 80.0f);
            Cow cow = new Cow("소", 350.0f, 200.0f, 2.3f, 70.0f);
            Chicken flyChicken = new Chicken("나는 닭", 4.3f, 1.2f, 1.5f, 60.0f, true);
            Chicken notFlyChicken = new Chicken("못나는 닭", 3.8f, 1.4f, 1.0f, 40.0f, false);
            Sheep purSheep = new Sheep("털 양", 200.0f, 150.0f, 1.8f, 60.0f, true);
            Sheep beefSheep = new Sheep("고기 양", 180.0f, 140.0f, 2.0f, 40.0f, false);

            pig.Speak();
            cow.Speak();
            flyChicken.Speak();
            notFlyChicken.Speak();
            purSheep.Speak();
            beefSheep.Speak();

            Console.WriteLine();

            pig.Run();
            cow.Run();
            flyChicken.Run();
            notFlyChicken.Run();
            purSheep.Run();
            beefSheep.Run();

            Console.WriteLine();

            pig.Eat();
            cow.Eat();
            flyChicken.Eat();
            notFlyChicken.Eat();
            purSheep.Eat();
            beefSheep.Eat();

            Console.WriteLine();

            pig.Info();
            Console.WriteLine();
            cow.Info();
            Console.WriteLine();
            flyChicken.Info();
            notFlyChicken.Info();
            purSheep.Info();
            beefSheep.Info();
        }
    }
}
