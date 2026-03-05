namespace _27_LocalFunction
{
    internal class Program
    {
        // 로컬함수(Local Function)
        static string ToLowerString(string input)
        {
            var arr = input.ToCharArray(); // ToCharArray: 문자열을 문자 배열로 변환하는 메서드.
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);
                // ToLowerChar: 지역함수(Local Function)로 정의된 함수로,
                // 입력된 문자열의 각 문자를 소문자로 변환하는 역할을 합니다.
            }

            // 지역함수
            char ToLowerChar(int i)
            {
                if (arr[i] < 65 || arr[i] > 90) // a~z의 ASCII 값 : 65 : 90
                    return arr[i];
                else // a~z의 ASCII 값 : 97 : 122
                    return (char)(arr[i] + 32);
            }

            return new string(arr);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ToLowerString("Hello!"));
            Console.WriteLine(ToLowerString("Good Morning!"));
        }
    }
}
