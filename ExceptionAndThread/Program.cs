
using System.Reflection.Metadata;

class Program
{
	static void Main(string[] args)
	{
		
			Thread threadPrint = new Thread(()=> 
			
			{
				try 
				{
					Print();
				}catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			});
			Thread threadFax = new Thread(Fax);
			Console.WriteLine("Program Starting");
			threadFax.Start();
			threadPrint.Start();
			threadPrint.Join();
			threadFax.Join();
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