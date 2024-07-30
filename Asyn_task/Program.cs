class Program
{
	static async Task Main(string[] args)
	{
		Console.WriteLine("Program Starting");


		//Return type
		Task<string> threadPrint = Task.Run(Print);
		Task threadFax = Task.Run(Fax);
		//Parameter
		Task threadScan = Task.Run(()=> Scan("gambar1"));// Task akan selesai ketika semua selesai
		await Task.WhenAll(threadPrint, threadFax, threadScan);	
		
		
		//Return type
		Console.WriteLine(threadPrint.Result);


	
		Console.WriteLine("Program Finished");



	}

	static async Task<string> Print()
	{
		Console.WriteLine("Print Start");
		await Task.Delay(10000);
		return "Print Finished";
	
}
	static async Task Fax()
	{
		Console.WriteLine("Fax Strat");
		await Task.Delay(11000);
		Console.WriteLine("Fax Finished");
	}
	static async Task Scan(string gambar)
	{
		Console.WriteLine("Scan Start");
		await Task.Delay(11000);
		Console.WriteLine($"Scan {gambar} Finished");
	}
}