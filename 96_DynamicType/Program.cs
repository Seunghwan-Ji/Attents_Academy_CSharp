namespace _96_DynamicType
{

    public class Robot
    {
        public void Move() => Console.WriteLine("로봇이 이동합니다.");
    }
    public class Dog
    {
        public void Move() => Console.WriteLine("강아지가 뜁니다.");
    }

    internal class Program
    {
        // 상속관계가 없는 클래스라도 동일한 메서드만 있으면 실행이 가능합니다.
        static void ExecuteMove(dynamic obj)
        {
            obj.Move();
        }

        static void Main(string[] args)
        {
            //
            var a = 10; // var type은  컴파일타임(실행파일을 만들때) a변수의 형이 결정이 납니다.

            //a = 1.0f;  // a변수는 int 형으로 결정이 났기 때문에 float형값을 저장할 수 없습니다.

            dynamic v = 10; // dynamic type은 실행중에 형이 결정납니다. 어떤 타입이든지 저장가능하지만 되도록 사용하지 않는 것이 좋습니다.
            Console.WriteLine(v.GetType());

            v = "Hello";
            Console.WriteLine(v.GetType());

            v = new List<int>();
            Console.WriteLine(v.GetType());

            ExecuteMove(new Robot());
            ExecuteMove(new Dog());
        }
    }
}
