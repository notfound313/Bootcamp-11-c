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
	public T Multiply<T>(T a , T b)where T : IMultiplyOperators<T,T,T>
	{
		return a*b;
	}
	public T Divide<T>(T a , T b)where T : IDivisionOperators<T,T,T>
	{
		return a/b;
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
		
		
		
	}
}