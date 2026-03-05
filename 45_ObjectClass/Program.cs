/*
namespace System
{
   public class Object
   {
      public Object();
      ~Object();
      public static bool Equals(Object? objA, Object? objB); // 참조형객체의 경우 참조값을 비교, 값타입 값을 비교
      public static bool ReferenceEquals(Object? objA, Object? objB); // 참조형 값을 비교.
      public virtual bool Equals(Object? obj);
      public virtual int GetHashCode(); // 특정 인스턴스를 고유하게 식별할 수 있는 4byte int형 코드값
      public Type GetType(); // 인스턴스에서 타입을 얻어낸다.
      public virtual string? ToString();   // 기본적으로 해당 instance가 속한 클래스의 전체이름 반환한다.
      protected Object MemberwiseClone(); // 객체를 복사할 때 사용 (
      // shallow copy (얕은복사) 할때
      // deep Copy (깊은 복사)
}
*/

namespace _45_ObjectClass
{
    class A
    {
        public int _value;
        public A(int vlaue)
        {
            _value = vlaue;
        }
    }

    class B : A
    {
        public B(int value)
            : base(value)
        {

        }
    }

    class C : B
    {
        public C(int value)
            : base(value)
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Object
            A aObj = new A(10);
            B bObj = new B(10);
            C cObj = new C(10);

            Console.WriteLine($"aObj.toString() = {aObj.ToString()}");
            Console.WriteLine($"bObj.toString() = {bObj.ToString()}");
            Console.WriteLine($"cObj.toString() = {cObj.ToString()}");

            Console.WriteLine($"aObj.GetType().FullName = {aObj.GetType().FullName}");
            Console.WriteLine($"aObj.GetType().IsClass = {aObj.GetType().IsClass}");
            Console.WriteLine($"aObj.GetType().IsArray = {aObj.GetType().IsArray}");

            // 참조 타입은 참조값을 비교
            A aObj2 = new A(10);
            A refaObj = aObj2;

            bool isEqual = aObj2.Equals(aObj);
            Console.WriteLine($"aObj == aObj2 => {isEqual}");

            isEqual = aObj2.Equals(refaObj);
            Console.WriteLine($"aObj2 == refaObj => {isEqual}");

            isEqual = object.Equals(aObj, aObj2);
            Console.WriteLine($"aObj == aObj2 => {isEqual}");

            // 값 타입 비교
            // value type(값 타입)은 저장된 값을 비교.
            int a = 3;
            int b = 3;

            bool ret = a.Equals(b);
            Console.WriteLine($"a == b => {ret}");
        }
    }
}
