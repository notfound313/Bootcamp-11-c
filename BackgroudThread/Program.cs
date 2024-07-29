class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Program Starting");
		
		
		Thread threadPrint = new Thread(Print);
		Thread threadFax = new Thread(Fax);
		Thread threadScan = new Thread(Scan);
		
		//secara default, thread berjalan di foreground
		//namu bisa diset dengan berjalan di Background
		threadFax.IsBackground = true;
		threadScan.IsBackground = true;
		threadPrint.IsBackground = true;	
		
		threadPrint.Start();
		threadFax.Start();
		threadScan.Start();
		
		// threadPrint.Join();
		// threadFax.Join();
		// threadScan.Join();
		
		
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