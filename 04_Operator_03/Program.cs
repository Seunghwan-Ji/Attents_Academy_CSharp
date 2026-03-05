namespace _04_Operator_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 할당연산자
            int a = 20;
            int b = 30;
            float c = 1.2f;

            a = b;

            // C#은 DataType의 처리가 엄격함.
            // 다른 타입간에는 명시적으로 형변환을 해야됨.
            // 실수형을 정수형에 대입할 때는 형변환 연산자를 사용해야됨.
            a = (int)c;

            // 할당연산자 축약형
            a += 1;
            // a = a + 1;

            a -= b;
            // a = a - b;

            a /= 2;
            // a = a / 2;
        }
    }
}
