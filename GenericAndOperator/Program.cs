using System.Numerics;

//generic Method
class Calculator
{
	public T Add<T>(T a , T b)where T : IAdditionOperators<T,T,T>
	{
		return a+b;
		
	}
	public T Subtract<T>(T a , T b)where T : ISubtractionOperators<T,T,T>
	{
		return a-b;
	}
	
}

class Person : IAdditionOperators<Person,Person,Person>, ISubtractionOperators<Person,Person,Person>
{
	public string name;
	public int saldo;
	
	public static Person operator-(Person a , Person b)
	{
		Person c = new();
		c.name = a.name+b.name;
		return c;
	}
	public static Person operator+(Person a , Person b)
	{
		Person c = new();
		c.saldo = a.saldo-b.saldo;
		return c;
	}
}


class Program
{
	static void Main()
	{
		Calculator cal = new();
		Console.WriteLine(cal.Add(1,9));
		Console.WriteLine(cal.Add(1,9.8f));
		Console.WriteLine(cal.Subtract(5.9M,8.0M));
		Person mantu = new();
		Person mertua = new();
		mantu.name="jono";
		mertua.name="januari";
		mertua.saldo=100;
		mantu.saldo= 100;
		
		Person resulSaldoMantu = cal.Add(mertua,mantu);
		Console.WriteLine($"saldo mantu = {resulSaldoMantu.saldo}");
		
		
		
	}
}