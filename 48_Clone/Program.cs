namespace _48_Clone
{
    /// <summary>
    /// 얕은 Copy
    /// </summary>
    class Top
    {
        public int a = 100;
        public int b = 200;

        public Top Copy()
        {
            /*
            Top temp = new Top();
            temp.a = a;
            temp.b = b;

            return temp;
            */
            return (Top)this.MemberwiseClone();
            // MemberwiseClone() : 객체를 복사할때 사용. (얕은 복사) 객체 clone
            // MemberwiseClone 함수는 오브젝트 타입을 반환하기 원래 타입으로 형변환.
        }
    }

    class Child
    {
        public int age = 10;
        public int height = 20;
        public Top grand = new Top();

        public Child DeepCopy()
        {
            Child child = Copy();
            child.grand = this.grand.Copy();


            return child;
        }

        public Child Copy()
        {
            // MemberwiseClone(얕은 복사) : 객체를 복사할때 사용.
            return (Child)this.MemberwiseClone();  // 얕은 copy 객체 clone
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Child c1 = new Child();

            Child c3 = c1;

            Child c2 = c1.DeepCopy();

            Console.WriteLine($"c1 == c2: {object.ReferenceEquals(c1, c2)}");
            // ReferenceEquals() : 객체의 참조가 같은지 비교하는 메서드. (주소값 비교)
            Console.WriteLine($"c1.height = c2.height: {object.ReferenceEquals(c1.height, c2.height)}");

            Console.WriteLine($"c.HashCode = {c1.GetHashCode()}");
            // GetHashCode() : 객체의 해시 코드를 반환하는 메서드. (객체의 고유한 식별자)
            Console.WriteLine($"c2.HashCode = {c2.GetHashCode()}");

            Child c4 = c1;
            Console.WriteLine($"c3.HashCode = {c3.GetHashCode()}");
            Console.WriteLine($"c4.HashCode = {c4.GetHashCode()}");

            Console.WriteLine($"c1.grand != c2.grand: {object.ReferenceEquals(c1.grand, c2.grand)}");

            Console.WriteLine($"c1.HashCode {c1.GetHashCode()}");
            Console.WriteLine($"c2.HashCode {c2.GetHashCode()}");
        }
    }
}
