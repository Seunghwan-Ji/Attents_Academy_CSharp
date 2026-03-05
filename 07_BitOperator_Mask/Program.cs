namespace _07_BitOperator_Mask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 비트 And : Mask off (특정자리의 비트값을 0으로 만들때)
            // 비트 Or : Mask on (특정자리의 비트값을 1로 만들때)
            int mask = 1; // 00000001
            int value = 10; // 00001010

            // value의 3번재 비트값을 0으로 만듦
            mask <<= 3;
            //     mask: // 00001000

            mask = ~mask;
            //     mask:  00001000
            //    ~mask:  11110111

            value = value & mask;
            //        value: 00001010
            //         mask: 11110111
            // value & mask: 00000010

            mask = 1;
            mask <<= 3;

            value = value | mask;
            //        value:  00000010
            //         mask:  00001000
            // value | mask:  00001010
        }
    }
}
