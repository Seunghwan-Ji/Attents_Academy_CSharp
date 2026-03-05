namespace _50_Partial_Class
{
	// partial 클래스는 클래스, 구조체, 메서드등을 두개 이상의 분할하는 것을 가능하게 합니다.
	// 1. 동일한 클래스의 모든 부분이 동일한 접근수준을 가져야함.
	// 2. 모든 부분은 동일한 네임 스페이스 안에 있어야 합니다.

	public partial struct A
	{
		public int _value;
	}

	partial class MyClass
	{
		public void Method1()
		{
			Console.WriteLine("Method1");
		}

		public void Method2()
		{
			Console.WriteLine("Method2");
		}
	}

	partial class MyClass
	{
		public void Method3()
		{
			Console.WriteLine("Method3");
		}

		public void Method4()
		{
			Console.WriteLine("Method4");
		}
	}

	class MainApp
	{
		static void Main(string[] args)
		{
			MyClass obj = new MyClass();
			obj.Method1();
			obj.Method2();
			obj.Method3();
			obj.Method4();

			A a;

			a._value2 = 20;
			a._value = 30;

			a.ShowInfo();
		}
	}
}
