class MyDestructor 
{
	public MyDestructor()
	{
		Console.WriteLine($"Constructor {GC.GetGeneration(this)}");
		
	}
	
	~MyDestructor()
	{
		Console.WriteLine($"Destructor {GC.GetGeneration(this)}");
	}
}

class Program
{
	static void Main()
	{
		Instance();
		GC.Collect();
		GC.WaitForPendingFinalizers();
	}
	static void Instance()
{
	MyDestructor md = new MyDestructor();

	
}
	
}


