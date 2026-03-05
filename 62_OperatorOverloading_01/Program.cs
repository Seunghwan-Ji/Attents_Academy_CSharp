namespace _62_OperatorOverloading_01
{
    class Door
    {
        private bool _isOpen = false;

        public Door(bool isOpen)
        {
            _isOpen = isOpen;
        }

        // 형변환 연산자 오버로딩
        // implicit 묵시적 형변환을 허용하겠다.

        /*
        public static implicit operator bool(Door c)
        {
           if (c._isOpen) return true;

           return false;
        }
        */

        // explicit은 묵시적 형변환을 허용하지 않는다.
        // 명시적형변환만 허용한다.
        public static explicit operator bool(Door c)
        {
            if (c._isOpen) return true;

            return false;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Door door = new Door(true);

            if ((bool)door)
            {
                Console.WriteLine("문이 열려있습니다.");
            }
            else
            {
                Console.WriteLine($"문이 닫혀있습니다.");
            }




        }
    }
}
