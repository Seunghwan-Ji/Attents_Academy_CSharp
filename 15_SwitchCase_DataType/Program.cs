namespace _15_SwitchCase_DataType
{
    class Monster
    {
        public new string ToString()
        {
            return "Monster";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = 123.43f;
            // object: 모든 타입의 최상위 부모 타입

            obj = "Monster";

            // obj = new Monster();

            // obj = 1;

            // C# 9.0
            // switch-case 문에서 DataType, 형식을 사용 가능

            switch (obj)
            {
                case int i:
                    Console.WriteLine($"i = {i}");
                    break;

                case float f:
                    Console.WriteLine($"f = {f}");
                    break;

                case double d:
                    Console.WriteLine($"d = {d}");
                    break;
            }
        }
    }
}
