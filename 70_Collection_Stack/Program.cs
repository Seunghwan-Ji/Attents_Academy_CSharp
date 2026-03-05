namespace _70_Collection_Stack
{
    using System.Collections;

    class UI
    {
        string _name;

        public UI(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return _name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack _stack = new Stack();

            UI _currentUI;

            UI main = new UI("메인UI");
            UI setup = new UI("설정");
            UI game = new UI("게임");
            UI option = new UI("option");

            _currentUI = main;

            _stack.Push(_currentUI);
            _currentUI = setup;
            _currentUI = (UI)_stack.Pop();

            Console.WriteLine($"{_currentUI}");

            _stack.Push(_currentUI);
            _currentUI = game;

            _currentUI = (UI)_stack.Pop();

            Console.WriteLine($"{_currentUI}");

        }
    }
}
