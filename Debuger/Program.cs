class Program
{
	static void Main()
	{
		Calculator cal = new Calculator();
		int result = cal.Add(2, 3);
		Console.WriteLine(result);

	}


}

class Calculator
{
	public int Add(int a, int b)
	{
		return a * b;
	}
}