class Program
{
	static void Main()
	{
		Console.WriteLine("Program starting");
		string result = "";
		Thread t1 = new Thread(() => result = Scan());
		Thread t2 = new Thread(() => Excution(ref result));
		t2.Start();
		t2.Join();
		Console.WriteLine(result);
		Console.WriteLine("Program finished");
	}
	
	static void Excution(ref string message)
	{
		Console.WriteLine("Scan finished"+message);
		
	}
	static string Scan() 
	{
		Console.WriteLine("Scan start");
		Thread.Sleep(5000);
		return "Scan finished";
	}
}