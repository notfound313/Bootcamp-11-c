using System.Numerics;

//generic class
class Calculator<T> where T : INumber<T>
{
	public T Add(T a , T b)
	{
		return a+b;
		
	}
	public T  Subtract(T a , T b)
	{
		return a-b;
		
	}
	public T Multiply(T a , T b)
	{
		return a*b;
		
	}
	public T Divide(T a , T b)
	{
		return a/b;
		
	}
}


class Program
{
	static void Main()
	{
		Calculator<int> cal = new();
		Console.WriteLine(cal.Add(1,9));
		
		
		
	}
}