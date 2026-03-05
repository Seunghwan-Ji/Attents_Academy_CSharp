using System;
using System.Linq;

namespace _81_LINQ
{
    // LINQ (Language Integrated Query)
    // C#에서 Data를 조회하고 조작하기 위한 통합 쿼리 언어.
    // SQL 구문으로 C#의 Data(Collections)를 다루기를 지원 합니다.
    // 배열, 리스트, 데이타 베이스등 모든 Data를 SQL 스타일로 조회
    // 컴파일 타입에 타입검사

    // from : 어떤 데이터에서 찾을 것인가?
    // where : 어떤 조건으로 찾을 것인가
    // order by : 어떤 항목을 기즈능로 정렬할 것인가
    // select : 어떤 항목 추출 할 것인가?



    class Program
    {
        static void Main(string[] args)
        {
            int[] numList = new int[100];

            System.Random rand = new System.Random(); // 난수 발생용 객체 생성


            for (int i = 0; i < numList.Length; i++)
            {
                numList[i] = rand.Next(0, 100);
            }


            Console.Write($"numList = ");
            foreach (var num in numList)
            {
                Console.Write($"{num}, ");
            }

            Console.WriteLine();

            //var list = numList.Where(n => n > 20 && n < 50).OrderByDescending(n => n); // 내림차순
            var list = numList.Where(n => n > 20 && n < 50).OrderBy(n => n);   // 오름 차순

            Console.WriteLine();

            Console.Write($"list = ");
            foreach (var num in list)
            {
                Console.Write($"{num}, ");
            }

            Console.WriteLine();
            var list2 = list.Distinct(); // 중복값을 제거해서 list2에 넣어줘

            Console.Write($"list2 = ");
            foreach (var num in list2)
            {
                Console.Write($"{num}, ");
            }


        }
    }
}
