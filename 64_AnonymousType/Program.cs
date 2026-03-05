using System;

namespace _64_AnonymousType
{

    // Anonymous Type(익명타입)
    // 컴파일러 자동으로 타입생성.
    // 읽기 전용.
    // 관리되는 힙에 위치
    // 변수를 할당 var 타입을 사용 
    // new {...}을 사용해서 만듦.
    // 익명 타입은 클래스를 정의하지 않고 임시로 타입을 생성할 수 있게 해주는 기능.
    // 참조타입



    class Program
    {
        public static (bool isSuccess, float prob) ProbabilityCalculator(float prob)
        {
            bool isSuccess = true;
            float value = 2.3f * prob;

            return (isSuccess, value);
        }

        static void Main(string[] args)
        {
            var a = new { Name = "Monster", Age = 100 };
            //a.Name = "ogre"; // 익명타입은 읽기 전용 property;

            Console.WriteLine("Name:{0}, Age: {1}", a.Name, a.Age);

            var b = new { Subject = "Mathmetics", Scores = new int[] { 90, 80, 70, 60 } };

            Console.WriteLine("Subject:{0}, Scores: ", b.Subject);
            foreach (var score in b.Scores)
            {
                Console.Write("{0} ", score);
            }

            Console.WriteLine();

            var data = ProbabilityCalculator(10.0f);

            data.isSuccess = true;


            Console.WriteLine($"data = {data}");

            // 값 기반 동등성.
            var c = new { X = 1, Y = 2 };
            var d = new { X = 1, Y = 2 };
            Console.WriteLine(c.Equals(d));


        }
    }
}

