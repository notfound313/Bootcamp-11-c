class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Program Starting");


		//Return type
		Task<string> threadPrint = Task.Run(Print);
		Task threadFax = Task.Run(Fax);
		//Parameter
		Task threadScan = Task.Run(()=> Scan("gambar1"));// Task akan selesai ketika semua selesai
		Task.WaitAll(threadPrint, threadFax, threadScan);	
		
		//Return type
		Console.WriteLine(threadPrint.Result);


	
		Console.WriteLine("Program Finished");



	}

	static string Print()
	{
		Console.WriteLine("Print Start");
		Thread.Sleep(10000);
		return "Print Finished";
	
}
	static void Fax()
	{
		Console.WriteLine("Fax Strat");
		Thread.Sleep(11000);
		Console.WriteLine("Fax Finished");
	}
	static void Scan(string gambar)
	{
		Console.WriteLine("Scan Start");
		Thread.Sleep(599);
		Console.WriteLine($"Scan {gambar} Finished");
	}
}