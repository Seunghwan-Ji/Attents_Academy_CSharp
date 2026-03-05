namespace _66_Generic_Method_Exer
{
    class Program
    {


        public static void PrintAll<T>(T[] items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }

        // PrintAll 일반화 메소드를 만들고 아래의 타입들이 작동하도록 
        // 일반화 메소드로 만들고 실행 시켜보세요.
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            float[] fnumbers = { 3.4f, 7.4f, 8.9f, 10.8f, 12.7f, 13.8f };
            string[] fruits = { "Apple", "Banana", "Cherry" };

            Console.WriteLine("=== Numbers ===");
            PrintAll(numbers);

            Console.WriteLine("==== float ====");
            PrintAll(fnumbers);

            Console.WriteLine("=== Fruits ===");
            PrintAll(fruits);
        }
    }
}
