using System;
using System.Globalization;

namespace _67_GenericProgramming
{
    class Test
    {
        private int _num1;
        private int _num2;

        public Test(int num1, int num2)
        {
            _num1 = num1;
            _num2 = num2;
        }

        public override string ToString()
        {
            return $"_num1 = {_num1}, _num2 = {_num2}";
        }
    }

    // generic class
    class ArrayStack<T> // where T : class // 참조타입만 가능
    {
        private int _index = 0;
        private int _size;
        private T[] _array;

        public int Size
        {
            get => _size;
        }

        public ArrayStack(int size)
        {
            _index = 0;
            _size = size;
            _array = new T[size];
        }

        public void Push(T data)
        {
            if (_index >= _size)
            {
                return;
            }

            _array[_index++] = data;
        }

        public T Pop()
        {
            if (_index > 0)
            {
                return _array[--_index];
            }
            else
            {
                return default(T); // 스택에 저장된 데이타가 없음.
            }
        }

        public T Top()
        {
            if (_index > 0)
            {
                return _array[_index - 1];
            }

            return default(T);

        }

    }


    /*
    class ArrayStackInt
    {
       private int _index = 0;
       private int _size;
       private int[] _array;

       public int Size
       {
          get => _size;
       }

       public ArrayStackInt(int size)
       {
          _index = 0;
          _size = size;
          _array = new int[size];
       }

       public void Push(int data)
       {
          if(_index >= _size)
          {
             return;
          }

          _array[_index++] = data;
       }

       public int Pop()
       {
          if(_index > 0)
          {
             return _array[--_index];
          } else
          {
             return -1; // 스택에 저장된 데이타가 없음.
          }
       }

       public int Top()
       {
          if(_index > 0)
          {
             return _array[_index - 1];
          }

          return -1;

       }

    }

    class ArrayStackFloat
    {
       private int _index = 0;
       private int _size;
       private float[] _array;

       public int Size
       {
          get => _size;
       }

       public ArrayStackFloat(int size)
       {
          _index = 0;
          _size = size;
          _array = new float[size];
       }

       public void Push(float data)
       {
          if (_index >= _size)
          {
             return;
          }

          _array[_index++] = data;
       }

       public float Pop()
       {
          if (_index > 0)
          {
             return _array[--_index];
          }
          else
          {
             return -1; // 스택에 저장된 데이타가 없음.
          }
       }

       public float Top()
       {
          if (_index > 0)
          {
             return _array[_index - 1];
          }

          return -1;

       }

    }
    */



    class Program
    {
        static void Main(string[] args)
        {
            ArrayStack<int> arrayStackInt = new ArrayStack<int>(10);

            for (int i = 0; i < arrayStackInt.Size; i++)
            {
                arrayStackInt.Push(i);
            }

            for (int i = 0; i < arrayStackInt.Size; i++)
            {
                Console.WriteLine($"{arrayStackInt.Pop()}");
            }

            Console.WriteLine();
            ArrayStack<float> arrayStackFloat = new ArrayStack<float>(10);

            for (int i = 0; i < arrayStackFloat.Size; i++)
            {
                arrayStackFloat.Push(i * 1.2f);
            }

            for (int i = 0; i < arrayStackFloat.Size; i++)
            {
                Console.WriteLine($"{arrayStackFloat.Pop()}");
            }

            Console.WriteLine();
            ArrayStack<Test> testStack = new ArrayStack<Test>(10);

            for (int i = 0; i < testStack.Size; i++)
            {
                testStack.Push(new Test(i, i));
            }

            for (int i = 0; i < testStack.Size; i++)
            {
                Console.WriteLine($"{testStack.Pop()}");
            }

        }
    }
}

