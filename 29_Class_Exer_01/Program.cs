namespace _29_Class_Exer
{
    // 손흥민을 축구게임에서 필요로 하는 데이타를 뽑고
    // 클래스를 만들고 객체를 생성해서 데이타를 저장하고 출력해보세요....
    class SoccerSon
    {
        private string _name;
        private int _age;
        private float _weight;
        private float _speed;
        private float _height;
        private string _position;

        public string Name
        {
            set
            {
                _name = value; // 일반형(블록형) 문법.
            }

            get => _name; // 축약형 문법. get => _name; 는 get { return _name; } 와 동일한 의미입니다.
        }

        public int Age
        {
            set
            {
                _age = value;
            }

            get => _age;
        }

        public float Weight
        {
            set => _weight = value; // 축약형 문법. set => _weight = value; 는 set { _weight = value; } 와 동일한 의미입니다.
            get => _weight;
        }

        public float Height
        {
            set => _height = value;
            get => _height;
        }

        public string Position
        {
            set => _position = value;
            get => _position;
        }

        public float Speed
        {
            set => _speed = value;
            get => _speed;
        }

        // 인자를 받는 생성자를 하나라도 만들면 컴파일러는 기본 생성자를 자동으로 만들어주지 않습니다.
        // 기본 생성자가 없다는 의미는 아무 인자도 받지 않고 객체를 생성할 수 없다는 의미입니다.
                
        public SoccerSon() // 기본생성자: 아무인자값도 받지 않는 생성자
        {
            Console.WriteLine($"SoccerSon 기본 생성자");
        }
        
        // 인자를 받는 생성자
        public SoccerSon(string name, int age, float weight, float speed, float height, string position)
        {
            Console.WriteLine($"SoccerSon 인자를 6개 받는 생성자");
            _name = name;
            _age = age;
            _weight = weight;
            _speed = speed;
            _height = height;
            _position = position;

        }

        public SoccerSon(string name)
        {
            Console.WriteLine($"인자를 1개 받는 생성자");
            _name = name;
            _age = 0;
            _weight = 0.0f;
            _speed = 0.0f;
            _position = "없음";
        }


        public void Run()
        {
            Console.WriteLine($"{_speed} sec의 속도로 달립니다.");
        }

        public void Info()
        {
            Console.WriteLine($"이름: {_name}");
            Console.WriteLine($"나이: {_age}");
            Console.WriteLine($"몸무게: {_weight}");
            Console.WriteLine($"100미터달리기: {_speed} sec");
            Console.WriteLine($"키: {_height}");
            Console.WriteLine($"포지션: {_position}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // 객체가 생성될때 자동으로 호출되어지는 메소드가 있습니다.
            // 이 메소드가 호출되어야지만 온전한 객체로 생성될 수 있습니다.
            // 이 메소드를 생성자(constructor)라고 합니다.
            // 생성자에서 처리할 작업이 없으면 안들어도 됩니다.
            // 하지만 생성자는 반드시 필요하기 때문에 컴파일러 자동으로 기본 생성자를 만들어서 추가합니다.
            // 생성자에는 객체 생성될때 선행되어야 하는 작업을 생성자에서 하면 됩니다.
            
            SoccerSon son = new SoccerSon(); // 기본 생성자 작동

            son.Name = "손흥민";
            son.Age = 39;
            son.Weight = 82;
            son.Height = 180;
            son.Position = "미드필더";
            son.Speed = 10.2f;

            son.Run();

            son.Info();
            Console.WriteLine();

            SoccerSon son2 = new SoccerSon("손흥민2", 37, 90, 9.8f, 182, "스트라이커"); // 인자를 6개 받는 생성자 작동

            son2.Info();
            Console.WriteLine();

            SoccerSon son3 = new SoccerSon("손흥민3"); // 인자를 1개 받는 생성자 작동
            son3.Info();
        }
    }
}
