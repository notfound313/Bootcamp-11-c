class Program
{
	static void Main()
	{
		Console.WriteLine("Program Starting");
		
		
		Print();
		Fax();
		Scan();
		
		Console.WriteLine("Program Finished");
		
	}
	
		static void Print()
	{
		Console.WriteLine("Print Start");
		Thread.Sleep(10000);
		Console.WriteLine("Print Finished");
		
	}
	static void Fax()
	{
		Console.WriteLine("Fax Strat");
		Thread.Sleep(11000);
		Console.WriteLine("Fax Finished");
		
	}
	
	static void Scan()
	{
		Console.WriteLine("Scan Start");
		Thread.Sleep(500);
		Console.WriteLine("Scan Finished");
		
	}
	
}