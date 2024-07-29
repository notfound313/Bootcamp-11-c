class Program
{
	static void Main()
	{
		Console.WriteLine("Program Starting");
		Console.WriteLine("Print Start");
		Console.WriteLine("Fax Start");
		Console.WriteLine("Scan Start");
		
		Print();
		Fax();
		Scan();
		
		Console.WriteLine("Program Finished");
		
	}
	
	static void Print()
	{
		Thread.Sleep(10000);
		Console.WriteLine("Print Finished");
		
	}
	static void Fax()
	{
		Thread.Sleep(11000);
		Console.WriteLine("Fax Finished");
		
	}
	
	static void Scan()
	{
		Thread.Sleep(500);
		Console.WriteLine("Scan Finished");
		
	}
	
}