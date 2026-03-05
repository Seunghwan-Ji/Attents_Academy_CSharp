namespace _69_Collections_HashTable
{
    using System.Collections;

    // C#에서 기본적으로 빈번히 사용되어지는 자료구조를 기본적으로 제공하고 있습니다.
    // Collection은 C#에서 지원하는 자료구조 클래스
    // Collection의 종류에는 ArrayLisot, Queue, Stack, HashTable
    // Collection의 자료구조는 모든 Data를 object타입으로 저장합니다.
    // 값타입을 저장할때는 object타입으로 바뀌면서 Boxint이 발생해서 비효율적으로 작동합니다.



    class Customer
    {
        private string _name;
        private string _birth;
        private int _age;

        public Customer(string name, string birth, int age)
        {
            _name = name;
            _birth = birth;
            _age = age;
        }

        public override string ToString()
        {
            return $"이름: {_name}, 생년월일: {_birth}, 나이: {_age}";
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(33);
            arrayList.Add("String");
            arrayList.Add(3.14f);
            arrayList.Add(true);
            arrayList.Add(new Customer("monster", "18001111", 1000));

            arrayList.Insert(2, new Customer("monster2", "17001212", 11000));


            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine($"arrayList[{i}] = {arrayList[i]}");
            }

            arrayList.Remove(3.14f);
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine($"arrayList[{i}] = {arrayList[i]}");
            }

            arrayList.RemoveAt(3);
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine($"arrayList[{i}] = {arrayList[i]}");
            }


            if (arrayList.Contains("String"))
            {
                Console.WriteLine("String 문자열이 ArrayList에 저장되어 있습니다.");
            }


            arrayList.Clear();


        }
    }
}
