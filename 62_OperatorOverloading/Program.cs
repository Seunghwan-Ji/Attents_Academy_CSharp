namespace _62_OperatorOverloading
{
    // 연산자 오버로딩
    // 사용자 만든 DataType에 연산기호를 사용하는 방법을 제공하는 것

    class Complex
    {
        private int _real;
        private int _imaginary;

        public Complex(int real, int imaginary)
        {
            _real = real;
            _imaginary = imaginary;
        }

        public static Complex add(Complex left, Complex right)
        {
            return new Complex(left._real + right._real, left._imaginary + right._imaginary);
        }

        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex(left._real + right._real, left._imaginary + right._imaginary);
        }

        public static Complex operator +(Complex left, int right)
        {
            return new Complex(left._real + right, left._imaginary);
        }

        public static bool operator <(Complex left, Complex right)
        {
            return left._real < right._real;
        }

        public static bool operator >(Complex left, Complex right)
        {
            return left._real < right._real;
        }

        public override string ToString()
        {
            if (_imaginary < 0)
            {
                return $"{_real}{_imaginary}i";
            }
            else
            {
                return $"{_real} + {_imaginary}i";
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(10, 10);
            Complex b = new Complex(20, -20);

            Complex c = a + b;

            Console.WriteLine($"c = {c.ToString()}");

            Complex d = a + 1;
            Console.WriteLine($"d = {c.ToString()}");

            // 관계연산자를 연산자 오버로딩해보세요...
            bool ret = a < b;

            Console.WriteLine($"{a} < {b} = {ret}");

        }
    }
}
