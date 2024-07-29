class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Program Starting");



		Task threadPrint = new Task(Print);
		Task threadFax = new Task(Fax);
		Task threadScan = Task.Run(Scan);
		threadFax.Start();
		threadPrint.Start();
		// Task akan selesai ketika semua selesai
		// Task.WaitAll(threadPrint, threadFax, threadScan);	
		// Task akan selesai ketika salah satu selesai
		Task.WaitAny(threadPrint, threadFax, threadScan);


	
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
		Thread.Sleep(599);
		Console.WriteLine("Scan Finished");
	}
}