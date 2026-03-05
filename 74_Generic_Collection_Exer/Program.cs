using System;

namespace Custom
{
    class List
    {
        private Node _headNode; // 헤드노드의 주소값을 저장
        private int _count; // 노드 갯수

        class Node
        {
            private Node _next;
            private int _data;
            
            public Node Next
            {
                set { _next = value; }
                get { return _next; }
            }

            public int Data
            {
                get { return _data; }
                set { _data = value; }
            }

            public Node(int data)
            {
                _data = data;
            }
        }

        public int Count
        {
            get => _count;
        }

        public List()
        {
            _headNode = null;
            _count = 0;
        }


        // 헤드노드를 변경하는 메소드
        public void InsertNewHead(int data)
        {
            if (_headNode == null)
            {
                _headNode = new Node(data);
            }
            else
            {
                Node n = new Node(data);
                n.Next = _headNode;
                _headNode = n;
            }

            _count++;
        }


        // 새로운 노드를 추가 메소드
        public void AppendNode(int data)
        {
            if (_headNode == null)
            {
                _headNode = new Node(data);
            }
            else
            {
                Node head = _headNode;

                while (head.Next != null)
                {
                    head = head.Next;
                }

                head.Next = new Node(data);
            }

            _count++;
        }


        // 새로운 노드를 삽입하는 메소드
        public void InsertNode(int num, int data)
        {
            // 리스트의 노드의 갯수보다 num이 큰거나 같은 경우 Append 처리한다.
            if (num >= _count)
            {
                AppendNode(data);
            }
            else
            {
                Node current = _headNode;
                while (num > 0)
                {
                    current = current.Next;
                    num--;
                }

                Node node = new Node(data);

                node.Next = current.Next;
                current.Next = node;
            }
        }


        // 노드를 삭제하는 메소드
        public void RemoveNode(int num)
        {
            // 삭제 할게 없음.
            if (num > _count)
            {
                return;
            }

            if (num == 0)    // 헤드노드 삭제
            {
                Node head = _headNode;
                _headNode = _headNode.Next;

                head.Next = null;
                _count--;
            }
            else
            {
                Node current = _headNode;
                num--; // num번째 노드를 삭제해야함.

                // num번째 이전노드를 찾는다.
                while (num > 0)
                {
                    current = current.Next;
                    num--;
                }

                Node remove = current.Next;
                current.Next = remove.Next;
                remove.Next = null;
                _count--;
            }
        }


        // num 번째 노드에서 Data를 가져옴.
        public int GetData(int num)
        {
            Node current = _headNode;

            // num번째 이전노드를 찾는다.
            while (num > 0)
            {
                current = current.Next;
                num--;
            }

            return current.Data;
        }
    }

}

namespace _74_Generic_Collection_Exer
{
    class Program
    {
        static void Main(string[] args)
        {
            Custom.List list = new Custom.List();

            for (int i = 0; i < 10; i++)
            {
                list.AppendNode(i);
            }



            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"list[{i}] =  {list.GetData(i)}");
            }

            Console.WriteLine();
            list.RemoveNode(2); // 2번째

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"list[{i}] =  {list.GetData(i)}");
            }

            Console.WriteLine();
            list.InsertNode(2, 10); // 2번째 뒤에 새로운 노드를 삽입

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"list[{i}] =  {list.GetData(i)}");
            }

        }
    }
}
