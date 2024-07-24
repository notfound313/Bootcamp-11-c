class Program
{
	
	static void Main()
	{
		try
	{
		int [] arr = new int[5];
		Console.WriteLine(arr[8]);
	}
	catch(Exception e)
	{
		Console.WriteLine(e.Message);
		
	}
		
	}
	
}