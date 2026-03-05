using System.Collections;

namespace _75_IEnumerator_IEnumerable
{
    // int 배열을 가진 간단한 컬렉션 클래스
    public partial class MyNumbers : IEnumerable<int>
    {
        private int[] numbers;
        private int position;

        public MyNumbers(params int[] nums)
        {
            numbers = nums;
            position = -1; // 시작 위치
        }

        // IEnumerable<int> 구현
        public IEnumerator<int> GetEnumerator()
        {
            position = -1; // 새로운 순회를 위해 초기화
            return this as IEnumerator<int>;
        }

        // 비제네릭 IEnumerable 구현
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    // IEnumerator도 같은 클래스에서 구현
    public partial class MyNumbers : IEnumerator<int>
    {
        // 현재 요소
        public int Current { get; private set; }

        // 비제네릭 Current
        object IEnumerator.Current => Current;

        // 다음 요소로 이동
        public bool MoveNext()
        {
            position++;
            if (position < numbers.Length)
            {
                Current = numbers[position];
                Console.WriteLine($"  위치 {position}: {Current}");
                return true;
            }
            return false;
        }

        // 처음 위치로 리셋
        public void Reset()
        {
            position = -1;
            Console.WriteLine("  Reset됨");
        }

        // 리소스 해제
        public void Dispose()
        {
            Console.WriteLine("  Dispose됨");
        }
    }

    // 실행 예제
    public class Program
    {
        public static void Main()
        {
            // 숫자 컬렉션 생성
            MyNumbers nums = new MyNumbers(10, 20, 30, 40);

            Console.WriteLine("=== foreach로 순회 ===");
            foreach (int num in nums)
            {
                Console.WriteLine($"숫자: {num}");
            }

            Console.WriteLine("\n=== 다시 한번 순회 ===");
            foreach (int num in nums)
            {
                Console.WriteLine($"숫자: {num}");
            }

            Console.WriteLine("=== GetEnumerator()로 수동 순회 ===");
            var enumerator = nums.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine($"숫자: {enumerator.Current}");
            }
            enumerator.Dispose();

            Console.WriteLine("\n=== using으로 안전한 순회 ===");
            using (var enumerator2 = nums.GetEnumerator())
            {
                while (enumerator2.MoveNext())
                {
                    Console.WriteLine($"숫자: {enumerator2.Current}");
                }
            }

            Console.WriteLine("\n=== Reset() 기능 테스트 ===");
            var enumerator3 = nums.GetEnumerator();
            enumerator3.MoveNext();
            Console.WriteLine($"첫 번째 값: {enumerator3.Current}");
            enumerator3.MoveNext();
            Console.WriteLine($"두 번째 값: {enumerator3.Current}");

            enumerator3.Reset();
            enumerator3.MoveNext();
            Console.WriteLine($"Reset 후 첫 번째 값: {enumerator3.Current}");
            enumerator3.Dispose();

        }
    }
}
