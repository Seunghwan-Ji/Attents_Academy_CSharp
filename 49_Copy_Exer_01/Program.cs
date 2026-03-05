namespace _49_Copy_Exer_01
{
    class Wheel
    {
        float _size;
        float _depth;

        public Wheel(float size, float depth)
        {
            _size = size;
            _depth = depth;
        }

        public void Info()
        {
            Console.WriteLine($"휠사이즈: {_size}, 휠폭: {_depth}");
        }

        public Wheel Copy()
        {
            return (Wheel)this.MemberwiseClone();
        }
    }

    class Engine
    {
        string _type;

        public Engine(string type)
        {
            _type = type;
        }

        public void Info()
        {
            Console.WriteLine($"엔진타입: {_type}");
        }

        public Engine Copy()
        {
            return (Engine)this.MemberwiseClone();
        }
    }


    class Car
    {
        public float _speed;
        public float _capacity;
        public Wheel _wheel;
        public Engine _engine;

        public Car(float speed, float capacity, float size, float depth, string type)
        {
            _speed = speed;
            _capacity = capacity;
            _wheel = new Wheel(size, depth);
            _engine = new Engine(type);
        }

        public void Info()
        {
            Console.WriteLine($"속도: {_speed}, 용량: {_capacity}");
            _wheel.Info();
            _engine.Info();
        }

        public Car Copy()
        {
            return (Car)this.MemberwiseClone();
        }

        public Car DeepCopy()
        {
            Car temp = Copy();
            temp._wheel = this._wheel.Copy();
            temp._engine = this._engine.Copy();
            return temp;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(200.0f, 60.0f, 29, 30, "4기통");

            car.Info();

            // Car class에 DeepCopy 메소드를 만들고 DeepCopy메소드 작동해서
            // 객체를 생성하고 생성된 값을 출력해보세요...
            Console.WriteLine();
            Car car2 = car.DeepCopy();
            car2.Info();
        }
    }
}
