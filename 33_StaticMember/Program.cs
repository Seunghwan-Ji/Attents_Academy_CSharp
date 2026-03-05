namespace _33_StaticMember
{
    // 프로퍼티: 클래스의 멤버필드에 접근할 수 있는 특별한 메소드입니다.

    class Student
    {
        private string _name; // 일반 멤버필드
        private int _grade;
        private int _classNum;

        private static int Count = 0; // 정적 멤버 필드

        public static int CCount // 정적 프로퍼티
        {
            get { return Count; }
            set { Count = value; }
        }

        public static int GetCount() // 정적 메소드
        {
            // 정적 메소드 안에서는 멤버 필드에 접근하면 안됩니다.
            // _name = "monster";

            // 정적 메소드는 객체의 생성과는 무관합니다.
            // 멤버 필드는 객체가 생성되어야 하지만 메모리에 위치하기 때문에
            // 정적 메소드에서 멤버 필드에 접근하시면 안됩니다.
            return Count;
        }

        public Student(string name, int grade, int classNum) // 인자를 받는 생성자
        {
            _name = name;
            _grade = grade;
            _classNum = classNum;
            Count++; // 정적멤버필드 Count의 값을 1증가
        }

        ~Student()
        {
            Count--;
            Console.WriteLine($"Student 소멸자 {Count}");
        }

        void ShowInfo()
        {
            Console.WriteLine($"이름: {_name}\n학년: {_grade}\n반: {_classNum}\n\n");
        }
    }

    internal class Program
    {

        // 정적 멤버는 객체의 생성과는 무관하게 존재하는 멤버입니다.
        static Student CreateStudent(string name, int grade, int classNum)
        {
            Student st = new Student(name, grade, classNum);

            return st;
        }

        static void CreateStudent2(string name, int grade, int classNum)
        {
            Student st = new Student(name, grade, classNum);
        }

        static void ProcessStudent()
        {
            // CreateStudent();
            GC.Collect();   // garbage collector에게 메모리 정리요청
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"학생 수는: {Student.CCount}");
            // 정적 프로퍼티로 Count에 접근
            // C#은 객체를 통해서 정적멤버에 접근할 수 없습니다.
            // 클래스명을 통해서만 접근할 수 있습니다.

            {
                // Student st0 = CreateStudent("monster1", 3, 11);
                CreateStudent2("monster1", 3, 11);

                Console.WriteLine($"학생수는: {Student.CCount}");

                {
                    // Student st1 = CreateStudent("monster2", 2, 10);
                    CreateStudent2("monster2", 2, 10);
                    Console.WriteLine($"학생 수는: {Student.GetCount()}");
                    {
                        CreateStudent2("monster3", 1, 7);
                        Console.WriteLine($"학생 수는: {Student.GetCount()}");
                    }
                    GC.Collect();
                    Console.Read(); // 멈춤
                    Console.WriteLine($"학생 수는: {Student.GetCount()}");
                }
                GC.Collect();
                Console.Read(); // 멈춤
                Console.WriteLine($"학생 수는: {Student.GetCount()}");
            }
            Student st3 = CreateStudent("monster4", 3, 5);
            GC.Collect();
            Console.Read(); // 멈춤
            Console.WriteLine($"학생 수는: {Student.GetCount()}");
        }
    }
}
