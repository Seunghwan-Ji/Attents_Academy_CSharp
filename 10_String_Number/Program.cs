namespace _10_String_Number
{
    internal class Program
    {
        // 숫자 문자열을 값으로 변환
        static void Main(string[] args)
        {
            // 정수값을 문자열로 변환
            int a = 1000;
            string b = a.ToString();
            Console.WriteLine(b);

            float c = 3.14f;
            string d = c.ToString();
            Console.WriteLine(d);

            // 숫자 문자열을 정수값으로 변환
            string e = "342356";
            int f = Convert.ToInt32(e);

            f = int.Parse(e);

            Console.WriteLine(f);

            string g = "23.456";
            float h = float.Parse(g);
            h = (float)Convert.ToDouble(g);
            Console.WriteLine(h);
        }
    }
}
