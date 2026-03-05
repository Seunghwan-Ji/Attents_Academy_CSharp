namespace _11_Signed_Unsigned
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 음수와 양수
            int a = 500;
            Console.WriteLine(a);

            uint b = (uint)a;
            Console.WriteLine(b);

            int x = -30;
            Console.WriteLine(Convert.ToString(x, 2));
            Console.WriteLine(x);

            uint y = (uint)x;
            Console.WriteLine(y);

            sbyte i = -1; // 11111111
            Console.WriteLine($"i = {i}");

            byte ii = (byte)i; // 11111111
            Console.WriteLine($"ii = {ii}");
        }
    }
}
