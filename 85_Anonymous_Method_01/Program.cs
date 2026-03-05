namespace _85_Anonymous_Method
{
    // 무명 함수
    struct Fruit
    {
        public string Name;
        public int Count;
        public float brix;
    }

    delegate int Compare<T>(T a, T b);

    class MainApp
    {
        // 정렬
        // 오름차순/ 내림차순
        static void BubbleSort<T>(T[] DataSet, Compare<T> Comparer) // 일반화 메소드
        {
            int i = 0;
            int j = 0;
            T temp;

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


            int[] numbers = { 2, 3, 4, 5, 6, 7, 1, 10, 23 };

            // 문제 1. numbers를 내림차순으로 Sorting 후 출력해보세요.
            BubbleSort(numbers, delegate (int a, int b)
            {
                if (a < b)
                {
                    return 1;
                }
                else if (a == b)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            });



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


            // 문제 2. fruits를  Count멤버를 기준으로 오름차순으로 sorting 해서 출력해보세요..
            BubbleSort<Fruit>(fruits, delegate (Fruit a, Fruit b)
            {
                if (a.Count > b.Count)
                {
                    return 1;
                }
                else if (a.Count == b.Count)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            });


        }
    }
}

