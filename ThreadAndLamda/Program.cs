class Program
{
	static void Main(string[] args)
	{
		//lamda Void
		Thread threadPrint = new Thread(()=>Print("Thread 1"));
		//nolamda
		Thread threadNoLmada = new Thread(Print);
		threadPrint.Start("halo");
		threadPrint.Join();
		Console.WriteLine("Print Finished");
		
	}
	
	static void Print(object message)
	{
		Console.WriteLine("Print Start");
		Thread.Sleep(10000);
		Console.WriteLine($"Print Finished {message}");
	}
	
}