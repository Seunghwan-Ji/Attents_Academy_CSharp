namespace _90_Delegate_Chain
{
    delegate void Notify(string message);

    class Notifier // 발행자
    {
        public Notify EventOccured;
    }

    class EventListener // 구독자
    {
        private string _name;

        public EventListener(string name)
        {
            _name = name;
        }

        public void SomethingHappend(string message)
        {
            Console.WriteLine($"{_name}.SomethingHappend: {message}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Notifier notifier = new Notifier(); // 발행자

            EventListener listener1 = new EventListener("listener1");
            EventListener listener2 = new EventListener("listener2");
            EventListener listener3 = new EventListener("listener3");

            notifier.EventOccured += listener1.SomethingHappend; // 이벤트 구독
            notifier.EventOccured += listener2.SomethingHappend; // 이벤트 구독
            notifier.EventOccured += listener3.SomethingHappend; // 이벤트 구독

            notifier.EventOccured("You've got a mail");

            Console.WriteLine();

            notifier.EventOccured -= listener2.SomethingHappend; // listener2 구독 해지
            notifier.EventOccured("Download complete!!!");

            Console.WriteLine();

            notifier.EventOccured = new Notify(listener2.SomethingHappend) + new Notify(listener3.SomethingHappend);
            notifier.EventOccured("Nuclear launch detected!!");
            
            Console.WriteLine();

            Notify notify1 = new Notify(listener1.SomethingHappend);
            Notify notify2 = new Notify(listener2.SomethingHappend);

            notifier.EventOccured = (Notify)Delegate.Combine(notify1, notify2);
            notifier.EventOccured("Fire!!");

            Console.WriteLine();

            notifier.EventOccured = (Notify)Delegate.Remove(notifier.EventOccured, notify2);
            notifier.EventOccured("RPG!!");
        }
    }
}
