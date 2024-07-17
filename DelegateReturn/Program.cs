using System.Numerics;


public delegate int MyDelegate(int a, int b);
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
 class Program
 {
	static void Main()
	{
		Calculator cal = new();
		
		MyDelegate del = cal.Add;
		del +=cal.Subtract;
		Console.WriteLine(del.Invoke(5,4));
		
		
	}
	
 }