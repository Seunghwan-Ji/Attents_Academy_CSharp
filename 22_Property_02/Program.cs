namespace _22_Property_02
{
    class Car
    {
        private string modelName; // 멤버필드
        private int wheelCount;
        // private int speed
        private bool isCargo;

        // property
        public string ModelName
        {
            set
            {
                modelName = value;
            }

            get
            {
                return modelName;
            }
        }

        public int WheelCount
        {
            get => wheelCount;
        }

        public float Speed { private set; get; } // 자동구현 프로퍼티
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.ModelName = "포터";

            Console.WriteLine($"car.ModelName = {car.ModelName}");
        }
    }
}
