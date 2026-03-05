namespace _59_Polymorphism_CoffeeShop
{
    // 다형성(Polymorphism)
    // 개발자가 되었습니다.
    // 커피숖 관리 프로그램을 만들어 달라는 개발의뢰를 받았습니다.
    // 뭐부터 해야 하나요?

    // 커피숖에 가서 커피 한잔을 시키고 앉아서 커피숖의 업무를 흐름을 파악해야 합니다.
    // 업무 흐름속에는 역활(role)과 책임(responsibility)이 있습니다.

    // 커피숖에는 어떤 역활이 있나요?
    // Cashier(주문받는다, 돈계산, 음료요청), Barista(음료만든다), Guest(음료주문, 돈을 지불)


    // 추상메소드를 하나라도 가지고 있는 클래스를 추상클래스라고 합니다.
    // 추상클래스는 자신의 객체를 만들 수 없습니다.
    // 대신에 자신에게서 상속받은 자식클래스는 자신의 추상메소드를 반드시
    // 구현하도록 강제할 수 있습니다.
    abstract class Drink
    {

        private string _name;

        public virtual string Name { get => _name; }

        public Drink()
        {
            _name = "음료";
        }

        public abstract void MakeADrink(); // 추상메소드 (구현부가 없음)

    }

    class Coffee : Drink
    {
        private string _name;

        public override string Name { get => _name; }

        public Coffee()
        {
            _name = "커피";
        }

        public override void MakeADrink() // 부모의 가상메소드를 자식이 재정의하는 것을 overrice(오버라이드)
        {
            Console.WriteLine($"커피를 만듭니다.");
        }
    }

    class Latte : Drink
    {
        private string _name;

        public override string Name { get => _name; }

        public Latte()
        {
            _name = "라떼";
        }

        public override void MakeADrink()
        {
            Console.WriteLine($"라떼를 만듭니다.");
        }

    }

    class Tea : Drink
    {
        private string _name;

        public override string Name { get => _name; }

        public Tea()
        {
            _name = "차";
        }

        public override void MakeADrink()
        {
            Console.WriteLine($"차를 만듭니다.");
        }

    }

    class Cola : Drink
    {
        private string _name;

        public override string Name { get => _name; }

        public Cola()
        {
            _name = "콜라";
        }

        public override void MakeADrink()
        {
            Console.WriteLine($"콜라를 만듭니다.");
        }

    }

    class Cidar : Drink
    {
        private string _name;

        public override string Name { get => _name; }

        public Cidar()
        {
            _name = "사이다";
        }

        public override void MakeADrink()
        {
            Console.WriteLine($"사이다를 만듭니다.");
        }
    }

    class Americano : Drink
    {
        private string _name;
        public override string Name { get => _name; }

        public Americano()
        {
            _name = "아메리카노";
        }

    }



    class Barista
    {
        public void MakeADrink(Drink drink)
        {
            drink.MakeADrink();
        }
    }

    class Cashier
    {
        private Barista _bari;  // 포함, agreggation(참조)

        public Cashier(Barista bari)
        {
            _bari = bari;
        }

        public void OrderedDrink(Drink drink)
        {
            Console.WriteLine($"{drink.Name}를 주문받습니다.");
            _bari.MakeADrink(drink);

        }
    }

    class Guest
    {
        public void OrderingDrink(Cashier cashier, Drink drink) // 의존적관계(Dependency), 일시적 관계
        {
            Console.WriteLine($"{drink.Name}를 주문합니다.");
            cashier.OrderedDrink(drink);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Drink drink = new Drink(); // 추상클래스는 객체를 생성할 수 없습니다.

            Barista bari = new Barista();
            Cashier cashier = new Cashier(bari);
            Guest guest = new Guest();

            guest.OrderingDrink(cashier, new Coffee());
            Console.WriteLine();
            guest.OrderingDrink(cashier, new Latte());
            Console.WriteLine();
            guest.OrderingDrink(cashier, new Tea());
            Console.WriteLine();
            guest.OrderingDrink(cashier, new Cidar());
            Console.WriteLine();
            guest.OrderingDrink(cashier, new Americano());
        }
    }
}







