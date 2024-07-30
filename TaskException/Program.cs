
using System.Reflection.Metadata;

class Program
{
	static void Main(string[] args)
	{
		
			Task threadPrint = new Task(Print);
			Task threadFax = new Task(Fax);
			Console.WriteLine("Program Starting");
			try
			{
			threadFax.Start();
			threadPrint.Start();
			Task.WaitAll(threadPrint, threadFax);
				
			}catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			
		
			Console.WriteLine("Program Finished");
		
	}
	

	
	static void Print()
	{
		int [] arr = new int[5];
		
		Thread.Sleep(10000);
		Console.WriteLine(arr[8]);
	}
	static void Fax()
	{
		Console.WriteLine("Fax Strat");
		Thread.Sleep(11000);
		Console.WriteLine("Fax Finished");
	}
	
}