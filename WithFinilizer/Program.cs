using System.Diagnostics;

class A 
{
	~A(){}
}
class B 
{
	~B(){}
}
class C
{
	~C(){}
}

class Program
{
	static void Main()
	{
		
		int iteration = 1_000_000;
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		for(int i = 0; i < iteration; i++)
		{
			A a = new A();
			B b = new B();
			C c = new C();
		}
		stopwatch.Stop();
		Console.WriteLine(stopwatch.ElapsedMilliseconds);
		Dispose("this");
		
	}	
	static void Dispose(string obj)
	{
		
	}
}