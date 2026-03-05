namespace _54_Indexer
{
    // 인덱서
    // C# 객체를 배열처럼 사용할 수 있게 해주는 기능
    // 클래스나 구조체 타입의 객체를 배열처럼 접근할 수 있게 해주는 일종의 property입니다.
    // 인덱서를 사용하려면 내부에 collection이 있어야 합니다.
    class NumList
    {
        private List<int> datas = new List<int>(10);

        public int Length
        {
            get { return datas.Count; }
        }


        // 인덱서
        public int this[int index]
        {
            get { return datas[index]; }
            set
            {
                if (datas.Count <= 0)
                {
                    datas.Add(value);
                }
                else if (datas.Count <= index)
                {
                    datas.Add(value);
                }
                else
                {
                    datas[index] = value;
                }
            }
        }
    }

    class NumArray
    {
        private int[] datas = new int[10];

        public int Length
        {
            get { return datas.Length; }
        }

        public int this[int index]
        {
            get { return datas[index]; }

            set
            {
                if (datas.Length <= index)
                {
                    int[] datas2 = new int[index + 1];

                    for (int i = 0; i < datas.Length; i++)
                    {
                        datas2[i] = datas[i];
                    }

                    datas = datas2;

                    datas[index] = value;
                }
                else
                {
                    datas[index] = value;
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            NumList numList = new NumList();
            numList[0] = 1;
            numList[1] = 2;
            numList[2] = 3;
            numList[3] = 4;

            numList[9] = 9;

            for (int i = 0; i < numList.Length; i++)
            {
                Console.WriteLine($"numList[{i}] = {numList[i]}");
            }

            Console.WriteLine();
            numList[2] = 10;

            for (int i = 0; i < numList.Length; i++)
            {
                Console.WriteLine($"numList[{i}] = {numList[i]}");
            }

            Console.WriteLine();

            NumArray numArray = new NumArray();

            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = i;
            }

            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine($"numArray[{i}] = {numArray[i]}");
            }

            numArray[11] = 2;

            Console.WriteLine();

            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine($"numArray[{i}] = {numArray[i]}");
            }


        }
    }
}
