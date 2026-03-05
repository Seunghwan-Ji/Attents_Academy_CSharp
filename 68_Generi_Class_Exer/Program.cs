using System;

namespace _68_Generi_Class_Exer
{
    // Generic Container
    class Container<T>
    {
        private T[] datas = new T[10];

        public T this[int index]
        {
            get { return datas[index]; }
            set
            {
                // index 체크 (원래 코드의 datas.Length >= 0 는 의미 없음)
                if (index >= 0 && index < datas.Length)
                    datas[index] = value;
            }
        }

        public int GetSize()
        {
            return datas.Length;
        }

        public void SetItem(int index, T value)
        {
            datas[index] = value;
        }

        public T GetItem(int index)
        {
            return datas[index];
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Container<int> intBox = new Container<int>();

            for (int i = 0; i < intBox.GetSize(); i++)
                intBox[i] = arrayInt[i];

            for (int i = 0; i < intBox.GetSize(); i++)
                Console.WriteLine(intBox[i]);

            // 위에 Container 클래스를 일반화 클래스로 만들고 float 타입을 저장하고 출력해보세요...

            Console.WriteLine();

            // float 저장/출력
            float[] arrayFloat = { 1.1f, 2.2f, 3.3f, 4.4f, 5.5f, 6.6f, 7.7f, 8.8f, 9.9f, 10.1f };

            Container<float> floatBox = new Container<float>();

            for (int i = 0; i < floatBox.GetSize(); i++)
                floatBox[i] = arrayFloat[i];

            for (int i = 0; i < floatBox.GetSize(); i++)
                Console.WriteLine(floatBox[i]);
        }
    }
}