namespace _71_Collections_Queue
{
    using System.Collections;
    class Program
    {
        static void Main(string[] args)
        {
            Queue _queue = new Queue();

            object[] worklist = new object[] { "달리기", 3, 2, 1, "팔굽혀펴기", 2, 1, "턱걸이", 2, 1, "운동끝" };

            foreach (var obj in worklist)
            {
                _queue.Enqueue(obj);
            }

            foreach (var obj in _queue)
            {
                Console.WriteLine($"{obj}");
            }


            if (_queue.Contains("팔굽혀펴기"))
            {
                Console.WriteLine($"팔굽혀펴기가 큐에 있습니다.");
            }


            while (_queue.Count > 0)
            {
                object obj = _queue.Dequeue();
                Console.WriteLine($"Count: {_queue.Count} : {obj}");

            }
        }
    }
}
