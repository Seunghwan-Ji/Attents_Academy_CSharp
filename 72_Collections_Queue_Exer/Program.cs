namespace _72_Collections_Queue_Exer
{
    using System.Collections;

    // 간단한 은행 대기 시스템


    // 은행 창구 시스템입니다.
    // Queue를 사용해서 아래 코드가 작동하도록
    // class BankQueue를 만들어보세요... 

    // joinQueue 대기줄에 서기
    // CallNext() 다음 손님 부르기
    // WaitingCount() 대기 손님 명수 
    class BankQueue
    {
        private Queue _customers;   // 고객 대기줄

        public BankQueue()
        {
            _customers = new Queue();
        }

        public void JoinQueue(string name)
        {
            _customers.Enqueue(name);

            Console.WriteLine($"{name}님이 대기줄에 섰습니다. (대기인원: {_customers.Count})");
        }

        // 다음 고객 호출
        public void CallNext()
        {
            if (_customers.Count > 0)
            {
                string next = _customers.Dequeue() as string;
                Console.WriteLine($"{next}님 창구로 오세요~~~");

            }
            else
            {
                Console.WriteLine("대기 고객이 없습니다.");
            }
        }

        // 대기 인원 확인
        public int WaitingCount()
        {
            return _customers.Count;
        }
    }



    public class Program
    {
        public static void Main()
        {
            BankQueue bank = new BankQueue();

            // 대기표를 뽑음.
            bank.JoinQueue("Dragon");
            bank.JoinQueue("Ogre");
            bank.JoinQueue("Goblin");
            bank.JoinQueue("Slime");

            Console.WriteLine($"현재 대기 인원: {bank.WaitingCount()}명");
            Console.WriteLine();

            // 은행원 다음 손님을 호출
            bank.CallNext();
            bank.CallNext();

            Console.WriteLine($"남은 대기 인원: {bank.WaitingCount()}명");
            bank.CallNext();
            bank.CallNext(); // 아무도 없음

            Console.WriteLine($"남은 대기 인원: {bank.WaitingCount()}명");
        }
    }
}
