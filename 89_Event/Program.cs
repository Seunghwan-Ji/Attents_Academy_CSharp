using System;

namespace _89_Event
{
    // event
    //클래스내에 특정한 Event가 발생했을 때 외부에 이벤트 구독자(subscriber)에게 알려주는 기능을 합니다.
    // C#에서는 이벤트는 event 키워드사용 클래스내에서 일종 멤버 필드처럼 정의
    // event 특수한 형태의 delegate
    // event에 구독자를 추가시 (+=), 제거시에는 (-=), = (할당 연산자는 사용이 안됨)

    // event를 사용하는 이유
    // 1. 느슨한 결합(Loose coupling)
    // 발행자(Publisher)와 구독자(Subscriber)를 분리
    // 서로 직접적인 의존을 하지 않음.
    // 코드 변경이 쉬움

    // 2. 여러 곳에서 동시에 반응이 가능

    // 3. 안정성
    //   외부에서 이벤트에 접근 안됨...

    class MyTimer
    {
        public delegate void Tick(DateTime now);
        public event Tick Ticked; // MyTimer 클래스내부에서 호출이 가능
        private int interval;
        public Tick Ticked2; // 클래스 외부에서 호출가능.

        public MyTimer(int interval)
        {
            this.interval = interval;
        }

        public void start()
        {
            DateTime before = DateTime.Now;

            while (true) // 무한루프
            {
                DateTime current = DateTime.Now;

                if (before.AddSeconds(interval) < current)
                {
                    Ticked(current); // 이벤트는 클래스 내부에서만 호출이 가능               
                    before = current;
                }
            }
        }
    }

    class Monster
    {
        public void TimeEllapsed(DateTime current)
        {
            Console.WriteLine("Monster Time Ellapsed : {0}", current.ToLongTimeString());
        }

    }

    class Program
    {
        static void TimeEllapsed(DateTime current)
        {
            Console.WriteLine("Time Ellapsed : {0}", current.ToLongTimeString());
        }

        static void TimeEllapsed2(DateTime current)
        {
            Console.WriteLine("Time Ellapsed2 : {0}", current.ToLongTimeString());
        }

        static void TimeEllapsed3(DateTime current)
        {
            Console.WriteLine("Time Ellapsed3 : {0}", current.ToLongTimeString());
        }

        static void Main(string[] args)
        {
            MyTimer timer = new MyTimer(2);



            timer.Ticked += new MyTimer.Tick(TimeEllapsed); // 구독자         
            timer.Ticked += new MyTimer.Tick(TimeEllapsed2); // 구독자

            timer.Ticked(DateTime.Now); // event 는 외부에서만 호출가능



            Monster mons = new Monster();

            timer.Ticked += new MyTimer.Tick(mons.TimeEllapsed);

            timer.start();

            // 일반 delegate 참조변수
            timer.Ticked2 = new MyTimer.Tick(TimeEllapsed3);
            timer.Ticked2 += new MyTimer.Tick(TimeEllapsed3);

            timer.Ticked2(DateTime.Now); // 외부에서 호출가능
        }
    }
}
