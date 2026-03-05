namespace _56_Composition_Exer
{
    class Point
    {
        private int _x, _y;

        public int X
        {
            get => _x;
        }

        public int Y
        {
            get => _y;
        }

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public Point(Point pt) // 복사 생성자
        {
            _x = pt._x;
            _y = pt._y;
        }

        public void Info()
        {
            Console.WriteLine($"x: {_x}, y: {_y}");
        }
    }

    class Line
    {
        private readonly Point _pt1, _pt2;

        public Line(int pt1x, int pt1y, int pt2x, int pt2y)
        {
            _pt1 = new Point(pt1x, pt1y);
            _pt2 = new Point(pt2x, pt2y);
        }

        public Line(Point pt1, Point pt2)
        {
            _pt1 = new Point(pt1);
            _pt2 = new Point(pt2);
        }

        public float GetLength()
        {
            int xBase = _pt2.X - _pt1.X;
            int yBase = _pt2.Y - _pt1.Y;

            return (float)Math.Sqrt(Math.Pow(xBase, 2) + Math.Pow(yBase, 2));
        }
    }

    // 삼각형 클래스(직각삼각형)
    // 사각형 클래스 (직각사각형)
    // 원클래스

    // 각각의 도형 클래스만들고 면적을 구하는 메소드를 추가한 후에
    // 각각의 도형객체만들고 면적을 출력해세요

    class Triangle
    {
        private Point _PointLB;
        private Point _PointRB;
        private Point _PointLT;

        public Triangle(Point PointLB, Point PointRB, Point PointLT)
        {
            _PointLB = PointLB;
            _PointRB = PointRB;
            _PointLT = PointLT;
        }

        public float GetArea()
        {
            Line baseLine = new Line(_PointLB, _PointRB);
            Line height = new Line(_PointLB, _PointLT);

            return (baseLine.GetLength() * height.GetLength()) / 2;
        }
    }

    class Rectangle
    {
        private Point _PointLT;
        private Point _PointRB;

        public Rectangle(Point PointLT, Point PointRB)
        {
            _PointLT = PointLT;
            _PointRB = PointRB;                        
        }

        public float GetArea()
        {
            float baseLine = _PointRB.X - _PointLT.X;
            float height = _PointLT.Y - _PointRB.Y;

            return baseLine * height;
        }
    }

    class Cycle
    {
        private Line _PointR;

        public Cycle(Line radius)
        {
            _PointR = radius;
        }

        public float GetArea()
        {
            float radius = _PointR.GetLength();
            return 3.14f * radius * radius;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Point PointLB = new Point(0, 0);
            Point PointRB = new Point(5, 0);
            Point PointT = new Point(0, 5);

            Triangle triangle = new Triangle(PointLB, PointRB, PointT);
            Console.WriteLine($"직각삼각형 면적: {triangle.GetArea()}");

            Point PointLT = new Point(0, 5);
            Point PointRT = new Point(5, 5);

            Rectangle rectangle = new Rectangle(PointLT, PointRB);
            Console.WriteLine($"직사각형 면적: {rectangle.GetArea()}");

            Line radius = new Line(new Point(0, 0), new Point(0, 5));

            Cycle cycle = new Cycle(radius);
            Console.WriteLine($"원 면적: {cycle.GetArea()}");
        }
    }
}
