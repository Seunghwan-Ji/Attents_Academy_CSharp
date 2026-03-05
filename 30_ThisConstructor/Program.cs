namespace _30_ThisConstructor
{
    // this: 클래스의 현재 인스턴스를 가리키는 키워드.
    // this constructor
    // constructor 뜻: 생성자.
    class Monster
    { 
        private int _health, _attack, _defense; // 멤버필드

        public Monster() // 기본 생성자
        {
            Console.WriteLine("기본 생성자");
            this._health = 100;
        }

        public Monster(int attack) : this() // Monster(int) 생성자를 호출하면서 기본 생성자(this())를 호출.
        {
            Console.WriteLine("인자 1개를 받는 생성자");
            this._attack = attack;
        }

        public Monster(int attack, int defense) : this(attack)
        {
            Console.WriteLine("인자 2개를 받는 생성자");
            this._defense = defense;
        }

        public void Info()
        {
            Console.WriteLine($"생명력: {_health}, 공격력: {_attack}, 방어력: {_defense}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Monster a = new Monster(); // 기본 생성자.
            a.Info();

            Console.WriteLine();

            Monster b = new Monster(50); // 인자를 하나 받는 생성자 호출.
            b.Info();

            Console.WriteLine();

            Monster c = new Monster(50, 30); // 인자를 두 개 받는 생성자 호출.
            c.Info();
        }
    }
}
