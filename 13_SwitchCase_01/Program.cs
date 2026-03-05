namespace _13_SwitchCase_01
{
    internal class Program
    {
        public enum ButtonType
        {
            TV_ON,
            TV_OFF,
            VOLUME_UP,
            VOLUME_DOWN
        }

        static void Main(string[] args)
        {
            // 정수값에 따라서 분기 처리를 할때 사용.
            int buttonNum = 0;

            Console.Write("버튼 번호를 입력하세요: ");
            buttonNum = Console.Read();

            buttonNum -= 48; // 아스키코드 숫자 0(48) 보정.

            Console.WriteLine($"buttonNum = {buttonNum}");

            // 0: TV ON, 1: TV OFF, 2: Volume Up, 3: Volume Down

            switch ((ButtonType)buttonNum)
            {
                case ButtonType.TV_ON:
                    int k = 0;
                    {
                        int i = 10; // 변수를 만들어 사용해야 하는 경우 {} 중괄호 블럭안에서 변수를
                                    // 만들어야 합니다.
                    }

                    Console.WriteLine("TV ON");
                    break;

                case ButtonType.TV_OFF:
                    int iii = 20;
                    Console.WriteLine("TV OFF");
                    break;
                case ButtonType.VOLUME_UP:
                    k = 20;
                    Console.WriteLine("Volume Up");
                    break;
                case ButtonType.VOLUME_DOWN:
                    iii = 1000;
                    Console.WriteLine($"Volume Down {iii}");
                    break;
                default: // 생략 가능
                    Console.WriteLine("Wrong Number");
                    break;
            }

            if (buttonNum == 0)
            {

            }
            else if (buttonNum == 1)
            {
            }

            else if (buttonNum == 2)
            {
            }
        }
    }
}
