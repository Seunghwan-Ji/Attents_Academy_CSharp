namespace _29_Class_Exer
{
    // 손흥민을 축구게임에서 필요로 하는 데이타를 뽑고
    // 클래스를 만들고 객체를 생성해서 데이타를 저장하고 출력해보세요....

    class Son
    {
        public float _Force { set; get; }
        public float _Speed { set; get; }
        public float _Technique { set; get; }
        public float _Physical { set; get; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Son son = new Son();

            son._Force = 99.5f;
            son._Speed = 95.3f;
            son._Technique = 98.7f;
            son._Physical = 94.2f;

            Console.WriteLine($"son.Force : {son._Force}");
            Console.WriteLine($"son.Speed : {son._Speed}");
            Console.WriteLine($"son.Technique : {son._Technique}");
            Console.WriteLine($"son.Physical : {son._Physical}");
        }
    }
}
