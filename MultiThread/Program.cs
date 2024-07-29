class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Program Starting");
		Console.WriteLine("Print Start");
		Console.WriteLine("Fax Strat");
		Console.WriteLine("Scan Start");
		
		Thread threadPrint = new Thread(Print);
		Thread threadFax = new Thread(Fax);
		Thread threadScan = new Thread(Scan);
		
		threadPrint.Start();
		threadFax.Start();
		threadScan.Start();
		
		threadPrint.Join();
		threadFax.Join();
		threadScan.Join();
		
		
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