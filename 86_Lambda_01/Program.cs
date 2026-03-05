using System;


namespace _86_Lambda_01
{
    // 무명 함수
    struct Fruit
    {
        public string Name;
        public int Count;
        public float brix;

        public override string ToString()
        {
            return $"과일명: {Name}, 갯수: {Count}, 당도: {brix}";
        }
    }

    delegate int Compare(Fruit a, Fruit b);

    class MainApp
    {
        // 정렬
        // 오름차순/ 내림차순
        static void BubbleSort(Fruit[] DataSet, Compare Comparer)
        {
            int i = 0;
            int j = 0;
            Fruit temp;

            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for (j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Fruit[] fruits = new Fruit[]
             {
            new Fruit{ Name = "apple", Count = 100, brix  = 9.2f},
            new Fruit{ Name = "banana", Count = 200, brix = 7.2f },
            new Fruit{ Name = "pineapple", Count = 300, brix = 5.6f },
            new Fruit{ Name = "apple", Count = 150, brix = 4.5f},
            new Fruit{ Name = "strawberry", Count = 400, brix = 4.5f },
            new Fruit{ Name = "mango", Count = 500, brix = 3.6f },
            new Fruit{ Name = "applemango", Count = 80, brix = 9.2f }
            };


            // 오름차순으로 Count멤버를 기준으로 sorting 해서 출력해보세요.. 람다식으로 만드세요.



        }
    }
}

