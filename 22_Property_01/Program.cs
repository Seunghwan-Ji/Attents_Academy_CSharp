namespace _22_Property_01
{
    // 접근제어자
    // private: 외부에서 접근하는 것을 허용하지 않겠다. (기본)
    // protected: 자식의 접근은 허용, 외부에서 접근은 불허.
    // public: 외부에서 접근하는 것을 허용

    // 멤버필드는 외부에서 접근하는 것이 허용하지말라고 합니다. (권고사항)
    // property를 사용해서 접근하도록 해라.

    class Son
    {
        private string address; // 멤버 필드
        protected int birthday;
        private int age;
        //private string telephone;

        // property
        // 프로퍼티는 멤버필드에 접근해서 값을 가지고오거나 값을 저장하는 
        // 기능을 가진 함수

        public string Address
        {
            get // 값 전달
            {
                return address;
            }

            // private set ; 외부에서 값을 변경할 수 없음.
            set // 값을 변경 접근제어자의 영향을 받습니다.
            {
                address = value;
            }
        }

        public int Birthday
        {
            get => birthday;
            set => birthday = value;
        }

        public string Telephone { set; get; } // 자동 구현 property

        // 멤버필드에 Property로 접근할 때의 장점.
        // 1. 데이터 무결성 유지 가능성.
        // 2. 디버깅 작업 용이성.
        public int Age
        {
            set
            {
                if (value > 200)
                {
                    age = 200;
                }
                else if (value <= 0)
                {
                    age = 1;
                }
                else
                {
                    age = value;
                }
            }

            get
            {
                return age;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Son son = new Son();
            son.Address = "런던";
            son.Birthday = 19931111;
            son.Age = 38;
            son.Telephone = "010-1111-1111";

            Console.WriteLine($"주소: {son.Address}");
            Console.WriteLine($"생년월일: {son.Birthday}");
            Console.WriteLine($"나이: {son.Age}");
            Console.WriteLine($"전화번호: {son.Telephone}");

            son.Age = 400;
            Console.WriteLine($"나이: {son.Age}");
        }
    }
}
