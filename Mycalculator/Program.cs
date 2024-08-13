using System.Numerics;

//generic Method
public class Calculator
{
	public T Add<T>(T a , T b)where T : IAdditionOperators<T,T,T>
	{
		if(a is decimal || b is double )
		{
			throw new Exception("Cannot add decimal 0");
		}
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
		Console.WriteLine(Math.Abs(cal.Add(1.1f, 2.2f) - 3.3f) < 1e-6f);		
		Console.WriteLine(cal.Add(1,9.8f) == 10.8f);
		Console.WriteLine(cal.Subtract(5.9M,8.0M));
		
		
		
	}
}