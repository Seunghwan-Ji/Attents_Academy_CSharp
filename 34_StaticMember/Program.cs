namespace _34_StaticMember
{
    // 정적 멤버를 어느 경우에 사용하나?
    // 범용성 있는 Data에 쉽게 접근하게 하려고

    class GlobalData
    {
        private static int _score; // 정적 멤버
        private static int _volume;
        private static int _stage;

        public static int Score // 정적 프로퍼티
        {
            get { return _score; }

            set
            {
                if (value > 500)
                {
                    _score = 100;
                }
                else
                {
                    _score = value;
                }
            }        
        }

        public static int Volume
        {
            get => _volume;
            set => _volume = value;
        }

        public static int Stage
        {
            get => _stage;
            set => _stage = value;
        }

        public static int GetScore()
        {
            return _score;
        }
    }

    class A
    {
        public int _volume;

        public void SetVolume()
        {
            _volume = GlobalData.Volume;
        }

        public void PrintScore()
        {
            Console.WriteLine($"GlobalData.Score = {GlobalData.Score}");
        }
    }

    class B
    {
        public void PrintCurrentStage()
        {
            Console.WriteLine($"GlobalData.Score = {GlobalData.Score}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            GlobalData.Score = 1000;

            A a = new A();
            B b = new B();

            a.PrintScore();
            b.PrintCurrentStage();
        }
    }
}
