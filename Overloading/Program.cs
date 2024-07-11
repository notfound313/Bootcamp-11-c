class Calculator
{
	public double Add(double a, double b)
	{
		return a+b;
	}
	public float Add(float a, float b)
	{
		return a+b;
	}
	public int Add(int a, int b)
	{
		return a+b;
	}
	
	//unlimited parameters
	
	public int Subtriction(params int[] data)
	{
		int result = 0;
		
		foreach (int i in data)
		{
			result +=i;
			
		}
		return result;
	}
	
	//overloading yang kurang tepat karena para meterr yang sama tipe data
	// public void Add(int a, int b)
	// {
	// 	Console.WriteLine(a+b);
	// }
}

class Program
{
	static void Main()
	{
		Calculator cal = new();
		float fa = 1;
		float fb = 2;
		cal.Add(fa, fb); 
		int result = cal.Subtriction(1,3,4,5,6,7,9);
		Console.WriteLine(cal.Subtriction(result)); 
	}
}